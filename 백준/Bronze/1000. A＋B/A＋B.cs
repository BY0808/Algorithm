namespace Algorithm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int A = int.Parse(ss[0]);
            int B = int.Parse(ss[1]);
            Console.WriteLine(A + B);
        }
    }
}
