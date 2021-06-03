using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            Models _models = new Models();
            ProccesManeger proccesManeger = new ProccesManeger(_models);
           a1:
            Menum();
        
          
            int result = 0;
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        proccesManeger.list();
                  
                        goto a1;
                      
                        
                   
                    case 2:
                        proccesManeger.Add();
                        Console.Clear();
                        goto a1;


                   
                    case 3:
                        proccesManeger.Delete();
                        Console.Clear();
                        goto a1;

                       
                    case 4:
                        proccesManeger.move();
                        Console.Clear();
                        goto a1;
                    case 5:
                        proccesManeger.kisiAdd();
                        Console.Clear();
                        goto a1;
                       
                    default:
                        break;
                }

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }
            Console.ReadLine();
        }
        public static void Menum()
        {

            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine(" (2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Çalışan Ekle ");

            Console.Write(" Lütfen yapmak istediğiniz işlemi seçiniz:");

        }

        
    }
    }
   




