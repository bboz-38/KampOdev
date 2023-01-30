using MyDictionary;

internal class Program
{
    private static void Main(string[] args)
    {
        MyDictionary<int, string> students = new MyDictionary<int, string>();
        students.Add(01, "Burhan Boz");
        students.Add(02, "Orhan Boz");

        Console.WriteLine(students.MyLength);
        
    }
}