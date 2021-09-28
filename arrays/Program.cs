using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            arrayofstrings();
        }

        static void arrayofstrings()
        {
            string[] navnearray = new string[5] { "daniel", "maniel", "haniel", "tamiel", "rasputin" };
            Console.WriteLine(navnearray[4]);
            Console.ReadLine();
            navnearray[2] = "mario";
            Console.WriteLine(navnearray[2]);
            Console.ReadLine();
            /*
            foreach (string number in navnearray)
            {
                Console.WriteLine(number.ToString());
            }
            */
            for (int i = 0; i <navnearray.Length; i++)
            {
                Console.WriteLine(navnearray[i]);
            }
            Console.Clear(
            Console.WriteLine("do you wish to change a name?\n" +
                "1 daniel\n" +
                "2 maniel\n" +
                "3 haniel\n" +
                "4 tamiel\n" +
                "5 RASPUTIN");
            byte choice = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("what do you wish to change it to");
            string nytnavn = Convert.ToString(Console.ReadLine());
            navnearray[choice] = nytnavn;
            for (int i = 0; i < navnearray.Length; i++)
            {
                Console.WriteLine(navnearray[i]);
            }
            Console.ReadLine();

        }
        static void myArray()
        {

            int[] myarray = new int[7] { 12, 33, 532, 145, 1, 4565, 1 };
            // array'en er et it int, med 7 værdier i alt. dvs 0=12, 1=33, 2=532 osv. hvis vi ikke
            // hvis vi ikke vidste hvor mange værdier der var i array'et havde vi ikke sat et tal ind
            Console.WriteLine(myarray[4]);
            // henter værdien for det der tilsvare plads nr 5 i arrayet, fordi 0 tæller som 1
            Console.ReadLine();
            myarray[2] = 36562;
            //sætter værdi 2, dvs det 3. tal til at være 36562
            Console.WriteLine(myarray[2]);
            Console.ReadLine();

            /*
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
                
            }
            */
            foreach (int number in myarray)
            {
                Console.WriteLine(number.ToString());

            }

            Console.ReadLine();
        }
    }
}
