using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Finch Control - Talent Show
    // Description: Completed Finch Project, Includes Custom Themes, User Programming, Movement, Sound and Lights, Tempature readings and light sensor readings.
    // Application Type: Console
    // Author: Taber, Jake
    // Dated Created: 2/17/2021
    // Last Modified: 3/28/2021
    //
    // **************************************************

    /// <summary>
    /// Available commands for users to program with
    /// </summary>

    public enum Command
    {
        NONE,
        MOVEFORWARD,
        MOVEBACKWARD,
        STOPMOTORS,
        WAIT,
        TURNRIGHT,
        TURNLEFT,
        LEDON,
        LEDOFF,
        GETTEMPERATURE,
        DONE
    }


    class Program
    {
        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetDefualtTheme();
            DisplayWelcomeScreen();
            DisplayConsoleColors();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetDefualtTheme()
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
                Console.WriteLine("\td) Light Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Change Console Colors");
                Console.WriteLine("\tg) Disconnect Finch Robot");
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
                        LightAlarmDisplayMenuScreen(finchRobot);
                        break;

                    case "e":
                        UserProgrammingDisplayMenuScreen(finchRobot);
                        break;

                    case "f":
                        DisplayConsoleColors();
                        break;

                    case "g":
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
            Console.CursorVisible = true;

            int numberOfDataPoints = 0;
            double dataPointFrequency = 0;
            double[] temperatures = null;

            bool quitDataRecorderMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Number of Data Points");
                Console.WriteLine("\tb) Frequency of Data Points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        numberOfDataPoints = DataRecorderDisplayGetNumberOfDataPoints(finchRobot);
                        break;

                    case "b":
                        dataPointFrequency = DataRecorderDisplayGetNumberOfDataPointsFrequency(finchRobot);
                        break;

                    case "c":
                        temperatures = DataRecorderDisplayGetData(numberOfDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "d":
                        DataRecorderDisplayGetData(temperatures);
                        break;

                    case "q":
                        quitDataRecorderMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitDataRecorderMenu);
        }
        
        ///Show data in table format
        private static void DataRecorderDisplayGetData(double[] temperatures)
        {
            DisplayScreenHeader("Show Data");

            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt(); 
        }

        ///Create table and refactor it for future use
        static void DataRecorderDisplayTable(double[] temperatures)
        {
            Console.WriteLine(
            "Recording #".PadLeft(15) +
             "Temp".PadLeft(15)
             );
            Console.WriteLine(
                "...........".PadLeft(15) +
                "...........".PadLeft(15)
                );

            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                  (index + 1).ToString().PadLeft(15) +
                  temperatures[index].ToString("n2").PadLeft(15)
                  );

            }
        }

        /// <summary>
        /// Get Data From Finch
        /// </summary>
        /// <param name="numberOfDataPoints"></param>
        /// <param name="dataPointFrequency"></param>
        /// <param name="finchRobot"></param>
        /// <returns></returns>
        static double[] DataRecorderDisplayGetData(int numberOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] tempatures = new double[numberOfDataPoints];
            string userResponse;
            
            DisplayScreenHeader("Get Data");

            Console.WriteLine($"Number of Data Points: {numberOfDataPoints}");
            Console.WriteLine($"Data point frequency: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine("The finch robot is ready to begin recording the data!");
            DisplayContinuePrompt();

            for (int index = 0; index < numberOfDataPoints; index++)
            {
                tempatures[index] = finchRobot.getTemperature();
                Console.WriteLine($"\tReading {index + 1}: {tempatures[index].ToString("n2")}");
                int waitInSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.noteOn(1047);
                finchRobot.wait(waitInSeconds);
                finchRobot.noteOff();

            }

            ///Ask the user if they want to see the table or not
            Console.WriteLine();
            Console.WriteLine("Would you like to display the data chart now?");
            Console.CursorVisible = true;
            userResponse = Console.ReadLine();
            Console.CursorVisible = false;

            
            if (userResponse == "yes")
                DataRecorderDisplayTable(tempatures);
            else
                Console.WriteLine("No worries. If you want to view the table, choose Show Data on the Data Recorder Menu");

            DisplayContinuePrompt();

            return tempatures;
        }

        /// <summary>
        /// Data Point Frequency
        /// </summary>
        /// <param name="finchRobot"></param>
        /// <returns></returns>
        static double DataRecorderDisplayGetNumberOfDataPointsFrequency(Finch finchRobot)
        {
            double dataPointFrequency;
            string userResponse;
            bool validResponse;
            do
            {
                DisplayScreenHeader("Data Point Frequency");

                Console.Write("What's the frequency that you would like proccessed?:");
                Console.CursorVisible = true;
                userResponse = Console.ReadLine();

                if (!double.TryParse(userResponse, out dataPointFrequency))
                {
                    validResponse = false;

                    Console.WriteLine();
                    Console.WriteLine("Please enter an interger value");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The data point frequency will be " + dataPointFrequency);                    
                }
                DisplayContinuePrompt();
                Console.CursorVisible = false;

                return dataPointFrequency;
            } while (!validResponse);
        }
        /// <summary>
        /// Number of Data Points
        /// </summary>
        /// <param name="finchRobot"></param>
        /// <returns></returns>
        static int DataRecorderDisplayGetNumberOfDataPoints(Finch finchRobot)
        {
            int numberOfDataPoints;
            string userResponse;
            bool validResponse;
            do
            {
                DisplayScreenHeader("Number of Data Points");

                Console.Write("How many data points would you like to process?:");
                Console.CursorVisible = true;
                userResponse = Console.ReadLine();

                if(!int.TryParse(userResponse, out numberOfDataPoints))
                {
                    validResponse = false;
                    
                    Console.WriteLine();
                    Console.WriteLine("Please enter an interger value");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The data point value will be " + numberOfDataPoints);
                }

                DisplayContinuePrompt();
                Console.CursorVisible = false;
                return numberOfDataPoints;
                
            } while (!validResponse);
        }
        #endregion

        #region ALARM SYSTEM

        /// <summary>
        /// *****************************************************************
        /// *                    Light Alarm System                          *
        /// *****************************************************************
        /// </summary>
        static void LightAlarmDisplayMenuScreen(Finch finchRobot)
        {
                Console.CursorVisible = true;


                bool quitMenu = false;
                string menuChoice;

                string sensorsToMonitor = "";
                string rangeType = "";
                int minMaxThresholdValue = 0;
                int timeToMonitor = 0;

                do
                {
                    DisplayScreenHeader("Light Alarm Menu");

                    //
                    // get user menu choice
                    //
                    Console.WriteLine("\ta) Set Sensors to Monitor");
                    Console.WriteLine("\tb) Set Range Type");
                    Console.WriteLine("\tc) Set Min/Max Threshold");
                    Console.WriteLine("\td) Set Time to Monitor");
                    Console.WriteLine("\te) Set Alarm");
                    Console.WriteLine("\tq) Main Menu");
                    Console.Write("\t\tEnter Choice:");
                    menuChoice = Console.ReadLine().ToLower();

                    //
                    // process user menu choice
                    //
                    switch (menuChoice)
                    {
                        case "a":
                            sensorsToMonitor = LightAlarmDisplaySetSensorsToMonitor();
                            break;

                        case "b":
                            rangeType = LightAlarmDisplaySetRangeType();
                            break;

                        case "c":
                            minMaxThresholdValue = LightAlarmSetMinMaxThresholdValue(rangeType, finchRobot);
                            break;

                        case "d":
                            timeToMonitor = LightAlarmSetTimeToMonitor();
                            break;

                        case "e":
                            LightAlarmSetAlarm(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                            break;

                    case "q":
                            quitMenu = true;
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("\tPlease enter a letter for the menu choice.");
                            DisplayContinuePrompt();
                            break;
                    }

                } while (!quitMenu);
        }

        static string LightAlarmDisplaySetSensorsToMonitor()
        {
            string sensorsToMonitor;
            bool validResponse;
            do
            {
            DisplayScreenHeader("Sensors to Monitor");

            /// validate value
            Console.Write("\tPlease choose the sensor you would like to receive light information from. [left, right, both]:");
            sensorsToMonitor = Console.ReadLine();
                if (sensorsToMonitor == "left")
                {
                    /// echo user responce
                    Console.WriteLine();
                    Console.WriteLine("\tSensors that will be monitored will be " + sensorsToMonitor);
                    Console.WriteLine();
                }
                else if (sensorsToMonitor == "right")
                {
                    /// echo user responce
                    Console.WriteLine();
                    Console.WriteLine("\tSensors that will be monitored will be " + sensorsToMonitor);
                    Console.WriteLine();
                }
                else if (sensorsToMonitor == "both")
                {
                    /// echo user responce
                    Console.WriteLine();
                    Console.WriteLine("\tSensors that will be monitored will be " + sensorsToMonitor);
                    Console.WriteLine();
                }
                else
                {
                    /// tell user to input correct values
                    Console.WriteLine();
                    Console.WriteLine("\tPlease enter either left, right or both when prompted");
                    Console.WriteLine();
                }
                Console.CursorVisible = false;
                DisplayMenuPrompt("Light Alarm");

            return sensorsToMonitor;
            } while (!validResponse);
        }

        static string LightAlarmDisplaySetRangeType()
        {
            string rangeType;
            bool validResponse;
            do
            {
            DisplayScreenHeader("Range Type");

            /// validate value
            Console.CursorVisible = true;
            Console.Write("\tPlease choose if you want the threshold to be [minimum] or [maximum]:");
            rangeType = Console.ReadLine();

            if (rangeType == "minimum")
            {
                /// echo value
                Console.WriteLine();
                Console.WriteLine("\tRange Type has been set to " + rangeType);
                Console.WriteLine();
            }
            else if (rangeType == "maximum")
            {
                /// echo value
                Console.WriteLine();
                Console.WriteLine("\tRange Type has been set to " + rangeType);
                Console.WriteLine();
            }
            else
            {
                /// tell user to input correct values
                Console.WriteLine();
                Console.WriteLine("\tPlease enter either minimum or maximum when prompted");
                Console.WriteLine();
            }
                Console.CursorVisible = false;
                DisplayMenuPrompt("Light Alarm");
                return rangeType;
            } while (!validResponse);
        }

        static int LightAlarmSetMinMaxThresholdValue(string rangeType, Finch finchRobot)
        {
            int minMaxThresholdValue;
            bool validResponse;
            do
            {
                DisplayScreenHeader("Min/Max Threshold Value");

                Console.WriteLine($"\tLeft light sensor ambient value: {finchRobot.getLeftLightSensor()}");
                Console.WriteLine($"\tRight light sensor ambient value: {finchRobot.getRightLightSensor()}");
                Console.WriteLine();

                /// validate value
                Console.CursorVisible = true;
                Console.Write($"\tEnter the {rangeType} light sensor value:");
                if (!int.TryParse(Console.ReadLine(), out minMaxThresholdValue))
                {
                    validResponse = false;
                    /// tell user to input correct values
                    Console.WriteLine();
                    Console.WriteLine("Please enter a numercal value");
                    Console.CursorVisible = false;
                    DisplayContinuePrompt();
                }
                else
                {
                    /// echo value
                    Console.WriteLine();
                    Console.WriteLine("\tThreshold value has been set to " + minMaxThresholdValue);
                    Console.WriteLine();
                    Console.CursorVisible = false;
                    DisplayMenuPrompt("Light Alarm");
                }

                return minMaxThresholdValue;
            } while (!validResponse);
            
            
        }

        static int LightAlarmSetTimeToMonitor()
        {
            int timeToMonitor;
            bool validResponse;
            do
            {
                DisplayScreenHeader("Time to Monitor");

                /// validate value
                Console.CursorVisible = true;
                Console.Write($"\tPlease enter how long you would like the sensors to monter for:");
                if (!int.TryParse(Console.ReadLine(), out timeToMonitor))
                {
                    validResponse = false;
                    /// tell user to input correct values
                    Console.WriteLine();
                    Console.WriteLine("Please enter a numercal value");
                    Console.CursorVisible = false;
                    DisplayContinuePrompt();
                }
                else
                {
                    /// echo value
                    Console.WriteLine();
                    Console.WriteLine("\tThe monitor value has been set to " + timeToMonitor + " seconds");
                    Console.WriteLine();
                    Console.CursorVisible = false;
                    DisplayMenuPrompt("Light Alarm");
                }

                return timeToMonitor;
            } while (!validResponse);
        }

        static void LightAlarmSetAlarm(Finch finchRobot, string sensorsToMonitor, string rangeType, int minMaxThresholdValue, int timeToMonitor)
        {
            int secondsPassed = 0;
            bool thresholdPassed = false;
            int currentLightSensorValue = 0;
            
            DisplayScreenHeader("Set Alarm");

            Console.WriteLine($"Sensors to monitor {sensorsToMonitor}");
            Console.WriteLine("Range Type: {0}", rangeType);
            Console.WriteLine("Min/Max Threshold Value: " + minMaxThresholdValue);
            Console.WriteLine($"Time to Monitor : {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("Press any key to begin monitoring.");
            Console.ReadKey();
            Console.WriteLine();

            while((secondsPassed < timeToMonitor) && !thresholdPassed)
            {
                switch (sensorsToMonitor)
                {
                    case "left":
                        currentLightSensorValue = finchRobot.getLeftLightSensor();
                        Console.WriteLine(currentLightSensorValue);
                        break;

                    case "right":
                        currentLightSensorValue = finchRobot.getRightLightSensor();
                        Console.WriteLine(currentLightSensorValue);
                        break;

                    case "both":
                        currentLightSensorValue = (finchRobot.getRightLightSensor() + finchRobot.getRightLightSensor()) /2;
                        Console.WriteLine(currentLightSensorValue);
                        break;
                }

                switch (rangeType)
                {
                    case "minimum":
                        if (currentLightSensorValue < minMaxThresholdValue)
                        {
                            thresholdPassed = true;
                        }
                        break;

                    case "maximum":
                        if (currentLightSensorValue > minMaxThresholdValue)
                        {
                            thresholdPassed = true;
                        }
                        break;
                }

                finchRobot.wait(1000);
                secondsPassed++;
            }

            if (thresholdPassed)
            {
                finchRobot.noteOn(880);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();
                finchRobot.noteOn(880);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();
                Console.WriteLine($"The {rangeType} threshold value of {minMaxThresholdValue} was exceeded by the current light sensor value of {currentLightSensorValue}.");
            }
            else
            {
                finchRobot.noteOn(1047);
                finchRobot.setLED(0, 255, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();
                finchRobot.noteOn(1047);
                finchRobot.setLED(0, 255, 0);
                finchRobot.wait(500);
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();
                Console.WriteLine($"The {rangeType} threshold value of {minMaxThresholdValue} was not exceeded.");
            }

            DisplayMenuPrompt("Light Alarm");
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
            string menuChoice;
            bool quitMenu = false;

            ///
            /// store command parameters for user input
            /// 
            (int motorSpeed, int ledBrightness, double waitSeconds) commandParameters;
            commandParameters.motorSpeed = 0;
            commandParameters.ledBrightness = 0;
            commandParameters.waitSeconds = 0;

            List<Command> commands = new List<Command>();

            do
            {
                DisplayScreenHeader("User Programming Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Set command Parameters");
                Console.WriteLine("\tb) Add Commands");
                Console.WriteLine("\tc) View Commands");
                Console.WriteLine("\td) Execute Commands");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        commandParameters = UserProgrammingDisplayGetCommandParameters();
                        break;

                    case "b":
                        UserProgrammingDisplayGetFinchCommands(commands);
                        break;

                    case "c":
                        UserProgrammingDisplayFinchCommands(commands);
                        break;

                    case "d":
                        UserProgrammingDisplayExecuteFinchCommands(finchRobot, commands, commandParameters);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitMenu);
        }

        /// <summary>
        /// Exectue User Inputted Code
        /// </summary>
        /// <param name="finchRobot"></param>
        /// <param name="commands"></param>
        /// <param name="commandParameters"></param>
        private static void UserProgrammingDisplayExecuteFinchCommands(Finch finchRobot, List<Command> commands, (int motorSpeed, int ledBrightness, double waitSeconds) commandParameters)
        {
            int motorSpeed = commandParameters.motorSpeed;
            int ledBrightness = commandParameters.ledBrightness;
            int waitMilliSeconds = (int)(commandParameters.waitSeconds * 1000);
            string commandFeedback = "";
            const int TURNING_MOTOR_SPEED = 100;

            DisplayScreenHeader("Execute Finch Commands");

            Console.WriteLine("\tThe Finch robot will now execute the list of commands you told it to do!");
            DisplayContinuePrompt();

            /// this will run through every command, look at the parameters the user inputted and run them. If the user didn't input a command, it will skip over it.

            foreach (Command command in commands)
            {
                switch (command)
                {
                    case Command.NONE:
                        break;

                    case Command.MOVEFORWARD:
                        finchRobot.setMotors(motorSpeed, motorSpeed);
                        commandFeedback = Command.MOVEFORWARD.ToString();
                        ;break;

                    case Command.MOVEBACKWARD:
                        finchRobot.setMotors(-motorSpeed, -motorSpeed);
                        commandFeedback = Command.MOVEBACKWARD.ToString();
                        ; break;

                    case Command.STOPMOTORS:
                        finchRobot.setMotors(0, 0);
                        commandFeedback = Command.STOPMOTORS.ToString();
                        ; break;

                    case Command.WAIT:
                        finchRobot.wait(waitMilliSeconds);
                        commandFeedback = Command.WAIT.ToString();
                        ; break;

                    case Command.TURNRIGHT:
                        finchRobot.setMotors(TURNING_MOTOR_SPEED, -TURNING_MOTOR_SPEED);
                        commandFeedback = Command.TURNRIGHT.ToString();
                        ; break;

                    case Command.TURNLEFT:
                        finchRobot.setMotors(-TURNING_MOTOR_SPEED, TURNING_MOTOR_SPEED);
                        commandFeedback = Command.TURNLEFT.ToString();
                        ; break;

                    case Command.LEDON:
                        finchRobot.setLED(ledBrightness, ledBrightness, ledBrightness);
                        commandFeedback = Command.LEDON.ToString();
                        ; break;

                    case Command.LEDOFF:
                        finchRobot.setLED(0, 0, 0);
                        commandFeedback = Command.LEDOFF.ToString();
                        ; break;

                    case Command.DONE:
                        commandFeedback = Command.DONE.ToString();
                        ; break;

                    default:

                        break;
                }

                Console.WriteLine($"\t{commandFeedback}");
            }

            DisplayMenuPrompt("User Programming");
        }

        /// <summary>
        /// Display commands
        /// </summary>
        /// <param name="commands"></param>

        ///displays the users inputted commands
        static void UserProgrammingDisplayFinchCommands(List<Command> commands)
        {
            DisplayScreenHeader("Finch Robot Commands");

            foreach (Command command in commands)
            {
                Console.WriteLine($"\t{command}");
            }

            DisplayMenuPrompt("User Programming");
        }

        /// <summary>
        /// Get Commands From user
        /// </summary>
        /// <param name="commands"></param>

        static void UserProgrammingDisplayGetFinchCommands(List<Command> commands)
        {
            Command command = Command.NONE;

            DisplayScreenHeader("Finch Robot Commands");

            ///
            /// list commands in a table format
            /// 
            int commandCount = 1;
            Console.WriteLine("\tList of Avaible Commands");
            Console.WriteLine();
            Console.CursorVisible = true;
            Console.Write("\t-");
            foreach (string commandName in Enum.GetNames(typeof(Command)))
            {
                Console.Write($"- {commandName.ToLower()}  -");
                if (commandCount % 5 == 0) Console.Write("-\n\t-");
                commandCount++;
            }
            Console.WriteLine();

            ///this will check to see if the commands are listed as an enum, if not it will prompt the user to input a valid command

            while (command != Command.DONE)
            {
                Console.Write("\tEnter Commands:");

                if (Enum.TryParse(Console.ReadLine().ToUpper(), out command))
                {
                    commands.Add(command);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a command from the list above");
                    Console.WriteLine();
                }
            }

            Console.CursorVisible = false;
            DisplayMenuPrompt("User Programming");

        }

        /// <summary>
        /// Get User Data
        /// </summary>
        /// <returns></returns>

        
        ///users will input the value of motor speed, led strengh and wait time. I couldn't get the wait time working under 1 second so the value needs to be larger than 1 second.
        static (int motorSpeed, int ledBrightness, double waitSeconds) UserProgrammingDisplayGetCommandParameters()
        {
            DisplayScreenHeader("Command Parameters");

            bool numValue;
            (int motorSpeed, int ledBrightness, int waitSeconds) commandParameters;
            commandParameters.motorSpeed = 0;
            commandParameters.ledBrightness = 0;
            commandParameters.waitSeconds = 0;

            Console.Write("Please  Enter Motor Speed[1-255]: ");
            Console.CursorVisible = true;

            do
            {
                numValue = int.TryParse(Console.ReadLine(), out commandParameters.motorSpeed);

                if (!numValue)
                {
                    Console.WriteLine();
                    Console.Write("Please enter a valid number: ");
                }
                else if (commandParameters.motorSpeed > 255)
                {
                    commandParameters.motorSpeed = 255;
                }
                else if (commandParameters.motorSpeed <= 0)
                {
                    Console.Write("Enter a Positive Number: ");
                    numValue = false;
                }
            } while (!numValue);

            Console.WriteLine();
            Console.Write("Enter LED Brightness[1-255]: ");

            do
            {
                numValue = int.TryParse(Console.ReadLine(), out commandParameters.ledBrightness);

                if (!numValue)
                {
                    Console.WriteLine();
                    Console.Write("Please enter a valid number: ");
                }
                else if (commandParameters.ledBrightness > 255)
                {
                    commandParameters.ledBrightness = 255;
                }
                else if (commandParameters.ledBrightness <= 0)
                {
                    Console.WriteLine();
                    Console.Write("Enter a Positive Number: ");
                    numValue = false;
                }
            } while (!numValue);

            Console.WriteLine();
            Console.Write("Enter length of wait command in seconds:");

            do
            {
                numValue = int.TryParse(Console.ReadLine(), out commandParameters.waitSeconds);

                if (!numValue)
                {
                    Console.WriteLine();
                    Console.Write("Please enter a valid number:");
                }
                else if (commandParameters.waitSeconds <= 0)
                {
                    Console.WriteLine();
                    Console.Write("Please enter a whole number greater than 0");
                    numValue = false;
                }
            } while (!numValue);

            ///echo the values back to the user
            
            Console.WriteLine();
            Console.WriteLine($"The speed of which the motors will run at will be {commandParameters.motorSpeed}");
            Console.WriteLine($"The LED brighness will be {commandParameters.ledBrightness}");
            Console.WriteLine($"The wait time between commands will be {commandParameters.waitSeconds}");
            Console.CursorVisible = false;
            DisplayContinuePrompt();

            return commandParameters;
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

                Console.WriteLine("\tThe Finch is now connected and ready for use!");
               
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Unable to connect to Finch robot, please check your USB connections and restart the program to try connecting again.");
            }

            DisplayMenuPrompt("Main Menu");
            return robotConnected;
        }

        #endregion

        #region THEME CHANGE
        
        /// <summary>
        /// Theme change
        /// </summary>
        static void DisplayConsoleColors()
        {
            (ConsoleColor foregroundColor, ConsoleColor backgroundColor) themeColors;
            bool themeChosen = false;

            themeColors = ReadThemeData();
            Console.ForegroundColor = themeColors.foregroundColor;
            Console.BackgroundColor = themeColors.backgroundColor;
            DisplayScreenHeader("Set Console Colors");
            Console.WriteLine($"\tCurrent foreground color: {Console.ForegroundColor}");
            Console.WriteLine($"\tCurrent foreground color: {Console.BackgroundColor}");
            Console.CursorVisible = true;
            Console.WriteLine();

            Console.Write("\tWould you like to change the current theme [ yes | no ]?");
            if (Console.ReadLine().ToLower() == "yes")
            {
                do
                {
                    themeColors.foregroundColor = GetConsoleColorFromUser("foreground");
                    themeColors.backgroundColor = GetConsoleColorFromUser("background");

                    //
                    // set new theme
                    //
                    Console.ForegroundColor = themeColors.foregroundColor;
                    Console.BackgroundColor = themeColors.backgroundColor;
                    Console.Clear();
                    DisplayScreenHeader("Set Console Colors");
                    Console.WriteLine($"\tNew foreground color: {Console.ForegroundColor}");
                    Console.WriteLine($"\tNew foreground color: {Console.BackgroundColor}");

                    Console.WriteLine();
                    Console.Write("\tWould you like to use this theme?");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        themeChosen = true;
                        WriteThemeData(themeColors.foregroundColor, themeColors.backgroundColor);
                    }
                } while (!themeChosen);
            }
            DisplayContinuePrompt();
        }

        /// <summary>
        /// Get colors from user
        /// </summary>
        static ConsoleColor GetConsoleColorFromUser(string property)
        {
            ConsoleColor consoleColor;
            bool validConsoleColor;

            do
            {
                Console.Write($"\tEnter a vaule for the {property}:");
                validConsoleColor = Enum.TryParse<ConsoleColor>(Console.ReadLine(), true, out consoleColor);

                if (!validConsoleColor)
                {
                    Console.WriteLine("\n\t Please enter a valid console color\n");
                }
                else
                {
                    validConsoleColor = true;
                }
            } while (!validConsoleColor);

            return consoleColor;
        }

        /// <summary>
        /// Read data from file
        /// </summary>
        static (ConsoleColor foregroundColor, ConsoleColor backgroundColor) ReadThemeData()
        {
            string dataPath = @"Data/Theme.txt";
            string[] themeColors;

            ConsoleColor foregroundColor;
            ConsoleColor backgroundColor;

            themeColors = File.ReadAllLines(dataPath);

            Enum.TryParse(themeColors[0], true, out foregroundColor);
            Enum.TryParse(themeColors[1], true, out backgroundColor);

            return (foregroundColor, backgroundColor);

        }
        /// <summary>
        /// Write data from file
        /// </summary>
        static void WriteThemeData(ConsoleColor foreground, ConsoleColor background)
        {
            string dataPath = @"Data/Theme.txt";

            File.WriteAllText(dataPath, foreground.ToString() + "\n");
            File.AppendAllText(dataPath, background.ToString());

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
