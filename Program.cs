namespace Opgave_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raflebæger raflebæger = new Raflebæger(6);

            raflebæger.Løft();
            raflebæger.Ryst();
            raflebæger.Løft();

            Console.WriteLine(raflebæger.antalTerninger);
            raflebæger.antalTerninger = 7;
            raflebæger.Løft();
            raflebæger.Ryst();
            raflebæger.Løft();
            Console.WriteLine(raflebæger.antalTerninger);

        }
    }
}