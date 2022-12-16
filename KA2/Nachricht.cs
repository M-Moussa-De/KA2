namespace KA2
{
    internal abstract class Nachricht
    {
        protected Person absender;
        protected int likes;

        public Nachricht() {}

        public Nachricht(Person absender) => this.absender = absender;

        public void HinzufuegenLike() => likes++;

        public abstract string GetNachricht();
    }
}
