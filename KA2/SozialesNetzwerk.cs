namespace KA2
{
    internal class SozialesNetzwerk
    {
        private List<Person> mitgliederliste;
        private List<Nachricht> nachrichtenliste;

        public SozialesNetzwerk()
        {
            this.mitgliederliste = new List<Person>();
            this.nachrichtenliste = new List<Nachricht>();
        }

        public void HinzufuegenMitglied(Person person) => this.mitgliederliste.Add(person);
        public void HinzufuegenNachricht(Nachricht nachricht) => this.nachrichtenliste.Add(nachricht);
        public string GetAlleNachrichten()
        {
            string txt = string.Empty;

            foreach (Nachricht nachricht in nachrichtenliste)
            {
                txt += nachricht.GetNachricht() + "\n=============\n";
            }

            return txt;
        }

        public string GetPassword(string satz)
        {
            string pass = string.Empty;
            string[] woerterArr = satz.Split(" ");
           
            for (int i = 0; i < woerterArr.Length; i++)
            {
                //ignoriere jedes char, die nicht buchstabe ist
                if (Char.IsLetter(woerterArr[i][0]))
                {
                    if(i % 2 ==  0)
                    {
                        pass += woerterArr[i].Substring(0, 1).ToUpper();
                    } else
                    {
                        pass += woerterArr[i].Substring(0, 1).ToLower();
                    }
                }
            }
            return pass;
        }
    }
}
