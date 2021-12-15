    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public void DisplayTriangle(int a)
            {
                int height= a;
                int width = a;
         
                for (int row=0; row < height; row++)
                {
                    for (int column=0; column < width; column++)
                    {
                        Console.Write( a );
                    }
                Console.WriteLine();
                 width--;
                }
            }
        }
    }