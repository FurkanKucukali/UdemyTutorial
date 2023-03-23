internal class Program
{
    private static void Main(string[] args)
    {
        List<string> isimler = new List<string>() {"Yavuz","Ahmet","Berk","Veli" };

        //Func<string, bool> func = new(AyiBul);
        var aIcerenIsimler = isimler.Where(a => a.Contains("a"));
        foreach (string deger in aIcerenIsimler)
        {
            Console.WriteLine(deger );
        }
        
    }
    //static bool AyiBul(string arg)
    //{
    //    return (arg.Contains("a"));
    //}
}