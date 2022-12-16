using KA2;

SozialesNetzwerk sn = new SozialesNetzwerk();

Person p1 = new Person("Doe", "John");
Person p2 = new Person("Allan", "Max");

sn.HinzufuegenMitglied(p1);
sn.HinzufuegenMitglied(p2);

Textnachricht n = new Textnachricht("Nachricht von erster Person", p1);
Textnachricht n2 = new Textnachricht("Nachricht von zweiter Person", p2);
Textnachricht n3 = new Textnachricht("Nachricht von zweiter Person noch mal", p2);

sn.HinzufuegenNachricht(n);
sn.HinzufuegenNachricht(n2);
sn.HinzufuegenNachricht(n3);

n.HinzufuegenLike();
n2.HinzufuegenLike();

Console.WriteLine(sn.GetAlleNachrichten());

Console.WriteLine("Generiertes Passwort: " + sn.GetPassword("Ich generiere mir ein neues Passwort"));