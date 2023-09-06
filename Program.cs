using CollegeApp.Model;

namespace CollegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College college = new College(1001, "Terna", "Navi Mumbai");
            Console.WriteLine(college);
        }
    }
}