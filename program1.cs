using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {

        string password = "";

        Console.WriteLine("Parolanızda rakam olsun mu? Y/N");
        string cevap = Console.ReadLine();
        switch (cevap.ToLower())
        {

            case "y":
                password += "1, 2, 3, 4, 5, 6, 7, 8, 9";
                break;

            case "n":
                password += "";
                break;

            default:
                Console.WriteLine("Lüsfen 'y' ya da 'n' şeklinde cevap veriniz");
                return;
        }

        Console.WriteLine("Parolanızda küçük harf olsun mu?Y/N");
        cevap = Console.ReadLine();
        switch (cevap.ToLower())
        {
            case "y":
                password += "a, b, c, d ,e, f, g, h, i, j, k, l, m, n, o, p, r, s, t, u, v, y, z";
                break;
            case "n":
                password += "";
                break;


            default:
                Console.WriteLine("Lüsfen 'y' ya da 'n' şeklinde cevap veriniz");
                break;
        }

        Console.WriteLine("Parolanızda büyük harf olsun mu?Y/N");
        cevap = Console.ReadLine();
        switch (cevap.ToLower())
        {
            case "y":
                password += "A, B, C, D, E, F, G, H, I ,J, K, L, M, N, O, P, R, S, T, U, V, Y, Z";
                break;
            case "n":
                password += "";
               break;


            default:
                Console.WriteLine("Lüsfen 'y' ya da 'n' şeklinde cevap veriniz");
                break;


        }


        Console.WriteLine("Parolanızda özel karakterler olsun mu?Y/N");
        cevap = Console.ReadLine();
        switch (cevap.ToLower())
        {
            case "y":
                password += "!, %, &, ?, -, <, >";

                break;
            case "n":
                password += "";
                break;


            default:
                Console.WriteLine("Lütfen 'y' ya da 'n' şeklinde cevap veriniz");
                break;
        }
        if (password == "")
        {
            Console.WriteLine("Password boş olamaz!");

        }
       
        else 
        {

            int maxListCount = 1;
            Console.WriteLine("Parolanın uzunluğunu belirtiniz");
            int uzunluk = Convert.ToInt32(Console.ReadLine());
           
            char[] dizi=password.ToCharArray();
           
            string sonuc = string.Empty;
            Random random= new Random();

            for(int i=0; i<uzunluk; i++)
            {


                sonuc += dizi[random.Next(0, dizi.Length)].ToString();
            }
            Console.WriteLine("Parolanız: " + sonuc); 





        }
    }
}


