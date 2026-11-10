namespace _8032_Observer
{
    public interface ISubject
    {
        public void Attach(IObserver observer);

        public void Detach(IObserver observer);

        public void Notify();


    }
}
