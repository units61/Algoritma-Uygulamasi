// Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, 
// sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.

// Örnek Input: 2 3 1 5 2 5 3 3

// Output: 5 6 7 81

string continueProgram="";
while(continueProgram != "exit")
{
Console.WriteLine("Bir çift sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
int[] sayiListesi = new int[sayi];

    if(sayi % 2 == 0 )
    {
        for (int i = 0; i <sayi; i++)
        {
            Console.WriteLine("{0}. sayınız: ", i + 1);
            sayiListesi[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i<sayiListesi.Length; i+=2)
            {
                if(sayiListesi[i] == sayiListesi[i+1])
                {
                    int toplam = sayiListesi[i] + sayiListesi[i+1];
                    Console.WriteLine(" " + toplam * toplam + "");
                }
                else
                {
                    int toplam = sayiListesi[i] + sayiListesi[i+1];
                    Console.WriteLine(" " + toplam + "");
                }
            }
    }
    else
    {
        Console.WriteLine("\a Hatalı tuşlama! Lütfen çift sayı giriniz.");
    }

}