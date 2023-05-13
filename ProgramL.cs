using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriUyg
{
    public class Program
    {
        static void Main(string[] args)
        {
            var araclar = new List<IArac>();

            // Arac Modeli : Otomobil = m, Otobus = b
            // m|Marka|Model|Yas|1    // 1 = Üstü Açık
            // b|Marka|Model|Yas|0    // 0 = Takometre yok
            // Çıkış yapmak için Ç;

            Console.Clear();


            var idSayac = 1;    // Her üretilen araç için bir ıd sayacı kendimiz atarız.


            var girilenDeger = Console.ReadLine();
            var parcalar = girilenDeger.Split('|');
            while (true)
            {
               
                if (girilenDeger == "Ç")
                {
                    break;  // Çıkış yap
                }

                    // Bir dizgeyi belirli bir ayraç ile parçalayıp
                    //  parçalardan bir dizi döndürür.   

                var marka = parcalar[1];
                var model = parcalar[2];
                var yas = Convert.ToInt32(parcalar[3]);
                var OzelDeger = parcalar[4] =="1" ? true : false;   // parcalar[4] içersinde "1" varsa



                if (parcalar[0] == "m")
                {
                    araclar.Add(new Otomobil
                    {
                        Id = idSayac,
                        Marka = marka,
                        Model = model,
                        Yas = yas,
                        UstuAcıkMı = OzelDeger

                    });

                }

                else if (parcalar[0] == "b")
                {
                    araclar.Add(new Otobus
                    {
                        Id = idSayac,
                        Marka = marka,
                        Model = model,
                        Yas = yas,
                        TakometreVarMı = OzelDeger

                    });
                }

                else
                {
                    Console.WriteLine("Girilen verilerde hata var");
                    break;
                }
                    idSayac++;

                }

                foreach (var arac in araclar)
                {
                    Console.WriteLine(arac.OzellıkleriGoster());
                }
            }

        }
    };
