using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static Presenter presenter = new Presenter();

        static void Main(string[] args)
        {
            do
            {
                int caseSwitch;
                Console.WriteLine("Schoose one:\n\t1. Add\n\t2. Del\n\t3. Out\n\t4. Task");
                try
                {
                    caseSwitch = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    caseSwitch = 0;
                    Console.WriteLine("Number Only Permitted!");
                }
                finally
                {
                    //Console.WriteLine("TryFinal!");
                }
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Adding...");
                        presenter.Add();
                        break;
                    case 2:
                        Console.WriteLine("Type X Element index to delete");
                        int x = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Type Y Element index to delete");
                        int y = Int32.Parse(Console.ReadLine());
                        presenter.Del(x,y);
                        break;
                    case 3:
                        Console.WriteLine("Printing...");
                        presenter.Out();
                        break;
                    case 4:
                        Console.WriteLine("Task...");
                        presenter.Task();
                        break;
                    /*default:
                        Console.WriteLine("Default case");
                        break;*/
                }
            } while (true);
            //Console.ReadLine();
        }
    }
}
