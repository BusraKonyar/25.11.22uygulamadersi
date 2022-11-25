using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11._22uygulamadersi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    /*1.kullanıcıdan yaş bilgisi alınız mantıklı,tutarlı bir yaş mı kontol ediniz
            //     * 2.yaş 20-65 arasındaysa riski gruptasınız mesajı veriniz
            //     * 3.yaş 0-20 ve 65-100 arasındaysa riskli grupta değilsiniz mesajı veriniz
            //     * 4.görev diğer girişler için hatalı giriş mesajı verin
            //     */
            //    //trenary if ile yapımı

            //    basla:Console.WriteLine("bir yaş giriniz");
            //    string __AgeStr = Console.ReadLine();
            //    bool __IsSuccess = int.TryParse(__AgeStr, out int __Age);
            //    while (__IsSuccess==false)
            //    {
            //        Console.WriteLine("yanlış giriş yaptınız tekrar giriniz");
            //        __AgeStr = Console.ReadLine();
            //        __IsSuccess = int.TryParse(__AgeStr, out __Age);
            //    }
            //    string sonuc = __Age < 19 && __Age < 66 ? "riskli gruptasınız" : (__Age > 0 && __Age < 21) || (__Age > 66 && __Age <= 100) ? "riskli grupta değilsiniz" : "hatalı giriş yaptınız";
            //    Console.WriteLine(sonuc);
            //    goto basla;




            //kullanıcıya içecek tercihini sorunuz ,tercihe göre ekrana tercihiniz çay/kahve/su oldu

            //basla: Console.WriteLine("içecek tercihiniz nedir\r\n(çay:ç/Ç , kahve:k/K, su:s/S)");
            //       char tercih = Convert.ToChar(Console.ReadLine());

            //       switch(tercih)
            //       {
            //           case 'ç':
            //           case 'Ç':
            //               Console.WriteLine("tercihiniz çay oldu");
            //               break;
            //           case 'k':
            //           case 'K':
            //               Console.WriteLine("tercihiniz kahve oldu");
            //               break;
            //           case 's':
            //           case 'S':
            //               Console.WriteLine("tercihiniz su oldu");
            //               break;

            //           default:
            //               Console.WriteLine("hatalı giriş yaptınız");
            //               goto basla;
            //       }
            //       Console.ReadKey();




            //anket
            //satış yapılan bir ürünümüz var.kullanıcıya göre beğenip beğenmeme yada kararsız olma durumunu sorunuz 
            //ankete devam etmek istiyor musunuz diye sorunuz
            //beğenme,beğenmeme,kararsız sayısını anket sonunda ekrana yazdırınız



            //    basla:  Console.WriteLine("ürünü beğendiniz mi?(beğendim,beğenmedim,kararsızım)" );
            //          string tercih = Console.ReadLine();
            //          int beğenmesayısı = 0;
            //          int beğenmemesayısı = 0;
            //          int kararsızlıksayısı = 0;
            //          switch(tercih)
            //          {
            //              case "beğendim":
            //                  beğenmesayısı++;
            //                  break;
            //              case "beğenmedim":
            //                  beğenmemesayısı++;
            //                  break;
            //              case "kararsızım":
            //                  kararsızlıksayısı++;
            //                  break;
            //              default:
            //               Console.WriteLine("hatalı giriş yaptınız lüften tekrar deneyiniz");
            //                  goto basla;
            //          }


            //anketsorgu: Console.WriteLine("ankete başka katılacak kullanıcı var mı devam etmek istiyor musunuz?(evet/hayır)");
            //          string devam = Console.ReadLine();
            //          switch (devam)
            //          {
            //              case "evet":
            //                  goto basla;
            //                  break;
            //              case "hayır":
            //                  Console.WriteLine($"ankete katılan toplam kişi sayısı:{beğenmesayısı + beğenmemesayısı + kararsızlıksayısı} , \r\nürünümüzü beğenen sayısı{beğenmesayısı}\r\nürünümüzü beğenmeyenlerin sayısı{beğenmemesayısı}\r\nkararsız sayısı{kararsızlıksayısı}");
            //                  break;
            //              default:
            //                  Console.WriteLine("yanlış giriş yaptınız");
            //                  goto anketsorgu;
            //          }
            //          Console.ReadKey();




            //taş kağıt makas oyunu yapınız 

            //kullanıcı vs bilgisayar
            //el bittiği zaman kazananı yazdırın
            //tekrar oynamak isteyip istemediğini sorun
            //skor tutun
            //oyun sürdükçe skoru güncelleyin
            int playscore = 0;
            int computerscore = 0;
            string exitKey = "";
            while(exitKey!="e")
            {
                Console.Clear();
                Console.WriteLine("taş,kağıt,makas");
      GetInput: Console.WriteLine("choose [t]aş,[k]ağıt,[m]akas or [e]xit");
                string playerMove = "";
                switch(Console.ReadLine().ToLower())
                    case "t":
                    playerMove = "taş";
                    break;
                case "k":
                    playerMove = "kağıt";
                    break;
                case "m":
                    playerMove = "makas";
                    break;
                case "e":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("yanlış giriş yaptınız tekrar deneyin");
                    goto GetInput;
                    break;

                }
                Console.WriteLine($"seçiminiz {playerMove}");
                Random __Random = new Random();
                int __sayi=__Random.Next(0, 3);
             


            
            

           
            





        }

    }

}

























