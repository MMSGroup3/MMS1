using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMS1Project
{
    public class Calculation
    {
        public static double[,] vendorArray = new double[10, 10]{
            {0, 0, 1, 0, 1, 0, 0, 0, 1, 0},
            {1, 0, 1, 0, 0, 0, 1, 0, 1, 0},
            {0, 0, 0, 0, 1, 0, 0, 0, 1, 0},
            {1, 0, 0, 0, 0, 1, 0, 0, 0, 1},
            {0, 0, 0, 0, 0, 0, 1, 0, 0, 1},
            {0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
            {1, 1, 1, 0, 0, 1, 0, 1, 0, 1},
            {0, 0, 0, 1, 1, 1, 1, 0, 0 ,0},
            {0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 1, 1, 1, 0, 0, 0, 1, 0}};

        public static double dampingFactor = 0.85;
        public static double vendor1Score = 1;
        public static double vendor2Score = 1;
        public static double vendor3Score = 1;
        public static double vendor4Score = 1;
        public static double vendor5Score = 1;
        public static double vendor6Score = 1;
        public static double vendor7Score = 1;
        public static double vendor8Score = 1;
        public static double vendor9Score = 1;
        public static double vendor10Score = 1;
        public static double score1Total = 0;
        public static double score2Total = 0;
        public static double score3Total = 0;
        public static double score4Total = 0;
        public static double score5Total = 0;
        public static double score6Total = 0;
        public static double score7Total = 0;
        public static double score8Total = 0;
        public static double score9Total = 0;
        public static double score10Total = 0;
        public static double vendor1Out = 0;
        public static double vendor2Out = 0;
        public static double vendor3Out = 0;
        public static double vendor4Out = 0;
        public static double vendor5Out = 0;
        public static double vendor6Out = 0;
        public static double vendor7Out = 0;
        public static double vendor8Out = 0;
        public static double vendor9Out = 0;
        public static double vendor10Out = 0;
        public static double webpageTotal = 0;

        public static Boolean id1 = false;
        public static Boolean id2 = false;
        public static Boolean id3 = false;
        public static Boolean id4 = false;
        public static Boolean id5 = false;
        public static Boolean id6 = false;
        public static Boolean id7 = false;
        public static Boolean id8 = false;
        public static Boolean id9 = false;
        public static Boolean id10 = false;

        //static void Main(string[] args)
        //{
        //    Dictionary<string, string> setUpList = new Dictionary<string, string>();
        //    setUpList.Add("1", "1");
        //    setUpList.Add("3", "3");
        //    setUpList.Add("4", "4");
        //    setUpList.Add("6", "6");
        //    setUpList.Add("7", "7");
        //    setUpList.Add("8", "8");
        //    setUpList.Add("9", "9");
        //    setUpList.Add("10", "10");

        //    Dictionary<string, double> outputDictionary = CalculateScores(setUpList);

        //    foreach (KeyValuePair<string, double> item in outputDictionary)
        //    {
        //        Console.WriteLine("Vendor {0} has score {1}!", item.Key, item.Value.ToString());
        //    }

        //    Console.ReadLine();
        //}

        public static Dictionary<string, double> CalculateScores(Dictionary<string, string> vendorInformation)
        {
            foreach (KeyValuePair<string, string> item in vendorInformation)
            {
                if (item.Key.Equals("1"))
                {
                    id1 = true;
                }
                else if (item.Key.Equals("2"))
                {
                    id2 = true;
                }
                else if (item.Key.Equals("3"))
                {
                    id3 = true;
                }
                else if (item.Key.Equals("4"))
                {
                    id4 = true;
                }
                else if (item.Key.Equals("5"))
                {
                    id5 = true;
                }
                else if (item.Key.Equals("6"))
                {
                    id6 = true;
                }
                else if (item.Key.Equals("7"))
                {
                    id7 = true;
                }
                else if (item.Key.Equals("8"))
                {
                    id8 = true;
                }
                else if (item.Key.Equals("9"))
                {
                    id9 = true;
                }
                else if (item.Key.Equals("10"))
                {
                    id10 = true;
                }
            }
            // Run the calculation
            RunCalculation();
            // Create the dictionary to return with all the scores.
            Dictionary<string, double> tempOutput = new Dictionary<string, double>();
            if (id1)
            {
                tempOutput.Add("1", score1Total);
            }
            if (id2)
            {
                tempOutput.Add("2", score2Total);
            }
            if (id3)
            {
                tempOutput.Add("3", score3Total);
            }
            if (id4)
            {
                tempOutput.Add("4", score4Total);
            }
            if (id5)
            {
                tempOutput.Add("5", score5Total);
            }
            if (id6)
            {
                tempOutput.Add("6", score6Total);
            }
            if (id7)
            {
                tempOutput.Add("7", score7Total);
            }
            if (id8)
            {
                tempOutput.Add("8", score8Total);
            }
            if (id9)
            {
                tempOutput.Add("9", score9Total);
            }
            if (id10)
            {
                tempOutput.Add("10", score10Total);
            }

            return tempOutput;
        }

        private static void RunCalculation()
        {
            //retrieve booleans

            if (id1 == true)
            {
                webpageTotal = webpageTotal + 1;

                if (id2 == true)
                {
                    //Value for connection from link 1 to link 2
                    vendor1Out = vendor1Out + vendorArray[1, 0];
                    //Value for connection from link 2 to link 1
                    vendor2Out = vendor2Out + vendorArray[0, 1];
                }

                if (id3 == true)
                {
                    //Value for connection from link 1 to link 3
                    vendor1Out = vendor1Out + vendorArray[2, 0];
                    //Value for connection from link 3 to link 1
                    vendor3Out = vendor3Out + vendorArray[0, 2];
                }

                if (id4 == true)
                {
                    //Value for connection from link 1 to link 4
                    vendor1Out = vendor1Out + vendorArray[3, 0];
                    //Value for connection from link 4 to link 1
                    vendor4Out = vendor4Out + vendorArray[0, 3];
                }

                if (id5 == true)
                {
                    //Value for connection from link 1 to link 5
                    vendor1Out = vendor1Out + vendorArray[4, 0];
                    //Value for connection from link 5 to link 1
                    vendor5Out = vendor5Out + vendorArray[0, 4];
                }

                if (id6 == true)
                {
                    //Value for connection from link 1 to link 6
                    vendor1Out = vendor1Out + vendorArray[5, 0];
                    //Value for connection from link 6 to link 1
                    vendor6Out = vendor6Out + vendorArray[0, 5];
                }

                if (id7 == true)
                {
                    //Value for connection from link 1 to link 7
                    vendor1Out = vendor1Out + vendorArray[6, 0];
                    //Value for connection from link 7 to link 1
                    vendor7Out = vendor7Out + vendorArray[0, 6];
                }

                if (id8 == true)
                {
                    //Value for connection from link 1 to link 8
                    vendor1Out = vendor1Out + vendorArray[7, 0];
                    //Value for connection from link 8 to link 1
                    vendor8Out = vendor8Out + vendorArray[0, 7];
                }

                if (id9 == true)
                {
                    //Value for connection from link 1 to link 9
                    vendor1Out = vendor1Out + vendorArray[8, 0];
                    //Value for connection from link 9 to link 1
                    vendor9Out = vendor9Out + vendorArray[0, 8];
                }

                if (id10 == true)
                {
                    //Value for connection from link 1 to link 10
                    vendor1Out = vendor1Out + vendorArray[9, 0];
                    //Value for connection from link 10 to link 1
                    vendor10Out = vendor10Out + vendorArray[0, 9];
                }
            }



            if (id2 == true)
            {
                webpageTotal = webpageTotal + 1;

                if (id3 == true)
                {
                    //Value for connection from link 2 to link 3
                    vendor2Out = vendor2Out + vendorArray[2, 1];
                    //Value for connection from link 3 to link 2
                    vendor3Out = vendor3Out + vendorArray[1, 2];
                }

                if (id4 == true)
                {
                    //Value for connection from link 2 to link 4
                    vendor2Out = vendor2Out + vendorArray[3, 1];
                    //Value for connection from link 4 to link 2
                    vendor4Out = vendor4Out + vendorArray[1, 3];
                }

                if (id5 == true)
                {
                    //Value for connection from link 2 to link 5
                    vendor2Out = vendor2Out + vendorArray[4, 1];
                    //Value for connection from link 5 to link 2
                    vendor5Out = vendor5Out + vendorArray[1, 4];
                }

                if (id6 == true)
                {
                    //Value for connection from link 2 to link 6
                    vendor2Out = vendor2Out + vendorArray[5, 1];
                    //Value for connection from link 6 to link 2
                    vendor6Out = vendor6Out + vendorArray[1, 5];
                }

                if (id7 == true)
                {
                    //Value for connection from link 2 to link 7
                    vendor2Out = vendor2Out + vendorArray[6, 1];
                    //Value for connection from link 7 to link 2
                    vendor7Out = vendor7Out + vendorArray[1, 6];
                }

                if (id8 == true)
                {
                    //Value for connection from link 2 to link 8
                    vendor2Out = vendor2Out + vendorArray[7, 1];
                    //Value for connection from link 8 to link 2
                    vendor8Out = vendor8Out + vendorArray[1, 7];
                }

                if (id9 == true)
                {
                    //Value for connection from link 2 to link 9
                    vendor2Out = vendor2Out + vendorArray[8, 1];
                    //Value for connection from link 9 to link 2
                    vendor9Out = vendor9Out + vendorArray[1, 8];
                }

                if (id10 == true)
                {
                    //Value for connection from link 2 to link 10
                    vendor2Out = vendor2Out + vendorArray[9, 1];
                    //Value for connection from link 10 to link 2
                    vendor10Out = vendor10Out + vendorArray[1, 9];
                }
            }



            if (id3 == true)
            {
                webpageTotal = webpageTotal + 1;

                if (id4 == true)
                {
                    //Value for connection from link 3 to link 4
                    vendor3Out = vendor3Out + vendorArray[3, 2];
                    //Value for connection from link 4 to link 3
                    vendor4Out = vendor4Out + vendorArray[2, 3];
                }

                if (id5 == true)
                {
                    //Value for connection from link 3 to link 5
                    vendor3Out = vendor3Out + vendorArray[4, 2];
                    //Value for connection from link 5 to link 3
                    vendor5Out = vendor5Out + vendorArray[2, 4];
                }

                if (id6 == true)
                {
                    //Value for connection from link 3 to link 6
                    vendor3Out = vendor3Out + vendorArray[5, 2];
                    //Value for connection from link 6 to link 3
                    vendor6Out = vendor6Out + vendorArray[2, 5];
                }

                if (id7 == true)
                {
                    //Value for connection from link 3 to link 7
                    vendor3Out = vendor3Out + vendorArray[6, 2];
                    //Value for connection from link 7 to link 3
                    vendor7Out = vendor7Out + vendorArray[2, 6];
                }

                if (id8 == true)
                {
                    //Value for connection from link 3 to link 8
                    vendor3Out = vendor3Out + vendorArray[7, 2];
                    //Value for connection from link 8 to link 3
                    vendor7Out = vendor7Out + vendorArray[2, 7];
                }

                if (id9 == true)
                {
                    //Value for connection from link 3 to link 9
                    vendor3Out = vendor3Out + vendorArray[8, 2];
                    //Value for connection from link 9 to link 3
                    vendor9Out = vendor9Out + vendorArray[2, 8];
                }

                if (id10 == true)
                {
                    //Value for connection from link 3 to link 10
                    vendor3Out = vendor3Out + vendorArray[9, 2];
                    //Value for connection from link 10 to link 3
                    vendor10Out = vendor10Out + vendorArray[2, 9];
                }
            }



            if (id4 == true)
            {
                webpageTotal = webpageTotal + 1;

                if (id5 == true)
                {
                    //Value for connection from link 4 to link 5
                    vendor4Out = vendor4Out + vendorArray[4, 3];
                    //Value for connection from link 5 to link 4
                    vendor5Out = vendor5Out + vendorArray[3, 4];
                }

                if (id6 == true)
                {
                    //Value for connection from link 4 to link 6
                    vendor4Out = vendor4Out + vendorArray[5, 3];
                    //Value for connection from link 6 to link 4
                    vendor6Out = vendor6Out + vendorArray[3, 5];
                }

                if (id7 == true)
                {
                    //Value for connection from link 4 to link 7
                    vendor4Out = vendor4Out + vendorArray[6, 3];
                    //Value for connection from link 7 to link 4
                    vendor7Out = vendor7Out + vendorArray[3, 6];
                }

                if (id8 == true)
                {
                    //Value for connection from link 4 to link 8
                    vendor4Out = vendor4Out + vendorArray[7, 3];
                    //Value for connection from link 8 to link 4
                    vendor8Out = vendor8Out + vendorArray[3, 7];
                }

                if (id9 == true)
                {
                    //Value for connection from link 4 to link 9
                    vendor4Out = vendor4Out + vendorArray[8, 3];
                    //Value for connection from link 9 to link 4
                    vendor9Out = vendor9Out + vendorArray[3, 8];
                }

                if (id10 == true)
                {
                    //Value for connection from link 4 to link 10
                    vendor4Out = vendor4Out + vendorArray[9, 3];
                    //Value for connection from link 10 to link 4
                    vendor10Out = vendor10Out + vendorArray[3, 9];
                }
            }



            if (id5 == true)
            {
                webpageTotal = webpageTotal + 1;

                if (id6 == true)
                {
                    //Value for connection from link 5 to link 6
                    vendor5Out = vendor5Out + vendorArray[5, 4];
                    //Value for connection from link 6 to link 5
                    vendor6Out = vendor6Out + vendorArray[4, 5];
                }

                if (id7 == true)
                {
                    //Value for connection from link 5 to link 7
                    vendor5Out = vendor5Out + vendorArray[6, 4];
                    //Value for connection from link 7 to link 5
                    vendor7Out = vendor7Out + vendorArray[4, 6];
                }

                if (id8 == true)
                {
                    //Value for connection from link 5 to link 8
                    vendor5Out = vendor5Out + vendorArray[7, 4];
                    //Value for connection from link 8 to link 5
                    vendor8Out = vendor8Out + vendorArray[4, 7];
                }

                if (id9 == true)
                {
                    //Value for connection from link 5 to link 9
                    vendor5Out = vendor5Out + vendorArray[8, 4];
                    //Value for connection from link 9 to link 5
                    vendor9Out = vendor9Out + vendorArray[4, 8];
                }

                if (id10 == true)
                {
                    //Value for connection from link 5 to link 10
                    vendor5Out = vendor5Out + vendorArray[9, 4];
                    //Value for connection from link 10 to link 5
                    vendor10Out = vendor10Out + vendorArray[4, 9];
                }
            }



            if (id6 == true)
            {
                webpageTotal = webpageTotal + 1;

                if (id7 == true)
                {
                    //Value for connection from link 6 to link 7
                    vendor6Out = vendor6Out + vendorArray[6, 5];
                    //Value for connection from link 7 to link 6
                    vendor7Out = vendor7Out + vendorArray[5, 6];
                }

                if (id8 == true)
                {
                    //Value for connection from link 6 to link 8
                    vendor6Out = vendor6Out + vendorArray[7, 5];
                    //Value for connection from link 8 to link 6
                    vendor8Out = vendor8Out + vendorArray[5, 7];
                }

                if (id9 == true)
                {
                    //Value for connection from link 6 to link 9
                    vendor6Out = vendor6Out + vendorArray[8, 5];
                    //Value for connection from link 9 to link 6
                    vendor9Out = vendor9Out + vendorArray[5, 8];
                }

                if (id10 == true)
                {
                    //Value for connection from link 6 to link 10
                    vendor6Out = vendor6Out + vendorArray[9, 5];
                    //Value for connection from link 10 to link 6
                    vendor10Out = vendor10Out + vendorArray[5, 9];
                }
            }



            if (id7 == true)
            {
                webpageTotal = webpageTotal + 1;

                if (id8 == true)
                {
                    //Value for connection from link 7 to link 8
                    vendor7Out = vendor7Out + vendorArray[7, 6];
                    //Value for connection from link 8 to link 7
                    vendor8Out = vendor8Out + vendorArray[6, 7];
                }

                if (id9 == true)
                {
                    //Value for connection from link 7 to link 9
                    vendor7Out = vendor7Out + vendorArray[8, 6];
                    //Value for connection from link 9 to link 7
                    vendor9Out = vendor9Out + vendorArray[6, 8];
                }

                if (id10 == true)
                {
                    //Value for connection from link 7 to link 10
                    vendor7Out = vendor7Out + vendorArray[9, 6];
                    //Value for connection from link 10 to link 7
                    vendor9Out = vendor9Out + vendorArray[6, 9];
                }
            }



            if (id8 == true)
            {
                webpageTotal = webpageTotal + 1;

                if (id9 == true)
                {
                    //Value for connection from link 8 to link 9
                    vendor8Out = vendor8Out + vendorArray[8, 7];
                    //Value for connection from link 9 to link 8
                    vendor9Out = vendor9Out + vendorArray[7, 8];
                }

                if (id10 == true)
                {
                    //Value for connection from link 8 to link 10
                    vendor8Out = vendor8Out + vendorArray[9, 7];
                    //Value for connection from link 10 to link 8
                    vendor10Out = vendor10Out + vendorArray[7, 9];
                }
            }



            if (id9 == true)
            {
                webpageTotal = webpageTotal + 1;

                if (id10 == true)
                {
                    //Value for connection from link 9 to link 10
                    vendor9Out = vendor9Out + vendorArray[9, 8];
                    //Value for connection from link 10 to link 9
                    vendor10Out = vendor10Out + vendorArray[8, 9];
                }
            }



            if (id10 == true)
            {
                webpageTotal = webpageTotal + 1;
            }


            score1Total = (1 - dampingFactor) / (webpageTotal);
            score2Total = (1 - dampingFactor) / (webpageTotal);
            score3Total = (1 - dampingFactor) / (webpageTotal);
            score4Total = (1 - dampingFactor) / (webpageTotal);
            score5Total = (1 - dampingFactor) / (webpageTotal);
            score6Total = (1 - dampingFactor) / (webpageTotal);
            score7Total = (1 - dampingFactor) / (webpageTotal);
            score8Total = (1 - dampingFactor) / (webpageTotal);
            score9Total = (1 - dampingFactor) / (webpageTotal);
            score10Total = (1 - dampingFactor) / (webpageTotal);



            if (id1 == true)
            {
                Console.Out.WriteLine("Results for Vendor 1 are");
                Console.Out.WriteLine(score1Total);

                if (id2 == true)
                {
                    if (vendor2Out > 0)
                    {
                        score1Total = score1Total + (dampingFactor * (vendor2Score / vendor2Out));
                        Console.Out.WriteLine(score1Total);
                    }
                }

                if (id3 == true)
                {
                    if (vendor3Out > 0)
                    {
                        score1Total = score1Total + (dampingFactor * (vendor3Score / vendor3Out));
                        Console.Out.WriteLine(score1Total);
                    }
                }

                if (id4 == true)
                {
                    if (vendor4Out > 0)
                    {
                        score1Total = score1Total + (dampingFactor * (vendor4Score / vendor4Out));
                        Console.Out.WriteLine(score1Total);
                    }
                }

                if (id5 == true)
                {
                    if (vendor5Out > 0)
                    {
                        score1Total = score1Total + (dampingFactor * (vendor5Score / vendor5Out));
                        Console.Out.WriteLine(score1Total);
                    }
                }

                if (id7 == true)
                {
                    if (vendor7Out > 0)
                    {
                        score1Total = score1Total + (dampingFactor * (vendor7Score / vendor7Out));
                        Console.Out.WriteLine(score1Total);
                    }
                }

                if (id9 == true)
                {
                    if (vendor9Out > 0)
                    {
                        score1Total = score1Total + (dampingFactor * (vendor9Score / vendor9Out));
                        Console.Out.WriteLine(score1Total);
                    }
                }

                if (id10 == true)
                {
                    if (vendor10Out > 0)
                    {
                        score1Total = score1Total + (dampingFactor * (vendor10Score / vendor10Out));
                        Console.Out.WriteLine(score1Total);
                    }
                }
            }

            if (id2 == true)
            {
                Console.Out.WriteLine("Results for Vendor 2 are");
                Console.Out.WriteLine(score2Total);

                if (id1 == true)
                {
                    if (vendor1Out > 0)
                    {
                        score2Total = score2Total + (dampingFactor * (vendor1Score / vendor1Out));
                        Console.Out.WriteLine(score2Total);
                    }
                }

                if (id3 == true)
                {
                    if (vendor3Out > 0)
                    {
                        score2Total = score2Total + (dampingFactor * (vendor3Score / vendor3Out));
                        Console.Out.WriteLine(score2Total);
                    }
                }

                if (id6 == true)
                {
                    if (vendor6Out > 0)
                    {
                        score2Total = score2Total + (dampingFactor * (vendor6Score / vendor6Out));
                        Console.Out.WriteLine(score2Total);
                    }
                }

                if (id7 == true)
                {
                    if (vendor7Out > 0)
                    {
                        score2Total = score2Total + (dampingFactor * (vendor7Score / vendor7Out));
                        Console.Out.WriteLine(score2Total);
                    }
                }

                if (id9 == true)
                {
                    if (vendor9Out > 0)
                    {
                        score2Total = score2Total + (dampingFactor * (vendor9Score / vendor9Out));
                        Console.Out.WriteLine(score2Total);
                    }
                }
            }

            if (id3 == true)
            {
                Console.Out.WriteLine("Results for Vendor 3 are");
                Console.Out.WriteLine(score3Total);

                if (id1 == true)
                {
                    if (vendor1Out > 0)
                    {
                        score3Total = score3Total + (dampingFactor * (vendor1Score / vendor1Out));
                        Console.Out.WriteLine(score3Total);
                    }
                }

                if (id2 == true)
                {
                    if (vendor2Out > 0)
                    {
                        score3Total = score3Total + (dampingFactor * (vendor2Score / vendor2Out));
                        Console.Out.WriteLine(score3Total);
                    }
                }

                if (id5 == true)
                {
                    if (vendor5Out > 0)
                    {
                        score3Total = score3Total + (dampingFactor * (vendor5Score / vendor5Out));
                        Console.Out.WriteLine(score3Total);
                    }
                }

                if (id7 == true)
                {
                    if (vendor7Out > 0)
                    {
                        score3Total = score3Total + (dampingFactor * (vendor7Score / vendor7Out));
                        Console.Out.WriteLine(score3Total);
                    }
                }

                if (id9 == true)
                {
                    if (vendor9Out > 0)
                    {
                        score3Total = score3Total + (dampingFactor * (vendor9Score / vendor9Out));
                        Console.Out.WriteLine(score3Total);
                    }
                }

                if (id10 == true)
                {
                    if (vendor10Out > 0)
                    {
                        score3Total = score3Total + (dampingFactor * (vendor10Score / vendor10Out));
                        Console.Out.WriteLine(score3Total);
                    }
                }
            }


            if (id4 == true)
            {
                Console.Out.WriteLine("Results for Vendor 4 are");
                Console.Out.WriteLine(score4Total);

                if (id1 == true)
                {
                    if (vendor1Out > 0)
                    {
                        score4Total = score4Total + (dampingFactor * (vendor1Score / vendor1Out));
                        Console.Out.WriteLine(score4Total);
                    }
                }

                if (id6 == true)
                {
                    if (vendor6Out > 0)
                    {
                        score4Total = score4Total + (dampingFactor * (vendor6Score / vendor6Out));
                        Console.Out.WriteLine(score4Total);
                    }
                }

                if (id8 == true)
                {
                    if (vendor8Out > 0)
                    {
                        score4Total = score4Total + (dampingFactor * (vendor8Score / vendor8Out));
                        Console.Out.WriteLine(score4Total);
                    }
                }

                if (id10 == true)
                {
                    if (vendor10Out > 0)
                    {
                        score4Total = score4Total + (dampingFactor * (vendor10Score / vendor10Out));
                        Console.Out.WriteLine(score4Total);
                    }
                }
            }


            if (id5 == true)
            {
                Console.Out.WriteLine("Results for Vendor 5 are");
                Console.Out.WriteLine(score5Total);

                if (id1 == true)
                {
                    if (vendor1Out > 0)
                    {
                        score5Total = score5Total + (dampingFactor * (vendor1Score / vendor1Out));
                        Console.Out.WriteLine(score5Total);
                    }
                }

                if (id3 == true)
                {
                    if (vendor3Out > 0)
                    {
                        score5Total = score5Total + (dampingFactor * (vendor3Score / vendor3Out));
                        Console.Out.WriteLine(score5Total);
                    }
                }

                if (id7 == true)
                {
                    if (vendor7Out > 0)
                    {
                        score5Total = score5Total + (dampingFactor * (vendor7Score / vendor7Out));
                        Console.Out.WriteLine(score5Total);
                    }
                }

                if (id8 == true)
                {
                    if (vendor8Out > 0)
                    {
                        score5Total = score5Total + (dampingFactor * (vendor8Score / vendor8Out));
                        Console.Out.WriteLine(score5Total);
                    }
                }

                if (id10 == true)
                {
                    if (vendor10Out > 0)
                    {
                        score5Total = score5Total + (dampingFactor * (vendor10Score / vendor10Out));
                        Console.Out.WriteLine(score5Total);
                    }
                }
            }


            if (id6 == true)
            {
                Console.Out.WriteLine("Results for Vendor 6 are");
                Console.Out.WriteLine(score6Total);

                if (id2 == true)
                {
                    if (vendor2Out > 0)
                    {
                        score6Total = score6Total + (dampingFactor * (vendor2Score / vendor2Out));
                        Console.Out.WriteLine(score6Total);
                    }
                }

                if (id4 == true)
                {
                    if (vendor4Out > 0)
                    {
                        score6Total = score6Total + (dampingFactor * (vendor4Score / vendor4Out));
                        Console.Out.WriteLine(score6Total);
                    }
                }

                if (id7 == true)
                {
                    if (vendor7Out > 0)
                    {
                        score6Total = score6Total + (dampingFactor * (vendor7Score / vendor7Out));
                        Console.Out.WriteLine(score6Total);
                    }
                }

                if (id8 == true)
                {
                    if (vendor8Out > 0)
                    {
                        score6Total = score6Total + (dampingFactor * (vendor8Score / vendor8Out));
                        Console.Out.WriteLine(score6Total);
                    }
                }
            }


            if (id7 == true)
            {
                Console.Out.WriteLine("Results for Vendor 7 are");
                Console.Out.WriteLine(score7Total);

                if (id1 == true)
                {
                    if (vendor1Out > 0)
                    {
                        score7Total = score7Total + (dampingFactor * (vendor1Score / vendor1Out));
                        Console.Out.WriteLine(score7Total);
                    }
                }

                if (id2 == true)
                {
                    if (vendor2Out > 0)
                    {
                        score7Total = score7Total + (dampingFactor * (vendor2Score / vendor2Out));
                        Console.Out.WriteLine(score7Total);
                    }
                }

                if (id3 == true)
                {
                    if (vendor3Out > 0)
                    {
                        score7Total = score7Total + (dampingFactor * (vendor3Score / vendor3Out));
                        Console.Out.WriteLine(score7Total);
                    }
                }

                if (id5 == true)
                {
                    if (vendor5Out > 0)
                    {
                        score7Total = score7Total + (dampingFactor * (vendor5Score / vendor5Out));
                        Console.Out.WriteLine(score7Total);
                    }
                }

                if (id6 == true)
                {
                    if (vendor6Out > 0)
                    {
                        score7Total = score7Total + (dampingFactor * (vendor6Score / vendor6Out));
                        Console.Out.WriteLine(score7Total);
                    }
                }

                if (id8 == true)
                {
                    if (vendor8Out > 0)
                    {
                        score7Total = score7Total + (dampingFactor * (vendor8Score / vendor8Out));
                        Console.Out.WriteLine(score7Total);
                    }
                }

                if (id10 == true)
                {
                    if (vendor10Out > 0)
                    {
                        score7Total = score7Total + (dampingFactor * (vendor10Score / vendor10Out));
                        Console.Out.WriteLine(score7Total);
                    }
                }
            }


            if (id8 == true)
            {
                Console.Out.WriteLine("Results for Vendor 8 are");
                Console.Out.WriteLine(score8Total);

                if (id4 == true)
                {
                    if (vendor4Out > 0)
                    {
                        score8Total = score8Total + (dampingFactor * (vendor4Score / vendor4Out));
                        Console.Out.WriteLine(score8Total);
                    }
                }

                if (id5 == true)
                {
                    if (vendor5Out > 0)
                    {
                        score8Total = score8Total + (dampingFactor * (vendor5Score / vendor5Out));
                        Console.Out.WriteLine(score8Total);
                    }
                }

                if (id6 == true)
                {
                    if (vendor6Out > 0)
                    {
                        score8Total = score8Total + (dampingFactor * (vendor6Score / vendor6Out));
                        Console.Out.WriteLine(score8Total);
                    }
                }

                if (id7 == true)
                {
                    if (vendor7Out > 0)
                    {
                        score8Total = score8Total + (dampingFactor * (vendor7Score / vendor7Out));
                        Console.Out.WriteLine(score8Total);
                    }
                }
            }


            if (id9 == true)
            {
                Console.Out.WriteLine("Results for Vendor 9 are");
                Console.Out.WriteLine(score9Total);

                if (id1 == true)
                {
                    if (vendor1Out > 0)
                    {
                        score9Total = score9Total + (dampingFactor * (vendor1Score / vendor1Out));
                        Console.Out.WriteLine(score9Total);
                    }
                }

                if (id2 == true)
                {
                    if (vendor2Out > 0)
                    {
                        score9Total = score9Total + (dampingFactor * (vendor2Score / vendor2Out));
                        Console.Out.WriteLine(score9Total);
                    }
                }

                if (id3 == true)
                {
                    if (vendor3Out > 0)
                    {
                        score9Total = score9Total + (dampingFactor * (vendor3Score / vendor3Out));
                        Console.Out.WriteLine(score9Total);
                    }
                }

                if (id10 == true)
                {
                    if (vendor10Out > 0)
                    {
                        score9Total = score9Total + (dampingFactor * (vendor10Score / vendor10Out));
                        Console.Out.WriteLine(score9Total);
                    }
                }
            }


            if (id10 == true)
            {
                Console.Out.WriteLine("Results for Vendor 10 are");
                Console.Out.WriteLine(score10Total);

                if (id1 == true)
                {
                    if (vendor1Out > 0)
                    {
                        score10Total = score10Total + (dampingFactor * (vendor1Score / vendor1Out));
                        Console.Out.WriteLine(score10Total);
                    }
                }

                if (id3 == true)
                {
                    if (vendor3Out > 0)
                    {
                        score10Total = score10Total + (dampingFactor * (vendor3Score / vendor3Out));
                        Console.Out.WriteLine(score10Total);
                    }
                }

                if (id4 == true)
                {
                    if (vendor4Out > 0)
                    {
                        score10Total = score10Total + (dampingFactor * (vendor4Score / vendor4Out));
                        Console.Out.WriteLine(score10Total);
                    }
                }

                if (id5 == true)
                {
                    if (vendor5Out > 0)
                    {
                        score10Total = score10Total + (dampingFactor * (vendor5Score / vendor5Out));
                        Console.Out.WriteLine(score10Total);
                    }
                }

                if (id7 == true)
                {
                    if (vendor7Out > 0)
                    {
                        score10Total = score10Total + (dampingFactor * (vendor7Score / vendor7Out));
                        Console.Out.WriteLine(score10Total);
                    }
                }

                if (id9 == true)
                {
                    if (vendor9Out > 0)
                    {
                        score10Total = score10Total + (dampingFactor * (vendor9Score / vendor9Out));
                        Console.Out.WriteLine(score10Total);
                    }
                }
            }
        }
    }
}