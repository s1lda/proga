using Microsoft.VisualBasic.FileIO;

namespace muha
{
    internal class Program
    {
        const int X = 0;
        const int Y = 1;
        const int Z = 2;
        static void Main(string[] args)
        {

            string path = "ввод.txt";
            StreamReader reader = new StreamReader(path);

            int[] size = new int[3];
            int[] spider_XYZ = new int[3];
            int[] muha_XYZ = new int[3];

            size = Array.ConvertAll(reader.ReadLine().Split(' ').ToArray(), int.Parse);
            spider_XYZ = Array.ConvertAll(reader.ReadLine().Split(' ').ToArray(), int.Parse);
            muha_XYZ = Array.ConvertAll(reader.ReadLine().Split(' ').ToArray(), int.Parse);

            string difficulty = "none";
            bool just_Line = false;
            double answer = 0;






            for (int i = 0; i < 3; i++)
            {

                if ((spider_XYZ[i] == 0 && muha_XYZ[i] == 0) || (spider_XYZ[i] == size[i] && muha_XYZ[i] == size[i])) 
                {

                    difficulty = "easy";
                    break;

                }
                else if ((spider_XYZ[i] == 0 && muha_XYZ[i] == size[i]) || (spider_XYZ[i] == size[i] && muha_XYZ[i] == 0)) 
                {

                    difficulty = "hard";
                }

                if (spider_XYZ[i] == muha_XYZ[i] && spider_XYZ[i] != 0 && spider_XYZ[i] != size[i]) 
                {
                    just_Line = true;
                }

            }

            if (difficulty == "none") 
            {
                difficulty = "normal";

              
            }


            if (difficulty == "easy")
            {
                if (just_Line)
                {
                    answer = Math.Abs(spider_XYZ[X] - muha_XYZ[X]) + Math.Abs(spider_XYZ[Y] - muha_XYZ[Y]) + Math.Abs(spider_XYZ[Z] - muha_XYZ[Z]);
                }
                else
                {
                    answer = Math.Sqrt(Math.Pow(Math.Abs(spider_XYZ[X] - muha_XYZ[X]), 2) + Math.Pow(Math.Abs(spider_XYZ[Y] - muha_XYZ[Y]), 2) + Math.Pow(Math.Abs(spider_XYZ[Z] - muha_XYZ[Z]), 2));
                }
            }
            else if (difficulty == "normal")
            {
                if (just_Line)
                {
                    answer = Math.Abs(spider_XYZ[X] - muha_XYZ[X]) + Math.Abs(spider_XYZ[Y] - muha_XYZ[Y]) + Math.Abs(spider_XYZ[Z] - muha_XYZ[Z]);
                }
                else
                {
                    int pavuk_Side = -1;
                    int muha_Side = -1;
                    int other_Side = -1;

                    for (int i = 0; i < 3; i++) 
                    {
                        if ((spider_XYZ[i] == 0 || spider_XYZ[i] == size[i]) && pavuk_Side == -1)
                        {
                            pavuk_Side = i;
                        }
                        else if ((muha_XYZ[i] == 0 || muha_XYZ[i] == size[i]) && muha_Side == -1)
                        {
                            muha_Side = i;
                        }
                        else
                        {
                            other_Side = i;
                        }
                    }

                    answer = Math.Sqrt(Math.Pow(Math.Abs(spider_XYZ[muha_Side] - muha_XYZ[muha_Side]) + Math.Abs(spider_XYZ[pavuk_Side] - muha_XYZ[pavuk_Side]), 2) + Math.Pow(Math.Abs(spider_XYZ[other_Side] - muha_XYZ[other_Side]), 2));

                }
            }
            else if (difficulty == "hard")
            {
                bool just_HARDLine = false;

                int common_Side = -1;           
                int[] other_Side = new int[2]; 

                for (int i = 0, n = 0; i < 3; i++) 
                {
                    if (((spider_XYZ[i] == 0 && muha_XYZ[i] == size[i]) || (spider_XYZ[i] == size[i] && muha_XYZ[i] == 0)) && common_Side == -1)
                    {
                        common_Side = i;
                    }
                    else
                    {
                        other_Side[n++] = i;
                    }
                }



                if (spider_XYZ[other_Side[0]] == muha_XYZ[other_Side[0]] && spider_XYZ[other_Side[1]] == muha_XYZ[other_Side[1]]) just_HARDLine = true;

                double[] ways = new double[4]; 
                ways[0] = size[common_Side] + (size[other_Side[0]] - spider_XYZ[other_Side[0]]) + (size[other_Side[0]] - muha_XYZ[other_Side[0]]);
                ways[1] = size[common_Side] + spider_XYZ[other_Side[0]] + muha_XYZ[other_Side[0]];
                ways[2] = size[common_Side] + (size[other_Side[1]] - spider_XYZ[other_Side[1]]) + (size[other_Side[1]] - muha_XYZ[other_Side[1]]);
                ways[3] = size[common_Side] + spider_XYZ[other_Side[1]] + muha_XYZ[other_Side[1]];

                if (just_HARDLine)
                {
                    answer = ways[0];

                    for (int i = 1; i < 4; i++)
                    {
                        answer = Math.Min(answer, ways[i]);
                    }
                }
                else
                {
                    ways[0] = Math.Sqrt(Math.Pow(ways[0], 2) + Math.Pow(Math.Abs(spider_XYZ[other_Side[1]] - muha_XYZ[other_Side[1]]), 2));
                    ways[1] = Math.Sqrt(Math.Pow(ways[1], 2) + Math.Pow(Math.Abs(spider_XYZ[other_Side[1]] - muha_XYZ[other_Side[1]]), 2));
                    ways[2] = Math.Sqrt(Math.Pow(ways[2], 2) + Math.Pow(Math.Abs(spider_XYZ[other_Side[0]] - muha_XYZ[other_Side[0]]), 2));
                    ways[3] = Math.Sqrt(Math.Pow(ways[3], 2) + Math.Pow(Math.Abs(spider_XYZ[other_Side[0]] - muha_XYZ[other_Side[0]]), 2));

                    answer = ways[0];

                    for (int i = 1; i < 4; i++)
                    {
                        answer = Math.Min(answer, ways[i]);
                    }
                }
            }

            Console.WriteLine(Math.Round(answer, 3));

            Console.ReadKey();
        }
    }
}