
//OOP, ÖVNINGUPPGIFTER MED KLASSER OCH OBJEKT


/*
 1. Skriv ut namn på personer
Skriv en klass som representerar en person. 
Klassen ska ha två publika fält (fields): firstName, lastName. 
Skapa två instanser av personer med olika för och efternamn, och använd sedan dessa för att printa ut (hela) namnen på de olika personerna.
 */

//Person firstPerson = new Person() { firstName = "Anna", lastName = "Svensson" };
//Person secondPerson = new Person() { firstName = "Per", lastName = "Ask" };


//firstPerson.FullName();
//secondPerson.FullName();

//class Person
//{
//    public string firstName = "Inget";
//    public string lastName = "Namn";

//    public void FullName()
//    {
//        Console.WriteLine($"{firstName} {lastName}");
//    }
//}




/*
 2. Lägg till en metod som returnerar hela namnet
Uppdatera klassen i uppgift 1 med en metod: public string GetFullName(), som returnerar en sträng med hela namnet.
 */


//Person firstPerson = new Person() { firstName = "Anna", lastName = "Svensson" };
//Person secondPerson = new Person() { firstName = "Per", lastName = "Ask" };

//Console.WriteLine(firstPerson.GetFullName());
//Console.WriteLine(secondPerson.GetFullName());


//class Person
//{
//    public string firstName = "Inget";
//    public string lastName = "Namn";

//    public string GetFullName()
//    {
//        return firstName + " " + lastName;
//    }
//}


/*
 3. Lägg till en metod som returnerar namnet baklänges
Uppdatera klassen med en ny metod: public string GetFullNameReversed() som returnerar en sträng med hela namnet baklänges. 
Låt denna metoden använda sig av metoden i uppgift 2.
 */

//Person firstPerson = new Person() { firstName = "Anna", lastName = "Svensson" };
//Person secondPerson = new Person() { firstName = "Per", lastName = "Ask" };

//Console.WriteLine(firstPerson.GetFullNameReversed());
//Console.WriteLine(secondPerson.GetFullNameReversed());

//class Person
//{
//    public string firstName = "Inget";
//    public string lastName = "Namn";

//    public string GetFullName()
//    {
//        return firstName + " " + lastName;
//    }

//    public string GetFullNameReversed()
//    {
//        string fullName = GetFullName();
//        char[] nameToCharArray = fullName.ToCharArray();
//        Array.Reverse(nameToCharArray);
//        return new string(nameToCharArray);
//    }



/*
 4. Overload av GetFullName med titel.
GetFullName ska finnas i två versioner: en utan parametrar som i uppgift 2; 
och en där man kan skicka in en titel, 
t.ex. "Dr." eller "Mr." som returnerar namnet på personen med titeln framför.
 */


//Person firstPerson = new Person() { title = "Dr.", firstName = "Anna", lastName = "Svensson" };
//Person secondPerson = new Person() { title = "Mr.", firstName = "Per", lastName = "Ask" };

//Console.WriteLine(firstPerson.GetFullName());
//Console.WriteLine(secondPerson.GetFullName());

//Console.WriteLine(firstPerson.GetFullName(firstPerson.title));
//Console.WriteLine(secondPerson.GetFullName(secondPerson.title));


//class Person
//{
//    public string title = "No title";
//    public string firstName = "Inget";
//    public string lastName = "Namn";

//    public string GetFullName()
//    {
//        return firstName + " " + lastName;
//    }

//    public string GetFullName(string title)
//    {
//        return title + " " + firstName + " " + lastName;
//    }
//}



///*
// 5. Lägg till så personer kan ha föräldrar.
//Uppdatera person-klassen så att varje person kan ha en mamma och en pappa. 
//Dessa representeras som publika fält(fields) av typen Person (eller vad du kallade klassen i uppgift 1).

// */


//Person firstPerson = new Person() { title = "Dr.", firstName = "Anna", lastName = "Svensson" };
//Person secondPerson = new Person() { title = "Mr.", firstName = "Per", lastName = "Ask" };

//Console.WriteLine(firstPerson.GetFullName());
//Console.WriteLine(secondPerson.GetFullName());

//Console.WriteLine(firstPerson.GetFullName(firstPerson.title));
//Console.WriteLine(secondPerson.GetFullName(secondPerson.title));


//class Person
//{
//    public string title = "No title";
//    public string firstName = "Inget";
//    public string lastName = "Namn";
//    public Person mother;
//    public Person father;

//    public string GetFullName()
//    {
//        return firstName + " " + lastName;
//    }

//    public string GetFullName(string title)
//    {
//        return title + " " + firstName + " " + lastName;
//    }
//}





/*
6. Skapa ett objekt som representerar dig och dina föräldrar
Gör en instans av en person och ge den ditt för- och efternamn. 
Lägg även in dina föräldrars namn, kopplade till dig. 
Så t.ex myself.GetFullName() returnerar ditt namn, och myself.mother.GetFullName() returnerar din mammas namn.
 
 */


