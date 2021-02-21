using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Finch Control - Talent Show
    // Description: A small demo of the Finch robot, demonstarting
    //              its lights, sound and movement.
    // Application Type: Console
    // Author: Taber, Jake
    // Dated Created: 2/17/2021
    // Last Modified: 2/20/2021
    //
    // **************************************************

    class Program
    {
        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        #region MAIN MENU

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayMenuScreen(finchRobot);
                        break;

                    case "c":
                        DataRecorderDisplayMenuScreen(finchRobot);
                        break;

                    case "d":
                        AlarmSystemDisplayMenuScreen(finchRobot);
                        break;

                    case "e":
                        UserProgrammingDisplayMenuScreen(finchRobot);
                        break;

                    case "f":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        #endregion

        #region TALENT SHOW

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        static void TalentShowDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Dance");
                Console.WriteLine("\tc) Mixing It Up");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayDance(finchRobot);
                        break;

                    case "c":
                        TalentShowDisplayMixingItUp(finchRobot);
                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayLightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light and Sound");

            Console.WriteLine("\tThe Finch robot will now play the intro of World 1-1 from Super Mario Bros.!");
            DisplayContinuePrompt();
            finchRobot.noteOn((int)1567.98);
            finchRobot.setLED(97, 133, 248);
            finchRobot.wait(100);
            finchRobot.noteOff();
            finchRobot.noteOn((int)1567.98);
            finchRobot.setLED(149, 75, 12);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.noteOn((int)1567.98);
            finchRobot.setLED(104, 70, 50);
            finchRobot.wait(300);
            finchRobot.noteOn((int)1318.51);
            finchRobot.setLED(19, 130, 0);
            finchRobot.wait(225);
            finchRobot.noteOn((int)1567.98);
            finchRobot.setLED(238, 175, 54);
            finchRobot.wait(300);
            finchRobot.noteOn((int)1864.66);
            finchRobot.setLED(255, 0, 0);
            finchRobot.wait(200);
            finchRobot.noteOff();
            finchRobot.setLED(0, 0, 0);

            Console.WriteLine("I'm not sure if you noticed but the colors used were the major colors used in the original games color pallet!");
            DisplayMenuPrompt("Talent Show Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Dance                *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayDance(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Dance");

            Console.WriteLine("\tThe Finch robot will now show it's movement potential!");
            Console.WriteLine("\tPlease keep the cord above the robot so it doesn't tangle itself!");
            DisplayContinuePrompt();

            finchRobot.setMotors(100, 100);
            Console.WriteLine("Forwards");
            finchRobot.wait(1000);
            finchRobot.setMotors(-100, -100);
            Console.WriteLine("Backwards");
            finchRobot.wait(1000);
            finchRobot.setMotors(155, 50);
            Console.WriteLine("Right");
            finchRobot.wait(1000);
            finchRobot.setMotors(50, 155);
            Console.WriteLine("Left");
            finchRobot.wait(1000);
            finchRobot.setMotors(-155, -50);
            Console.WriteLine("Reverse Right");
            finchRobot.wait(1000);
            finchRobot.setMotors(-50, -155);
            Console.WriteLine("Reverse Left");
            finchRobot.wait(1000);
            finchRobot.setMotors(50, 155);
            Console.WriteLine("180!");
            finchRobot.wait(2500);
            Console.WriteLine("360!");
            finchRobot.wait(2500);
            finchRobot.setMotors(0, 0);

            Console.WriteLine("Wow! The Finch can really move huh!");
            DisplayMenuPrompt("Talent Show Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Mixing It Up                *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayMixingItUp(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Mixing It Up");

            Console.WriteLine("\tEnjoy a short dance and song from the end of Kirbys Dream Land!");
            Console.WriteLine("\tPlease keep the cord above the robot so it doesn't tangle itself!");
            DisplayContinuePrompt();

            finchRobot.noteOn((int)698.46);
            finchRobot.setMotors(100, 100);
            finchRobot.setLED(50, 168, 82);
            finchRobot.wait(200);
            finchRobot.noteOn((int)783.99);
            finchRobot.setLED(86, 99, 45);
            finchRobot.wait(200);
            finchRobot.noteOn((int)880);
            finchRobot.setLED(88, 194, 242);
            finchRobot.wait(200);
            finchRobot.noteOn((int)987.77);
            finchRobot.setLED(61, 164, 22);
            finchRobot.wait(200);
            finchRobot.noteOn((int)880);
            finchRobot.setLED(45, 38, 194);
            finchRobot.wait(200);
            finchRobot.noteOn((int)987.77);
            finchRobot.setLED(93, 157, 45);
            finchRobot.wait(200);
            finchRobot.noteOn((int)1046.50);
            finchRobot.setMotors(-255, -255);
            finchRobot.setLED(245, 159, 226);
            finchRobot.wait(425);
            finchRobot.noteOn((int)783.99);
            finchRobot.setMotors(50, 155);
            finchRobot.setLED(235, 232, 226);
            finchRobot.wait(425);

            finchRobot.noteOn((int)698.46);
            finchRobot.setMotors(100, 100);
            finchRobot.setLED(200, 119, 119);
            finchRobot.wait(200);
            finchRobot.noteOn((int)783.99);
            finchRobot.setLED(110, 129, 16);
            finchRobot.wait(200);
            finchRobot.noteOn((int)880);
            finchRobot.setLED(92, 72, 73);
            finchRobot.wait(200);
            finchRobot.noteOn((int)987.77);
            finchRobot.setLED(14, 221, 31);
            finchRobot.wait(200);
            finchRobot.noteOn((int)880);
            finchRobot.setLED(96, 121, 64);
            finchRobot.wait(200);
            finchRobot.noteOn((int)987.77);
            finchRobot.setLED(254, 175, 107);
            finchRobot.wait(200);
            finchRobot.noteOn((int)1046.50);
            finchRobot.setLED(216, 141, 127);
            finchRobot.setMotors(-255, -255);
            finchRobot.wait(425);
            finchRobot.noteOn((int)523.25);
            finchRobot.setMotors(155, 50);
            finchRobot.setLED(186, 98, 221);
            finchRobot.wait(425);
            finchRobot.noteOff();

            finchRobot.noteOn((int)698.46);
            finchRobot.setMotors(100, 100);
            finchRobot.setLED(208, 72, 190);
            finchRobot.wait(200);
            finchRobot.noteOn((int)783.99);
            finchRobot.setLED(115, 73, 68);
            finchRobot.wait(200);
            finchRobot.noteOn((int)880);
            finchRobot.wait(200);
            finchRobot.noteOn((int)987.77);
            finchRobot.setLED(102, 238, 1);
            finchRobot.wait(200);
            finchRobot.noteOn((int)880);
            finchRobot.wait(200);
            finchRobot.noteOn((int)987.77);
            finchRobot.setLED(82, 44, 165);
            finchRobot.wait(200);
            finchRobot.noteOn((int)1046.50);
            finchRobot.setLED(71, 246, 113);
            finchRobot.wait(425);
            finchRobot.noteOn((int)783.99);
            finchRobot.setLED(197, 196, 63);
            finchRobot.wait(200);
            finchRobot.noteOn((int)659.26);
            finchRobot.setLED(40, 139, 39);
            finchRobot.wait(425);
            finchRobot.noteOn((int)1567.98);
            finchRobot.setMotors(155, 50);
            finchRobot.setLED(85, 75, 240);
            finchRobot.wait(200);
            finchRobot.noteOn((int)1396.91);
            finchRobot.setLED(27, 38, 23);
            finchRobot.wait(425);
            finchRobot.noteOn((int)1318.51);
            finchRobot.setLED(252, 135, 68);
            finchRobot.wait(200);
            finchRobot.noteOn((int)1174.66);
            finchRobot.setLED(47, 132, 255);
            finchRobot.wait(425);
            finchRobot.noteOn((int)1318.51);
            finchRobot.setLED(11, 246, 252);
            finchRobot.wait(200);
            finchRobot.noteOn((int)1046.50);
            finchRobot.setLED(171, 159, 21);
            finchRobot.wait(425);
            finchRobot.noteOn((int)2093);
            finchRobot.setMotors(50, 155);
            finchRobot.setLED(230, 119, 157);
            finchRobot.wait(300);
            finchRobot.noteOff();
            finchRobot.setLED(0, 0, 0);
            finchRobot.setMotors(0, 0);

            DisplayMenuPrompt("Talent Show Menu");
        }

        #endregion

        #region DATA RECORDER
        
        /// <summary>
        /// *****************************************************************
        /// *                     Data Recorder                          *
        /// *****************************************************************
        /// </summary>
        static void DataRecorderDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine("\t Data Reccorder");
            Console.WriteLine();
            Console.WriteLine("This module is still in devolpment. Please wait for future devolpments!");
            DisplayContinuePrompt();
        }
        #endregion

        #region ALARM SYSTEM

        /// <summary>
        /// *****************************************************************
        /// *                     Alarm System                          *
        /// *****************************************************************
        /// </summary>
        static void AlarmSystemDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine("\t Alarm System");
            Console.WriteLine();
            Console.WriteLine("This module is still in devolpment. Please wait for future devolpments!");
            DisplayContinuePrompt();
        }
        #endregion

        #region USER PROGRAMMING

        /// <summary>
        /// *****************************************************************
        /// *                     User Programming                          *
        /// *****************************************************************
        /// </summary>
        static void UserProgrammingDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine("\t User Programming");
            Console.WriteLine();
            Console.WriteLine("This module is still in devolpment. Please wait for future devolpments!");
            DisplayContinuePrompt();
        }
        #endregion

        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            DisplayContinuePrompt();

            finchRobot.noteOn(1047);
            finchRobot.setLED(0, 0, 255);
            finchRobot.wait(100);
            finchRobot.noteOn(988);
            finchRobot.setLED(0, 255, 0);
            finchRobot.wait(100);
            finchRobot.noteOn(880);
            finchRobot.setLED(255, 0, 0);
            finchRobot.wait(100);
            finchRobot.noteOff();
            finchRobot.setLED(0, 0, 0);
            finchRobot.disConnect();


            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please ensure the USB cable is connected to the robot and computer now.");
            DisplayContinuePrompt();

            // TODO test connection and provide user feedback - text, lights, sounds
            // NOTE: I had no idea how to check to see if the Finch is connected via a while loop so I hope a if-else statement will do.
            robotConnected = finchRobot.connect();
            if (robotConnected)
            {
                finchRobot.noteOn(880);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(100);
                finchRobot.noteOn(988);
                finchRobot.setLED(0, 255, 0);
                finchRobot.wait(100);
                finchRobot.noteOn(1047);
                finchRobot.setLED(0, 0, 255);
                finchRobot.wait(100);
                finchRobot.noteOff();
                finchRobot.setLED(0, 0, 0);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("\tUnable to connect to Finch robot, please check your USB connections and restart the program to try connecting again.");
            }

            Console.WriteLine("The Finch is now connected and ready for use!");
            DisplayMenuPrompt("Main Menu");

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();
            Console.WriteLine("This program is designed to show off the capabilities of the Finch robot.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tThank you for using Finch Control!");
            Console.WriteLine();
            Console.WriteLine("\tHave a nice day!");
            Console.WriteLine();
            Console.WriteLine("\tThis program has been developed by FoxFox productions.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
