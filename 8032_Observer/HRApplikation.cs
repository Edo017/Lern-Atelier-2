namespace _8032_Observer
{
    public class HRApplikation : ISubject
    {
        List<IObserver> Observers = new();
        private List<string> Persons = new();
        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Run()
        {
            while (true) {
                Console.WriteLine("Geben Sie einen Namen ein (leer um abzubrechen)...");
                string personName = Console.ReadLine();
                if (personName == null || personName.Length == 0) { return; }
                Persons.Add(personName);
                Notify();
            }
        }

        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(Persons);
            }
        }
    }
}
