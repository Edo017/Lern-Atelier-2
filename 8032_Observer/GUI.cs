namespace _8032_Observer
{
    public class Gui : IObserver
    {
        public void Update(List<string> people)
        {
            Console.WriteLine("Mitarbeiter:");
            Console.WriteLine("++++++++++++++++++++");
            foreach (var person in people) {
                Console.WriteLine(person);
            }
            Console.WriteLine("++++++++++++++++++++");
        }
    }
}