//Person mother = new Person() { firstName = "Gärd", lastName = "Olofsson" };
//Person father = new Person() { firstName = "Ernst", lastName = "Bok" };
//Person myself = new Person() { firstName = "Anna", lastName = "Svensson", mother = mother, father = father };

//Console.WriteLine(myself.GetFullName());
//Console.WriteLine(myself.mother.GetFullName());

//class Person
//{
//    public string title = "No title";
//    public string firstName = "Inget";
//    public string lastName = "Namn";
//    public Person mother;
//    public Person father;

//    public string GetFullName()
//    {
//        return firstName + " " + lastName;
//    }
//}



/*
 7.
 Hämta information om dig och dina föräldrar.
Lägg till en public string GetSelfAndParents() som returnerar en sträng på formatet "Ditt Namn - Mamma: Mammans Namn - Pappa: Pappans namn". 
Om mammans eller pappans namn saknas (null) markera det med "okänd" i strängen. 
Exempel: "Fredrik Johansson - Mamma: okänd - Pappa: Göran Johansson"
 */


//Person mother = new Person() { firstName = "Gärd", lastName = "Olofsson" };
//Person father = new Person() { firstName = "Ernst", lastName = "Bok" };
//Person myself = new Person() { firstName = "Anna", lastName = "Svensson", mother = mother, father = father };

//father.lastName = null;
//father.firstName = null;
//Console.WriteLine(myself.GetSelfAndParents());

//class Person
//{
//    public string title = "No title";
//    public string firstName = "Inget";
//    public string lastName = "Namn";
//    public Person mother;
//    public Person father;

//    public string GetFullName()
//    {
//        return firstName + " " + lastName;
//    }

//    public string GetSelfAndParents()
//    {
//        string mothersName = mother != null && mother.firstName != null && mother.lastName != null ? mother.GetFullName() : "okänd";
//        string fathersName = father != null && father.firstName != null && father.lastName != null ? father.GetFullName() : "okänd";

//        return $"{GetFullName()} - Mamma: {mothersName} - Pappa {fathersName}";
//    }
//}


/*
 8. Privat fält, med metoder för att sätta och hämta värdet.
Uppdatera klassen med ett fält, private double length, som kan lagra längden på personen. 
Eftersom denna är markerad som private kommer man inte kunna läsa/skriva denna utanför klassen. 
Lägg därför till en metod void SetLength(double length) som sätter värdet på det privat fältet length, 
samt en double GetLength() som returnerar värdet på fältet length.

När du är klar ska följande kod ge utskriften 1.82

Person myPerson = new Person();
myPerson.SetLength(1.82);
Console.Write(myPerson.GetLength());
/*
 8. Privat fält, med metoder för att sätta och hämta värdet.

 Steg för steg:
 1. Lägg till ett privat fält 'length' av typen double i klassen Person.
 2. Skriv en metod 'SetLength(double length)' som sätter värdet på det privata fältet.
 3. Skriv en metod 'GetLength()' som returnerar värdet på det privata fältet.
 4. Skapa en instans av Person.
 5. Anropa 'SetLength' med ett värde, t.ex. 1.82.
 6. Skriv ut resultatet av 'GetLength()' med Console.Write.
*/


//Person myself = new Person() { firstName = "Anna", lastName = "Svensson"};

//myself.SetLength(1.82);
//Console.WriteLine(myself.GetLength());

//class Person
//{
//    public string title = "No title";
//    public string firstName = "Inget";
//    public string lastName = "Namn";
//    private double length;

//    public string GetFullName()
//    {
//        return firstName + " " + lastName;
//    }

//    public void SetLength(double length)
//    {
//        this.length = length;
//    }

//    public double GetLength()
//    {
//        return this.length;
//    }
//}



/*
 9. Vikt och BMI
Gör motsvarande för Vikt, alltså ett privat fält med publika metoder: double GetWeight() och void SetWeight(double weight). 
Gör sedan även en publik metod double GetBMI() som returnerar personens BMI. 
Detta ska dock inte finnas representerat som en private field.
 */



//Person myself = new Person() { firstName = "Anna", lastName = "Svensson"};

//myself.SetLength(1.65);
//Console.WriteLine(myself.GetLength());

//myself.Setweight(68);
//myself.GetWeight();
//Console.WriteLine(myself.GetBMI());

//class Person
//{
//    public string title = "No title";
//    public string firstName = "Inget";
//    public string lastName = "Namn";
//    private double length = 0;
//    private double weight = 0;
//    public double bmi = 0;

//    public string GetFullName()
//    {
//        return firstName + " " + lastName;
//    }


//    public void SetLength(double length)
//    {
//        this.length = length;
//    }

//    public double GetLength()
//    {
//        return this.length;
//    }

//    public void Setweight(double weight)
//    {
//        this.weight = weight;
//    }

//    public double GetWeight()
//    {
//        return this.weight;
//    }

//    public double GetBMI()
//    {
//        bmi = this.weight / (this.length * this.length);
//        return bmi;
//    }
//}


