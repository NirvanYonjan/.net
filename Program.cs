namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            // HelloWorld helloWorld = new HelloWorld();
            // helloWorld.add<string>("My name is Nirvan Yonjan");

            //     Practice<string> practice = new Practice<string>("KawasakiH2");
            //    Console.WriteLine("Ducati");


            Practice2<int, String> practice2 = new Practice2<int, String>(789, "Red", "BMW");
            System.Console.WriteLine(practice2.model);
            System.Console.WriteLine(practice2.color);
            System.Console.WriteLine(practice2.company);

        }
    }
}