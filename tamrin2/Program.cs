using System;
namespace project
{
    class test
    {
        public static void main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            name(x, y);

        }
public static void name (int x , int y)
            {
                double volume = Math.Sqrt((Math.Abs(x) + Math.Pow(y, 2)));
                Console.WriteLine(volume);
            }
        
        }



    }


