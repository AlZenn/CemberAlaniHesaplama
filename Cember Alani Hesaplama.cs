using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cemberalani
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //çemberin alanını hesaplama

        //pi'yi kullanıcının yazmasına gerek olmadığı için float değişkeni ile tanımlıyoruz.
        // verdiğimiz değerin sonuna f koymayı unutmayın.
        float pi = 3.14f;

        //programımızın hesaplayacagı alan değişkenini tanımlıyoruz

        double alan;

        //kullanıcının gireceği yarıçap değişkenini tanımlıyoruz
        int r;

        //kullanıcının değeri girmesini sağlamak için uyarı mesaji yazıyoruz.
        Console.Write("Çemberin yarıçapını giriniz: ");

        //Yarıçapın değerini programa okutuyoruz.
        r = Convert.ToInt32(Console.ReadLine());

        // alan hesaplamasını yapması için programımıza değerleri yerleştirip hesap yapmasını sağlıyoruz.
        alan = pi * r * r;

        //programımızın yaptıgı hesabı kullanıcıya aktaran son uyarı kodunu yazıyoruz
        Console.WriteLine("Çemberin alanı: "+alan);


            Console.ReadKey();
        }
    }
}
