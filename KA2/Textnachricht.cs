namespace KA2
{
    internal class Textnachricht : Nachricht
    {
        private string nachricht;

        public Textnachricht() { }
        public Textnachricht(string nachricht, Person absender) : base(absender) => this.nachricht = nachricht;        
        public override string GetNachricht()
        {
            string info = string.Empty;

            info += $"Name: {absender.GetVorname()} {absender.GetNachname()}\n";
            info += $"Nachricht: {nachricht}\n";
            info += $"Likes: {likes}";

            return info;
        }
    }
}
