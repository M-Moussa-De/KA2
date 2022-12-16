namespace KA2
{
    internal class Person
    {
        private string nachname;
        private string vorname;

        public Person()
        {
        }

        public Person(string nn, string vn)
        {
            nachname = nn;
            vorname = vn;
        }

        public string GetNachname() => nachname;
        public string GetVorname() => vorname;
    }
}
