using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class ProccesManeger
    {
        Models _models;

        List<Models> todoModel = new List<Models>();
        Kisi _kisi = new Kisi();
        List<Models> Indor = new List<Models>();
        List<Models> proccesModel = new List<Models>();
        Dictionary<int, string> kisim = new Dictionary<int, string>();

        public ProccesManeger(Models models)
        {

            _models = models;

        }
        public ProccesManeger(Kisi kisim)
        {
            _kisi = kisim;
        }

        public void list()
        {
            if (todoModel == null)
            {
                Console.WriteLine("Eleman Ekleyiniz");
            }
            foreach (Models models1 in todoModel)
            {
                Console.WriteLine("Todo");
                Console.WriteLine("***********");
                Console.WriteLine($"Başlık  :{models1.Title}  \n İçerik   : {models1.Details}  \n  Büyüklük :{Buyukluk.M} \n Çalışan Kisi:{models1.name} ");

            }
            foreach (Models models1 in Indor)
            {
                Console.WriteLine("IN PROGRESS Line");
                Console.WriteLine("***********");
                Console.WriteLine($"Başlık  :{models1.Title}  \n İçerik   : {models1.Details}  \n  Büyüklük :{Buyukluk.M}  ");

            }
            foreach (Models models1 in proccesModel)
            {
                Console.WriteLine("DONE Line");
                Console.WriteLine("***********");
                Console.WriteLine($"Başlık  :{models1.Title}  \n İçerik   : {models1.Details}  \n  Büyüklük :{Buyukluk.M}  ");

            }

        }
        public void Add()
        {



            Console.Write(" Başlık Giriniz : ");
            string Title = Console.ReadLine();
            Console.Write("İçerik Giriniz ");
            string Details = Console.ReadLine();
            Console.WriteLine(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Kişi Seçiniz: ");
            foreach (var item1 in kisim)
            {
                Console.WriteLine($"Kişinin İsmi : { item1.Value} \n Id: {item1.Key}");
                Console.WriteLine("---------------------------");

            }
            var cevap = Console.ReadLine();
        
            if (cevap == _kisi.Name)
            {
                _models.name = _kisi.Name;
                _models.Title = Title;
                _models.Details = Details;
                todoModel.Add(_models);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Hata");
            }
          


        }

   
        public void Delete() {
            deneme:
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string title = Console.ReadLine();
          var soru = todoModel.FirstOrDefault(x => x.Title == title);
            if (soru == null)
            {
                Console.WriteLine("Hatalı Tuşlama");
              
                Console.WriteLine("İşlemi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için : (2)");
                int cevap = Convert.ToInt32(Console.ReadLine());
                if (cevap==1)
                {
                    Environment.Exit(0);
                }
                else if (cevap ==2)
                {
                    goto deneme;
                }
                else
                {
                    Console.WriteLine("Düzgün Bas kardeş");
                    Console.ReadLine();
                   
                }
                
            }
            else
            {
                todoModel.Remove(soru);
            }
        
        }
        public void move()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string title = Console.ReadLine();
            var soru = todoModel.FirstOrDefault(x => x.Title == title);
            if (soru == null)
            {


            }
            else
            {
                Console.WriteLine(" Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine("(1) TODO \n(2) IN PROGRESS \n(3) DONE");

                int sorgu = Convert.ToInt32(Console.ReadLine());
                switch (sorgu)
                {
                    case 1:
                        _models.Id = soru.Id;
                        _models.Title = soru.Title;
                        todoModel.Remove(soru);
                        todoModel.Add(_models);
                        list();
                        break;
                    case 2:
                        _models.Id = soru.Id;
                        _models.Title = soru.Title;
                        todoModel.Remove(soru);
                        Indor.Add(_models);
                        list();
                        break;
                    case 3:
                        _models.Id = soru.Id;
                        _models.Title = soru.Title;
                        todoModel.Remove(soru);
                        Indor.Remove(soru);
                        proccesModel.Add(_models);
                        list();
                        break;
                    default:
                        break;
                }


            }


        }
       
        public void kisiAdd()
        {
          
            _kisi.kisiID++;
        
            Console.Write("Kişi Ekleyiniz               :");
            string name = Console.ReadLine();
            _kisi.Name = name;
            kisim.Add(_kisi.kisiID,_kisi.Name);

        }
    }
}
