using AccessModifiers0304.Moduls;

namespace AccessModifiers0304
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee employee1=new Employee("Anar",4000);
            Employee employee2 = new Employee("Nurlan", 2000);

            Manager manager=new Manager();
            Assistant assistant = new Assistant();

            manager.GetPromotion(employee1);
            assistant.GetFeedback(employee1);
            manager.GetPromotion(employee2);
            assistant.GetFeedback(employee2);

            Console.WriteLine(employee1);
            Console.WriteLine(employee2);

        }
    }
}
