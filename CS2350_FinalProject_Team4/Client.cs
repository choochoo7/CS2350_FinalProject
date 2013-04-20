using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CS2350_FinalProject_Team4
{
    class Client
    {
        // private int clientNumber;
        private int gender;
        private string firstName;
        private string lastName;
        private int age;
        private string hairColor;
        private int height;
        private ArrayList currentClient;
        // private Graphics graphObj;

        // this is a no - agrument constructor
        public Client()
        {
            currentClient = new ArrayList();
            currentClient.Add(getGender());        // 0
            currentClient.Add(getFirstName());     // 1
            currentClient.Add(getLastName());      // 2
            currentClient.Add(getAge());           // 3
            currentClient.Add(getHairColor());     // 4
            currentClient.Add(getHeight());        // 5
            Honesty honesty = new Honesty();
            currentClient.Add(honesty.HonestyRating);               // 6
            Responsibility responsibility = new Responsibility();
            currentClient.Add(responsibility.ResponsibilityRating); // 7
            Adaptability adaptability = new Adaptability();
            currentClient.Add(adaptability.AdaptabilityRating);     // 8
            Understanding understanding = new Understanding();
            currentClient.Add(understanding.UnderstandingRating);   // 9
            Patience patience = new Patience();
            currentClient.Add(patience.PatienceRating);             //  10
            Reliability reliability = new Reliability();
            currentClient.Add(reliability.ReliabilityRating);       // 11
            Boldness boldness = new Boldness();
            currentClient.Add(boldness.BoldnessRating);             // 12



        }


        public static int getGender()
        {
            int gend; //local variable
            string inValue;
            //call screen graphic method
            Graphics.GenderConsole();
            Console.SetCursorPosition(21, 22);
            Console.Write("Please enter 1 for Female or 2 for Male:\n");
            Console.SetCursorPosition(40, 27);
            inValue = Console.ReadLine();
            gend = intCheck(inValue, 1);

            //delay screen
            Thread.Sleep(200);

            if (gend == 1)
                Graphics.FemaleConsole();
            else
                if (gend == 2)
                    Graphics.MaleConsole();
            //delay screen
            Thread.Sleep(200);

            return gend;
        }

        public static string getFirstName()
        {
            string fName;   //local variable

            Console.SetCursorPosition(26, 22);
            Console.Write("Please enter your first name:\n");
            Console.SetCursorPosition(35, 27);
            fName = Console.ReadLine();
            Console.Clear();

            return fName;
        }

        public static string getLastName()
        {
            string lName;   //local variable

            Console.SetCursorPosition(26, 22);
            Console.Write("Please enter your last name:\n");
            Console.SetCursorPosition(35, 27);
            lName = Console.ReadLine();
            Console.Clear();

            return lName;
        }

        public static int getAge()
        {
            int age;   //local variable
            string inValue;

            Console.SetCursorPosition(26, 22);
            Console.Write("Please enter your numeric Age:\n");
            Console.SetCursorPosition(35, 27);
            inValue = Console.ReadLine();
            age = intCheck(inValue, 2);
            Console.Clear();

            return age;
        }

        public static string getHairColor()
        {
            string hair;   //local variable

            Console.SetCursorPosition(26, 22);
            Console.Write("Please enter your hair color:\n");
            Console.SetCursorPosition(35, 27);
            hair = Console.ReadLine();
            Console.Clear();

            return hair;
        }

        public static int getHeight()
        {
            int hght;   //local variable
            string inValue;

            Console.SetCursorPosition(26, 22);
            Console.Write("Please enter your height:\n");
            Console.SetCursorPosition(35, 27);
            inValue = Console.ReadLine();
            hght = intCheck(inValue, 2);
            Console.Clear();

            return hght;
        }

        public ArrayList CurrentClient
        {
            get { return currentClient; }
        }

        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string HairColor
        {
            get { return hairColor; }
            set { hairColor = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        //  error checking for proper integer range user entry
        //  codes: 1 = (1 or 2), 2 = (any int 1-99)
        public static int intCheck(string inValue, int errorCode)
        {
            int userInput = 1000;
            int i = 2;  //space for multiple console entries
            int tries = 1; //how many errors have occured
            bool correct = false;
            while (correct == false)
            {
                if (int.TryParse(inValue, out userInput))   //TryParse loop to allow keyevent check for non-numeric values
                {
                    userInput = Convert.ToInt32(inValue);
                    

                    switch (errorCode)
                    {
                        case 1:
                            if (userInput < 3 && userInput > 0)
                                correct = true;
                            else
                            {
                                string display;
                                
                                switch (tries)  //vary output message
                                {
                                    case 1:
                                        display = "With 2 choices, you picked the third......\n\nTry again."; tries++;
                                        break;
                                    case 2:
                                        display = "Are you playing this in your sleep again?\n\nTry again."; tries++;
                                        break;
                                    case 3:
                                        display = "Maybe we should have included an intelligence rating........\n\nTry again..AGAIN..."; tries++;
                                        break;
                                    default:
                                        display = "I'd ask you to look up the word hopeless, but frankly I'm not sure you'd know how..."; tries++;
                                        break;
                                }

                                //invalid entry
                                MessageBox.Show(display, "This isn't that hard, try to pay attention.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Console.SetCursorPosition(35, (27 + i));
                  //              i++;
                                inValue = Console.ReadLine();
                            }
                            break;
                        case 2:
                            if (userInput > 0 && userInput < 100)
                                correct = true;
                            else
                            {
                                string display;
                                
                                switch (tries)  //vary output message
                                {
                                    case 1:
                                        display = "Are you sure you should be doing this? Please enter a REALISTIC number.\n\nTry again."; tries++;
                                        break;
                                    case 2:
                                        display = "HELLO...Earth to space cadet, THIS isn't rocket science.\n\nTry again."; tries++;
                                        break;
                                    case 3:
                                        display = "Did you actually read the directions?\n\nTry again..AGAIN..."; tries++;
                                        break;
                                    default:
                                        display = "I'm guessing you are very familiar with the phrase:\n\n" +
                                            "Do you want fries with that?..."; tries++;
                                        break;
                                }
                                //invalid entry
                                MessageBox.Show(display, "Seriously?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Console.SetCursorPosition(35, (27 + i));
                  //              i++;
                                inValue = Console.ReadLine();
                            }
                            break;
                        default:
                            break;
                    }   //close switch


                }   //close try parse loop

                i++;

            }   //close while

            return userInput;

        }   //close intCheck method


    }   //close class

}   //close namespace
