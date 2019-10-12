using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Presenter
    {
        int[,] a = new int[10, 10];

        public void Add()
        {
            //int[,] a = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //r num = random.Next();
                    //a[i, j] = r;
                    a[i, j] = (i + j) % 10 + 1;
                }
            }
        }

        public void Out()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(a[i, j] + " ");
                    Console.WriteLine();
            }
        }

        public void Del(int i, int j)
        {
            a[i, j] = 0;
        }

        public void Task()
        {
            for (int k = 0; k < 10; k++)
            {
                //Console.Write(a[i, 0]);
                if(a[k, 0] == 0)
                {
                    Console.WriteLine("Find Zerro!!! - Remove first string array");
                    int[,] b = new int[9, 10];
                    for (int i = 1; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            a[i, j] = b[i-1, j];
                        }
                    }
                    a = b;
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
