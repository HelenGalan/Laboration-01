using System;

namespace Laboration_01___Att_hitta_siffror
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of variables that shows the sequence and separate in: before, found and after code
            string hell = "29535123p48723487597645723645";
            string first = "";
            string color = "";
            string last = "";
            char start;
            char fortwo;


            // Looping to find the sequence that starts and ends with the same number, but has no letter
            for (int i = 0; i < hell.Length - 1; i++)
            {
                start = char.Parse(hell.Substring(i, 1));
                    if (char.IsLetter(start))
                {
                    continue;
                }

                // Sending out when the letter was found
                for (int o = i+1; o < hell.Length; o++)
                {
                    fortwo = char.Parse(hell.Substring(o, 1));
                    if (char.IsLetter(fortwo))
                    {
                        break;
                    }

                    // Color setting
                    if (start == fortwo)
                    {
                        first = hell.Substring(0, i);
                        color = hell.Substring(i, o - i + 1);
                        last = hell.Substring(o + 1);

                        if (color == hell.Substring(0))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(color);
                            Console.ResetColor();

                            Console.Write(last);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(first);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(color);
                            Console.ResetColor();

                            Console.Write(last);
                            Console.WriteLine();
                        }
                        break;
                    }
                    
                }
            }

        }
    }
}
