using System;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            #region sorular
            //1- Girilen yabancı dile göre "seni seviyorum" ifadesini kendi diline ekrana yazan program.
            //(Diller Türkçe, İngilizce, Almanca, Fransızca)(Seçim yapınca ekrana o dilde seni seviyorum yazacak)



            //2- Girilen iki sayı için 4 işlem programını yapınız.(iki sayı girilecek seçim +, -, / , * olacak. Sadece Switch-Case kullanılacak.)




            //3- Seçilen geometrik şekile göre alanını ve çevresini hesaplayıp ekrana yazdıran programı yazınız.(Switch-Case kullanılacak. Kare, dikdörtgen, dik üçgen vb. daha fazla geometrik şekil ekleyebilirsiniz. Seçtikten sonra kullanıcıdan gereken bilgiler istenip hesap yaptırılabilr.)




            //4- Klavyeden kullanıcı tarafından basılan harf tuşunun büyük harf mi küçük harf mi olduğunu bulan program.(if-else)



            //5-İkinci dereceden bir denklemin köklerini bulan program. (if-else. Karesini ya da kökünü aldığınız işlemlerde Math sınıfından yararlanabilirsiniz.)



            //6- Kullanıcıdan cinsiyet(e/k), askerlik durumu(yaptı mı? e/h) ve yaş bilgileri istendikten sonra, sadece erkek(e), askerliğini yapmış ve de 30 ve daha küçük yaştaki kişilerin başvurusunun kabul edildiği programı if-else komutu ile yazınız.



            //7- Girilen vize ve final notlarına göre vize notunun %40'ı final notunun %60 alınarak hesaplanan toplam not 50yi geçiyorsa öğrencinin dersten geçip geçmediğini bulan algoritmayı yazınız.



            //8- Kullanıcının girdiği sayıyı 10'dan küçük olup olmadığını kontrol eden kodları TERNARY operatörü ile yapınız.



            //9- Klavyeden girilen sayının hangi güne ait olduğunu bulan program.(switch-case)(1 hafta için)



            //10- Klavyeden girilen mevsime ait ayları ekrana yazan program. (Switch - case)



            //11- Trafik ışıklarının renklerine göre ne yapılacağını söyleyen program(switch)



            //12- Girilen güne göre haftaiçi mi haftasonu mu olduğunu söyleyen program.



            //13- Klavyeden girilen iki sayının birbirine tam bölünüp bölünmediğini söyleyen program.
            #endregion sorular
            



            #region soru3 

           basa: Console.WriteLine("Alanını ve çevresini öğrenmek istediğiniz geometrik şekli giriniz (kare(k),dikdörtgen(d),diküçgen(u))");
            char geometrikSekil = Convert.ToChar(Console.ReadLine());

            switch (geometrikSekil)
            {
                case 'k':



            Console.WriteLine("Karenin kenar uzunluğunu giriniz");
                int kenarUzunluk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Karenizin alanı = " + (kenarUzunluk*kenarUzunluk));
                Console.WriteLine("Karenizin çevresi = " + (kenarUzunluk * 4));
                    break;

                case 'd':
            
                Console.WriteLine("Uzun kenar uzunluğunu giriniz");
                int uzunKenar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kısa kenar uzunluğunu giriniz");
                int kisaKenar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dikdörtgenin alanı = " + (uzunKenar*kisaKenar));
                Console.WriteLine("Dikdörtgenin çevresi = " + (2*(uzunKenar + kisaKenar)));
            break;

                case 'u':
            
                Console.WriteLine("İlk kenarı giriniz");
                int ilkKenar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci kenarı giriniz");
                int ikinciKenar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("DİK kenarı giriniz");
                int dikKenar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Üçgenin alanı = " + (ilkKenar*ikinciKenar/2));
                Console.WriteLine("Üçgenin çevresi =  "+ (ilkKenar + ikinciKenar + dikKenar ));
            break;
            default:
            
                Console.WriteLine("Lütfen belirtilen geometrik şekillerden birini giriniz!");
                goto basa;
            

            }



            #endregion soru3

            #region soru4

            Console.WriteLine("Bir karakter giriniz!");
            char karakter = Convert.ToChar(Console.ReadLine());

            if (karakter >='a' & karakter <='z')
            {
                Console.WriteLine("girdiğiniz karakter küçüktür");
            }
            else
            {
                Console.WriteLine("Girdiğiniz karakter büyüktür");
            }


            #endregion soru4

            #region soru5

            Console.WriteLine("Lütfen (ax^2 + bx + c) genel denklemindeki  a,b,c değerlerini giriniz");
            double birinciKok = 0, ikinciKok = 0;

            double a = Convert.ToSingle(Console.ReadLine());
            double b = Convert.ToSingle(Console.ReadLine());
            double c = Convert.ToSingle(Console.ReadLine());
            double delta = (b * b) - 4 * a * c;

            if (delta>0)
            {
                birinciKok = Math.Pow((-b + delta), 1 / 2) / 2 * a;
                ikinciKok =  Math.Pow((-b - delta), 1 / 2) / 2 * a;
                Console.WriteLine("Denklemin iki farklı reel kökü vardır " + birinciKok+ " " + ikinciKok);

            }
            else if (delta==0)
            {
                birinciKok = -b / 2 * a;
                ikinciKok = -b / 2 * a;
                Console.WriteLine("Denklemin birbirine eşit iki reel kökü vardır" + birinciKok + " " + ikinciKok );
            }
            else
            {
                Console.WriteLine("Denklemin kökü yoktur!");
            }

            
            #endregion soru5s

            #region soru6

            Console.WriteLine("Cinsiyetinizi e,k Giriniz");
            char cinsiyet = Convert.ToChar(Console.ReadLine());

            if (cinsiyet == 'e' || cinsiyet  == 'E')
            {
                Console.WriteLine("Askerlik durumunuzu e,h giriniz");
                char askerlikDurum = Convert.ToChar(Console.ReadLine());
                if (askerlikDurum == 'e' || askerlikDurum == 'E' )
                {
                    Console.WriteLine("Yaşınızı giriniz");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if (yas <= 30)
                    {
                        Console.WriteLine("Başvurunuz başarılı! Tebrikler işe alındınız!");
                    }
                    else
                    {
                        Console.WriteLine("Başvurunuz olumsuzdur!");
                    }
                }
                else
                {
                    Console.WriteLine("Başvurunuz olumsuzdur!");
                }

            }
            else
            {
                Console.WriteLine("Başvurunuz olumsuzdur!");
            }


            #endregion soru6

            #region soru7

            int toplam=0;
            Console.WriteLine("Vize notunuzu giriniz");
            int vizeNot = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Final notunuzu giriniz");
            int finalNot = Convert.ToInt32(Console.ReadLine());

            toplam = (vizeNot * 40 / 100) + (finalNot * 60 / 100);

            if (toplam >=50)
            {
                Console.WriteLine("Tebrikler dersi geçtiniz!");
            }
            else
            {
                Console.WriteLine("Dersten kaldın seneye görüşürüz!");
            }
            #endregion soru7

            #region soru8

            

            Console.WriteLine("Bir sayı giriniz ");
            int sayi12 = Convert.ToInt32(Console.ReadLine());
            string sonuc = sayi12 < 10 ? "Sayı 10'dan küçüktür" : "Sayı 10'dan büyüktür";
            

        #endregion soru8

            #region soru9

           enbasaa: Console.WriteLine("Lütfen 1 den 7'e kadar bir sayı giriniz");
            char sayi = Convert.ToChar(Console.ReadLine());

            switch (sayi)
            {
                case '1':
                    Console.WriteLine("Pazartesi");
                    break;
                case '2':
                    Console.WriteLine("Salı");
                    break;
                case '3':
                    Console.WriteLine("Çarşamba");
                    break;
                case '4':
                    Console.WriteLine("Perşembe");
                    break;
                case '5':
                    Console.WriteLine("Cuma");
                    break;
                case '6':
                    Console.WriteLine("Cumartesi");
                    break;
                case '7':
                    Console.WriteLine("Pazar");
                    break;

                default:
                    goto enbasaa;
                   
            }

            #endregion soru9

            #region soru10

            mevsim:  Console.WriteLine("Lütfen mevsim giriniz (i,y,s,k)");
            char mevsim = Convert.ToChar(Console.ReadLine());
            switch (mevsim)
            {
                case 'i':
                    Console.WriteLine("Mart, Nisan, Mayıs");
                    break;
                case 'y':
                    Console.WriteLine("Haziran, Temmuz, Ağustos");
                    break;
                case 's':
                    Console.WriteLine("Eylül, Ekim, Kasım");
                    break;
                case 'k':
                    Console.WriteLine("Aralık, Ocak, Şubat");
                    break;

                default:
                    Console.WriteLine("Lütfen belirtilen değerlerden birini giriniz!");
                    goto mevsim;
                    
            }

            #endregion soru10

            #region soru11

            isikAl:  Console.WriteLine("Lütfen ışık rengi giriniz(y,s,k)");
            char isik = Convert.ToChar(Console.ReadLine());

            
            switch (isik)
            {
                case 'y':
                    Console.WriteLine("Geçiniz");
                    break;
                case 's':
                    Console.WriteLine("Yeşil yanana kadar hazır olunuz");
                    break;
                case 'k':
                    Console.WriteLine("Durunuz!");
                    break;

                default:
                    Console.WriteLine("Geçerli bir değer giriniz");
                    goto isikAl;
            }

            #endregion soru11

            #region soru12

            gunlere: Console.WriteLine("Bir gün giriniz");
            string gunler = Console.ReadLine();
            if (gunler =="Pazartesi" || gunler == "Salı"|| gunler =="Çarşamba" || gunler =="Perşembe"|| gunler =="Cuma")
            {
                Console.WriteLine("Girdiğiniz gün haftaiçidir!");
            }
            else if (gunler == "Cumartesi"|| gunler == "Pazar")
            {
                Console.WriteLine("Girdiğiniz gün haftasonudur!");
            }
            else
            {
                Console.WriteLine("Geçerli bir gün giriniz");
                goto gunlere;
            }


            #endregion soru12

            #region soru13

            Console.WriteLine("Birinci sayıyı giriniz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz");
            int sayi4 = Convert.ToInt32(Console.ReadLine());

            if (sayi3 % sayi4 ==0)
            {
                Console.WriteLine("Birinci sayı ikinci sayıya tam bölünür!");
            }
            else
            {
                Console.WriteLine("Birinci sayı ikinci sayıya tam bölünmez!");
            }

            #endregion soru13
        }
    }
}
