using System.Diagnostics.Metrics;

namespace DAY_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = File.ReadAllLines(@"C:\Users\Omari\Documents\funny coding\c#\ADVENT OF CODE VS2023\AOC FULL\AOC23\DAY 3\input.txt").ToList();
            // string fileN = "input.txt";
            // List<string> input = new List<string>();
            //using (StreamReader inpy = new StreamReader(fileN))
            //{
            //    while (!inpy.EndOfStream)
            //    {
            //        string reading = Console.ReadLine();
            //        input.Add(reading);

            //    }
            //}

            int sum = 0;
            for (int i = 0; i < input.Count; i++) // line going through er thing
            {
                string currentString = input[i];
                Console.WriteLine($"{currentString}");
                for (int j = 0; j < currentString.Length; j++) // goes through each char.
                {
                    char currentChar = currentString[j]; // line and character
                    int currentNumber = 0;
                    Console.Write("{0}", currentChar);
                    // use code above to check if it's working properly
                    if (char.IsDigit(currentString[j]))
                    {
                        int currentIndex = j;
                        currentNumber += (int)currentChar;
                        bool bo = true;
                        while (bo == true)
                        {
                            int counter = 1;
                            if (char.IsDigit(currentString[currentIndex + counter]))
                            {
                                currentNumber += int.Parse(currentString[currentIndex + counter].ToString());
                                counter++;
                                j++;
                            }
                            else
                            {
                                j++;
                                bo = false;
                            }
                        }
                        Console.WriteLine($"{currentNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentNumber}");
                    }
                }
                // Console.WriteLine("");
                // splits lines up for formatting.
                Thread.Sleep(2500);
            }



            Console.ReadKey();
        }
        static public void numberCheck(int cNum)
        {
            //
        }
    }
}
