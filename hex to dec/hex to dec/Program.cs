using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hex_to_dec
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex;
            Console.WriteLine(" please enter hexa number");
            hex = Console.ReadLine();

            int dec = 0;
            int num = 0;
            int nump = 1; 

            for(int i =hex.Length-1;i>=0;i--)
            {
                switch(hex[i])
                {
                    case 'a':
                        num = 10;
                        break;
                    case 'b':
                        num = 11;
                        break;
                    case 'c':
                        num = 12;
                        break;
                    case 'd':
                        num = 13;
                        break;
                    case 'e':
                        num = 14;
                        break;
                    case 'f':
                        num = 15;
                        break;
                    
                    default:
                        num = int.Parse(hex[i] + "");
                        break;


                }

                dec = dec + num * nump;
                nump *= 16;
            }
            Console.WriteLine(hex + " is " + dec);
        }
    }
}
