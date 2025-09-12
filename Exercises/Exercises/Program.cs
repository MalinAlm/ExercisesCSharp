// Exercises 

//1
/*
 Hälsa på användaren
Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.

Exempel:

Skriv ditt namn: David
Hej David!
 
 */

//Console.WriteLine("Skriv ditt namn");

//string name = Console.ReadLine();

//Console.WriteLine("Hej " + name + "!\n");


//2
/*
 Multiplicera två tal
Skriv ett program som ber användaren mata in två heltal. Skriv ut talen multiplicerade med varandra.

Exempel:

Skriv in första talet: 5
Skriv in andra talet: 12
5 * 12 = 60
 */

//Console.WriteLine("Skriv in två heltal\n");

//Console.WriteLine("Skriv in första talet:");
//int firstNumber = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Skriv in andra talet:");
//int secondNumber = Int32.Parse(Console.ReadLine());

//Console.WriteLine("\n" + firstNumber + " * " + secondNumber + " = " + firstNumber * secondNumber + "\n");


//3:1
/*
 Verifiera lösenord
Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett hemligt lösenord och spara det i en variabel. När användaren har skrivit in ett lösenord ska programmet jämföra med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.

Exempel:

Lösenord: abc123
Fel lösenord!
 */

//Console.WriteLine("Välj ett lösenord:");

//string savedPassword = Console.ReadLine();

//Console.WriteLine("Skriv in ditt lösenord");
//string password = Console.ReadLine();

//if (savedPassword != null)
//{
//    if (password == savedPassword)
//    {
//        Console.WriteLine("Rätt lösenord");
//    }
//    else
//    {
//        Console.WriteLine("Du har skrivit in fel lösenord!");
//    }

//}

//3:2

//string secretPassword = "1234";

//Console.WriteLine("Skriv ditt lösenord");

//string userInput = Console.ReadLine();

//if (userInput != secretPassword)
//{
//    Console.WriteLine("Wrong password!!");
//}
//else
//{
//    Console.WriteLine("Correct password");
//}


// 4
/*
 Jämför tal
Skriv ett program som frågar användaren efter ett tal. Det ska skriva ut om talet är mindre, större eller lika med 100.

Exempel:

Skriv ett tal: 45
Ditt tal är mindre än 100.
 */

//Console.WriteLine("Skriv in ett tal");

//int inputNumber = Int32.Parse(Console.ReadLine());


//if (inputNumber < 100)
//{
//    Console.WriteLine("Ditt tal är mindre än 100.");
//}
//else if (inputNumber > 100)
//{
//    Console.WriteLine("Ditt tal är större än 100");
//}
//else if (inputNumber == 100)
//{
//    Console.WriteLine("Ditt tal är 100");
//}


//5
/*
 Dubblera och halvera tal
Be användaren mata in ett tal. Skriv ut talet som är dubbelt, respektive hälften.

Exempel:

Skriv in ett tal: 5
10 är dubbelt så mycket som 5.
2.5 är hälften så mycket som 5.
 */

//Console.WriteLine("Skriv ett tal:");

//int inputNumber = Int32.Parse(Console.ReadLine());

//if (inputNumber != null)
//{
//    Console.WriteLine(inputNumber * 2 + " är dubbelt så mycket som " + inputNumber);
//    Console.WriteLine(inputNumber / 2.0 + " är hälften så mycket som " + inputNumber );
//}



//6
/*
 Miniräknare
Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, * eller /. Därefter ska ytterligare ett tal efterfrågas. Programmet ska fungera som en simpel miniräknare. Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut “3 * 5 = 15”.

Exempel:

Första talet: 7
Välj +, -, *, /: +
Andra talet: 2
7 + 2 = 9
 */

//Console.WriteLine("Skriv ett tal \n");

//int firstNumber = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Skriv ett tecken, +,-,*,/: \n");

//char mathSign = Console.ReadLine()[0];
//Console.WriteLine("Skriv ett tal\n");

//int lastNumber = Int32.Parse(Console.ReadLine());

//switch (mathSign)
//{
//    case '+':
//        Console.WriteLine(firstNumber + " + " + lastNumber + " = " + (firstNumber + lastNumber));
//        break;
//    case '-':
//        Console.WriteLine(firstNumber + " - " + lastNumber + " = " + (firstNumber - lastNumber));
//        break;
//    case '*':
//        Console.WriteLine(firstNumber + " * " + lastNumber + " = " + (firstNumber * lastNumber));
//        break;
//    case '/':
//        Console.WriteLine(firstNumber + " / " + lastNumber + " = " + (firstNumber / lastNumber));
//        break;

//}


// 7, ANVÄND WHILE LOOP, Används ofta när man vill se om någon skrivit in ett värde etc.
/*
 Summa och medelvärde
Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter). Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas. Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen.

Exempel:

Skriv in ett tal: 3
3
Skriv in ett tal: 2
5
Skriv in ett tal: 7
12
Skriv in ett tal:
Medelvärde: 4
 */

//Console.WriteLine("Skriv in ett nummer:");

//string inputNumber = Console.ReadLine();

//double number;
//double sum = 0;
//double amount = 0;

//while (double.TryParse(inputNumber, out number))
//{

//    sum = sum + number;
//    amount = amount + 1;
//    Console.WriteLine(sum);
//    Console.WriteLine("Skriv in ett nummer:");
//    inputNumber = Console.ReadLine();
//}
//while (!double.TryParse(inputNumber, out number))
//{
//    Console.WriteLine("Medelvärde:" + sum / amount);
//    break;
//}




// Exercises "Loopar"

// 1
/*
  Skriv talen 20 till 30
Skriv en loop som skriver ut alla tal från 20 till 30.

Exempel:

20
21
...
29
30
 */

//for (int number = 20; number <= 30; number++)
//{
//    Console.WriteLine(number);
//}


// 2
/*
 Jämna tal
Skriv en loop som skriver ut alla jämna tal från 0 till 30.

Exempel:

0
2
...
28
30
 */

//for (int number = 0; number <= 30; number++)
//{
//    if (number % 2 == 0)
//    {
//        Console.WriteLine(number);
//    }
//}

//3
/*
 Var tredje "Hej"
Skriv en loop som skriver ut tal från 0 till 30, men om talet är jämnt delbart med 3 skriv istället “Hej”

Exempel:

"Hej"
1
2
"Hej"
4
...
29
"Hej" 
*/

//for (int number = 0; number <= 30; number++)
//{
//    if (number % 3 == 0)
//    {
//        Console.WriteLine("Hej");
//    }
//    else
//    {
//        Console.WriteLine(number);
//    }
//}


// 4 
/*
 Gångertabell
Gör ett program som ber användaren mata in ett tal, skriv ut det talets “gångertabell” dvs, multiplikationer av talet med alla tal från 1 t.o.m. 10.

Exempel:

Skriv in ett tal: 4
1 * 4 = 4
2 * 4 = 8
...
10 * 4 = 40
 */


//Console.WriteLine("Skriv in ett tal och se dess gångertabell:");

//int number = Int32.Parse(Console.ReadLine());

//for (int multipliedWith = 0; multipliedWith <= 10; multipliedWith++)
//{
//    Console.WriteLine(number + " * " + multipliedWith + " = " + number * multipliedWith);
//}


//5
/*
 Summa
Summan av alla tal 1 till 4, är 10 (1+2+3+4). Gör ett program som räknar ut summan av alla tal 1 till 1000.
 */

//int sum = 0;

//for (int number = 0; number <= 1000; number++)
//{
//    sum = sum + number;

//    if (number == 1000)
//    {
//        Console.WriteLine(sum);
//    }
//}


//6
/*
 Riskorn på shackbräde
Enligt legenden så fick den man som hade konstruerat det formidabla spelet schack önska sig något värdefullt av den överförtjuste kungen. Monarken blev förvånad över uppfinnarens anspråkslöshet när gåvan skulle bestå av riskorn.

Antalet riskorn bestämdes enligt följande regel: ett korn skulle lämnas för första rutan på ett schackbräde, två korn för andra rutan, fyra för tredje, åtta för fjärde och så ändå till den sista rutan.

Skriv ett program som hjälper kungen att beräkna antalet riskorn på vardera ruta.

Exempel:

Ruta 1: 1
Ruta 2: 2
Ruta 3: 4
Ruta 4: 8
Ruta 5: 16
...
Ruta 64: ???
 */

//using System.Numerics;

//ulong riceGrains = 1;

//for (ulong square = 1; square <= 64; square++)
//{

//    if (square == 1)

//    {
//        Console.WriteLine(riceGrains);
//    }
//    else if (square > 1)
//    {
//        riceGrains = riceGrains * 2;
//        Console.WriteLine(riceGrains);
//    }

//}


//7 
/*
 Fylld box
Gör ett program som ber användaren mata in höjd och bredd. Printa ut en “box” med bokstaven X på skärmen med den höjd och bredd som matats in.

Exempel:

Mata in höjd: 3
Mata in bredd: 5
XXXXX
XXXXX
XXXXX
 */

//Console.WriteLine("Skriv in en höjd");
//int inputHeight = Int32.Parse( Console.ReadLine());
//Console.WriteLine("Skriv ín en bredd");
//int inputWidth = Int32.Parse( Console.ReadLine());

//for (int height = 0; height < inputHeight; height++)
//{

//    for (int width = 0; width < inputWidth; width++)
//    {
//        Console.Write("x");
//    }
//    Console.WriteLine();
//}


//8 
/*
 Samma som uppgift 7, men för varannan kolumn skrivs bokstaven O istället för X.

Exempel:

Mata in höjd: 3
Mata in bredd: 5
XOXOX
XOXOX
XOXOX
 */


//Console.WriteLine("Skriv in en höjd");
//int inputHeight = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Skriv ín en bredd");
//int inputWidth = Int32.Parse(Console.ReadLine());

//for (int height = 0; height < inputHeight; height++)
//{

//    for (int width = 0; width < inputWidth; width++)
//    {

//        if (width % 2 == 0)
//        {
//            Console.Write('o');
//        }
//        else
//        {
//            Console.Write("x");

//        }
//    }
//    Console.WriteLine();
//}


//9 
/*
 Rutig box
Samma som uppgift 8, men med ett schackrutemönster.

Exempel:

Mata in höjd: 3
Mata in bredd: 5
XOXOX
OXOXO
XOXOX
 */

//Console.WriteLine("Skriv in en höjd");
//int inputHeight = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Skriv ín en bredd");
//int inputWidth = Int32.Parse(Console.ReadLine());

//for (int height = 0; height < inputHeight; height++)
//{

//    for (int width = 0; width < inputWidth; width++)
//    {

//        int total = width + height;

//            if (total % 2 == 0)
//            { 

//            Console.Write('o');
//            }
//            else 
//            {
//            Console.Write("x");
//            }

//        }


//    Console.WriteLine();
//}


//10  
/*
  Ihålig box
Fråga efter bredd och höjd och skriv ut en “box” som inte är fylld.

Exempel:

Mata in höjd: 4
Mata in bredd: 5
XXXXX
X   X
X   X
XXXXX
 */

//Console.WriteLine("Skriv in en höjd");
//int inputHeight = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Skriv ín en bredd");
//int inputWidth = Int32.Parse(Console.ReadLine());

//for (int height = 0; height < inputHeight; height++)
//{

//    for (int width = 0; width < inputWidth; width++)
//    {

//        int total = width + height;

//        if (height == 0 || height == inputHeight -1 || width == 0 || width == inputWidth -1)
//        {

//            Console.Write('x');
//        }
//        else
//        {
//            Console.Write(" ");
//        }

//    }


//    Console.WriteLine();
//}



//11 
/*
 Sifferpyramid
Gör ett program som skriver “1” på första raden, “12” på nästa, sen “123” osv upp till rad 9 där det står “123456789”

Exempel:

1
12
123
...
123456789
 */


//for (int height = 1; height <= 10; height++)
//{

//    for (int width = 1; width < height; width++)
//    {
//        Console.Write(width);

//    }
//    Console.WriteLine();

//}



//12. Nio sifferpyramider
/*
 Nio sifferpyramider
Gör ett program som skriver ut “pyramider” som i uppgiften ovan, den första ska vara med en rad, följt av en pyramid med 2 rader, sen 3 rader etc. ända upp till 9 rader i den sista pyramiden.

Exempel:

1

1
12

1
12
123

...
12345678
123456789
 */

//for (int height = 1; height <= 10; height++)
//{

//    for (int width = 1; width < height; width++)
//    {

//        for (int pyramide = 1; pyramide < width; pyramide++)
//        {
//            Console.Write(pyramide);
//        }
//        Console.Write(width);
//        Console.WriteLine();

//    }
//    Console.WriteLine();

//}

//13 Primtal
//Primtal är heltal större än 1 som inte går att jämnt dela med något annat heltal (förutom 1 eller talet själv, eftersom alla tal är delbara med sig själva och 1). De 5 första primtalen är 2, 3, 5, 7, 11. Skriv ett program som listar de första 20 primtalen.
//Modulus/rest  %  kan användas för att se om ett tal är delbart med ett annat

//bool isPrimeNumber = true;
//Console.WriteLine("Prime numbers:");
//for (int primeNumber = 2; primeNumber <= 71; primeNumber++)
//{
//    for (int i = 2; i <= 71; i++)
//    {
//        if (primeNumber != i && primeNumber % i == 0)
//        {
//            isPrimeNumber = false;
//        }
//    }

//    if (isPrimeNumber)
//    {
//        Console.WriteLine(primeNumber);
//    }
//    isPrimeNumber = true;
//}


// 14
/*
 
Spel - Gissa tal
Gör ett gissa-spel som har ett hemligt nummer (lagrat i en variabel i koden) mellan 1 och 100. När spelet startar ombeds spelaren att gissa ett tal mellan 1-100. Gissar man för lågt skriver programmet ut att man gissat för lågt, och man får gissa igen. Gissar man för högt skriver programmet att man gissat för högt och man får gissa igen. Gissar man rätt så skriver programmet att man gissat rätt, samt antal gissningar som krävdes för att gissa rätt.

Extrauppgift: Klassen “Random” i .NET kan användas för att sätta den hemliga variabeln till ett slumpmässigt tal 1-100. Googla “C# Random” och se om du får det att fungera så det blir olika tal varje gång man kör programmet.

Extrauppgift 2: Gör så att datorn själv (automatiskt) spelar spelet, och gissar tal. Skriv ut output precis som innan så man kan följa hur den spelat. Försök få den att lösa det så effektivt (så få drag) som möjligt.
 
 */

//int secretNumber = 62;

//int numberOfGuesses = 1;

//Console.WriteLine("Guess the number between 1-100:");
//int guessedNumber = Int32.Parse(Console.ReadLine());

//while (guessedNumber != secretNumber)
//{

//    if (guessedNumber < secretNumber)
//    {
//        numberOfGuesses++;
//        Console.WriteLine("Du har gissat för lågt");
//        Console.WriteLine("Gissa igen:");
//        guessedNumber = Int32.Parse(Console.ReadLine());
//    }
//    else if (guessedNumber > secretNumber)
//    {
//        numberOfGuesses++;
//        Console.WriteLine("Du har gissat för högt");
//        Console.WriteLine("Gissa igen:");
//        guessedNumber = Int32.Parse(Console.ReadLine());
//    }
//}


//if (guessedNumber == secretNumber)
//{

//    Console.WriteLine("Du gissade rätt :D");
//    Console.WriteLine("Det krävdes " + numberOfGuesses + " gissningar");

//}

//14 b)
/*
 Extrauppgift: Klassen “Random” i .NET kan användas för att sätta den hemliga variabeln till ett slumpmässigt tal 1-100. Googla “C# Random” och se om du får det att fungera så det blir olika tal varje gång man kör programmet.

 */

//int secretNumber = 62;

//int numberOfGuesses = 1;

//var random = new Random();
//int randomNumber = random.Next(1, 101);
//Console.WriteLine(randomNumber);

//Console.WriteLine("Guess the number between 1-100:");
//int guessedNumber = Int32.Parse(Console.ReadLine());

//while (guessedNumber != randomNumber)
//{

//    if (guessedNumber < randomNumber)
//    {
//        numberOfGuesses++;
//        Console.WriteLine();
//        Console.WriteLine("Du har gissat för lågt");
//        Console.WriteLine();
//        Console.WriteLine("Gissa igen:");
//        guessedNumber = Int32.Parse(Console.ReadLine());
//    }
//    else if (guessedNumber > randomNumber)
//    {
//        numberOfGuesses++;
//        Console.WriteLine();
//        Console.WriteLine("Du har gissat för högt");
//        Console.WriteLine();
//        Console.WriteLine("Gissa igen:");
//        guessedNumber = Int32.Parse(Console.ReadLine());
//    }
//}

//    Console.WriteLine();
//    Console.WriteLine("Du gissade rätt :D");
//    Console.WriteLine("Det krävdes " + numberOfGuesses + " gissningar");


// 14 c)
/*
 Extrauppgift 2: Gör så att datorn själv (automatiskt) spelar spelet, och gissar tal. Skriv ut output precis som innan så man kan följa hur den spelat. Försök få den att lösa det så effektivt (så få drag) som möjligt.

 */


//int numberOfGuesses = 1;

//int min = 0;
//int max = 100;

//var random = new Random();
//int randomNumber = random.Next(1, 101);
//Console.WriteLine(randomNumber);

//Console.WriteLine("Guess the number between 1-100:");
//Console.WriteLine();

//int guessedNumber = (min + max) / 2;

//while (guessedNumber != randomNumber)
//{

//    if (guessedNumber < randomNumber)
//    {

//        min = guessedNumber +1;
//        Console.WriteLine("Datorn gissade: " + guessedNumber);

//        guessedNumber = (min + max) / 2;

//        numberOfGuesses++;

//        Console.WriteLine("Du har gissat för lågt");
//        Console.WriteLine();

//    }
//    else if (guessedNumber > randomNumber)
//    {

//        max = guessedNumber -1;
//        Console.WriteLine("Datorn gissade: " + guessedNumber);

//        guessedNumber = (min + max) / 2;

//        numberOfGuesses++;

//        Console.WriteLine("Du har gissat för högt");
//        Console.WriteLine();

//    }
//}

//    Console.WriteLine();
//    Console.WriteLine("Du gissade rätt :D " + guessedNumber);
//    Console.WriteLine("Det krävdes " + numberOfGuesses + " gissningar");


//15 
/*
Sten, sax, påse
Skriv ett sten-sax-påse spel. Användaren skriver in “sten”, “sax” eller “påse”. Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omgången. Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något). Skriv även ut poäng.
 */

//Console.WriteLine("Sten Sax Påse. Gör ditt val:");
//Console.WriteLine();

//int userPoint = 0;
//int computerPoint = 0;
//int tie = 0;

//string userChoice = Console.ReadLine().ToLower();

//var random = new Random();
//string[] computerChoice = new String[3] { "sten", "sax", "påse" };

//int computerChoiceIndex = random.Next(computerChoice.Length);
//Console.WriteLine($"Computer's choice {computerChoice[computerChoiceIndex]}" );


//while (userChoice != "")
//{

//    //User point
//    if (userChoice == "sten" && computerChoice[computerChoiceIndex] == "sax")
//    {
//        userPoint++;
//        Console.WriteLine("\nGrattis! Du vann denna omgången\n");
//    }

//    else if (userChoice == "sax" && computerChoice[computerChoiceIndex] == "påse")
//    {
//        userPoint++;
//        Console.WriteLine("\nGrattis! Du vann denna omgången\n");

//    }

//    else if (userChoice == "påse" && computerChoice[computerChoiceIndex] == "sten")
//    {
//        userPoint++;
//        Console.WriteLine("\nGrattis! Du vann denna omgången\n");

//    }

//    // Computer point
//    else if (userChoice == "sten" && computerChoice[computerChoiceIndex] == "påse")
//    {
//        computerPoint++;
//        Console.WriteLine("\nAttans! Datorn vann denna omgången\n");

//    }

//    else if (userChoice == "sax" && computerChoice[computerChoiceIndex] == "sten")
//    {
//        computerPoint++;
//        Console.WriteLine("\nAttans! Datorn vann denna omgången\n");

//    }

//    else if (userChoice == "påse" && computerChoice[computerChoiceIndex] == "sax")
//    {
//        computerPoint++;
//        Console.WriteLine("\nAttans! Datorn vann denna omgången\n");

//    }

//    //Tie
//    else if (userChoice == computerChoice[computerChoiceIndex])
//    {
//        tie++;
//        Console.WriteLine("\nAttans! Det blev oavgjort denna omgången\n");

//    }

//    Console.WriteLine("Gör ditt val:");
//    userChoice = Console.ReadLine().ToLower();

//    if (userChoice == "")
//    { 
//        if (userPoint > computerPoint)
//        {
//            Console.WriteLine("Grattis!! Du vann med " + userPoint + " - " + computerPoint);
//        }
//        else if (userPoint < computerPoint)
//        {
//            Console.WriteLine("Åh typiskt!! Datorn vann med " + computerPoint + " - " + userPoint);

//        }
//        else
//        {
//            Console.WriteLine("Åh nej!! Det blev oavgjort! Ni fick båda " + tie + " poäng" );

//        }
//        break; 
//    }


//    computerChoiceIndex = random.Next(computerChoice.Length);
//    Console.WriteLine($"Computer's choice {computerChoice[computerChoiceIndex]}");
//}



// INEDXERING

//1 En bokstav på varje rad
//Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad.

//Console.WriteLine("Skriv in ett ord");
//string wordInput = Console.ReadLine();

//foreach (var letter in wordInput)
//{
//    Console.WriteLine(letter);
//}


//2 . Siffror till text
//Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”. Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.


//Console.WriteLine("Skriv in en siffra 0-9:\n");
//int number = Int32.Parse(Console.ReadLine());

//string[] numbers = new string[10] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

//switch (number)
//{
//    case 0:
//        Console.WriteLine(numbers[0]);
//        break;
//    case 1:
//        Console.WriteLine(numbers[1]);  
//        break;
//    case 2:
//        Console.WriteLine(numbers[2]);
//        break;
//    case 3: 
//        Console.WriteLine(numbers[3]);
//        break;
//    case 4:
//        Console.WriteLine(numbers[4]);
//        break;
//    case 5:
//        Console.WriteLine(numbers[5]);
//        break;
//    case 6:
//        Console.WriteLine(numbers[6]);
//        break;
//    case 7:
//        Console.WriteLine(numbers[7]);
//        break;
//    case 8:
//        Console.WriteLine(numbers[8]);
//        break;
//    case 9:
//        Console.WriteLine(numbers[9]);
//        break;
//    default:
//        Console.WriteLine("Du har inte skrivit in ett nummer mellan 0-9");
//            break;
//}

//3 // funktioner märkta med static har inte åtkomst till objekt deklarerade utanför funktionen
//tillsvidare, använd sratic till alla funkrioner för att få in tänket att funktioner fungerar
////isolerat/ fristående från aannan kod

//Console.WriteLine("Skriv en text");
//string userInput = Console.ReadLine();
//char[] charArray = userInput.ToCharArray();
//Array.Reverse(charArray);


// Console.Write(charArray);


//4  Dölj vokaler
//Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

//Console.WriteLine("Skriv in en text:\n");
//string userInput = Console.ReadLine();
//char[] charArray = userInput.ToCharArray();

//string vowels = "aouåieyäö";
//char[] vowelsArray = vowels.ToCharArray();

//foreach (char letter in charArray)
//{
//    if (vowelsArray.Contains(letter))
//    {
//        Console.Write("*");
//    }
//    else
//    {
//        Console.Write(letter);
//    }

//}


// 5 
/*
 5. Palindrom
Ett palindrom är ett ord som blir samma framlänges som baklänges. Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.

Exempel:

Skriv ett ord: Kajak
Kajak är ett palindrom.
 */

//Console.WriteLine("skriv in ett ord: ");
//string userInput = Console.ReadLine();
//string userInputCompare = userInput;
//char[] userInputCompareArray = userInputCompare.ToCharArray();

//char[] inputCharArray = userInput.ToCharArray();
//Array.Reverse(inputCharArray);

//string input = new string(inputCharArray);
//string compare = new string(userInputCompareArray);

//if (input == compare)
//{

//    Console.WriteLine( input + " är ett palindrom");
//}
//else
//{
//    Console.WriteLine(compare + " är inte ett palindrom");
//}


//// Mer clean Lösning
//Console.WriteLine("skriv in ett ord: ");
//string userInput = Console.ReadLine();

//char[] inputCharArray = userInput.ToCharArray();
//Array.Reverse(inputCharArray);

//string reversedString = new string(inputCharArray);

//if (reversedString == userInput)
//{

//    Console.WriteLine(userInput + " är ett palindrom");
//}
//else
//{
//    Console.WriteLine(userInput + " är inte ett palindrom");
//}


//6
/*
 Miniräknare
Skapa en enkel miniräknare som kan hantera de fyra räknesätten med två operander. Till skillnad från uppgift 6 i övningsuppgifter med variabler, så ska inmatningen nu ske på en rad (första talet, operator, andra talet). Ignorera inmatade mellanslag i strängen. Om man t.ex. matar in strängen "34 - 14", så ska programmet skriva ut "= 20".

Exempel:

Vad vill du räkna ut? 15 * 4
= 60
 */

//Console.WriteLine("Skriv ett tal, ett tecken (+, -, *, /), och ett till tal \n");

//string userInput = Console.ReadLine();
//userInput = userInput.Replace(" ", "");


//char[] operators = new char[4] { '+', '-', '*', '/' };

//string firstNumber = "";
//string secondNumber = "";
//char choosenSign = ' ';

//foreach (char operatorSign in operators)
//    {
//     int operatorIndex = userInput.IndexOf(operatorSign);

//     if (operatorIndex >= 0)
//     {
//         choosenSign = operatorSign;

//         firstNumber = userInput.Substring(0, operatorIndex);
//         secondNumber = userInput.Substring(operatorIndex + 1);

//         break;
//     }

//}
//double numberOne = double.Parse(firstNumber);
//double numberTwo = double.Parse(secondNumber);


//double result = 0;

//switch (choosenSign)
//{
//    case '+':
//       result = numberOne + numberTwo;  
//         break;
//    case '-':
//       result =  numberOne - numberTwo;
//         break;
//    case '*':
//      result =  numberOne * numberTwo;
//         break;
//    case '/':
//        result = numberOne / numberTwo;
//        break;
//     default:
//        break;
//}

//Console.WriteLine(result);

//CLEANER CODE BELOW

//Console.WriteLine("Skriv ett tal, ett tecken (+, -, *, /), och ett till tal:");
//string userInput = Console.ReadLine().Replace(" ", "");

//char[] operators = { '+', '-', '*', '/' };

//int operatorIndex = userInput.IndexOfAny(operators);
//if (operatorIndex == -1)
//{
//    Console.WriteLine("Ingen giltig operator hittades.");
//    return;
//}

//char operatorSign = userInput[operatorIndex];

//double numberOne = double.Parse(userInput.Substring(0, operatorIndex));
//double numberTwo = double.Parse(userInput.Substring(operatorIndex + 1));

//double result = operatorSign switch
//{
//    '+' => numberOne + numberTwo,
//    '-' => numberOne - numberTwo,
//    '*' => numberOne * numberTwo,
//    '/' => numberOne / numberTwo,
//    _ => 0
//};

//Console.WriteLine(result);  


//7
/*
Omvänd ordning
Be användaren skriva in ett ord, sedan ett till, och ett till; tills man skrivit in 7 ord. 
Skriv sedan ut orden på skärmen i bakvänd ordning mot hur de matades in. Alltså ordet man skrev in sist, skrivs ut först.
 */

//string[] strings = new string[7] { "", "", "", "", "", "", "" };
//string userInput = "";

//for (int i = 6; i < strings.Length; i--)
//{
//    Console.WriteLine("skriv in en sträng");
//    userInput = Console.ReadLine();
//    strings[i] = userInput;

//    if (i == 0)
//    {
//        foreach (var item in strings)
//    {
//        Console.WriteLine(item);
//    }
//        break;
//    }

//}

//8
/*
  Fördröjd utskrift
Skapa ett program som ber användaren att skriva in ett ord. Sedan ett till, och ett till i all evighet. 
Varje gång man skrivit in ett ord så ska programmet skriva ut det ord man skrev 10 inmatningar tidigare. 
Men om man inte skrivit in 10 ord än så kan den istället skriva just det: 
“Du har inte skrivit in 10 ord än.”
 */

//Note to self
//be användaren skriva in ett ord
//"evighets loop" while loop
//skapa en array/ lista
//spara userInput i en array/lista
//Om array.Length >= 10 : skriv ut det ord man skrev 10 inmatningar tidigare
//Annars om array.Length < 10: skriv ut "du har inte skrivit 10 ord än"

//var stringsList = new List<string>();

//while (true)
//{
//	Console.WriteLine("Skriv in ett ord");
//	string userInput = Console.ReadLine();
//	stringsList.Add(userInput);

//	if (stringsList.Count >= 10)
//	{
//		string oldWord = stringsList[stringsList.Count - 10];
//		Console.WriteLine($"Ordet du skrev för 10 inmatningar sen var: {oldWord}");
//	}
//	else
//	{
//		Console.WriteLine("Du har inte skrivit 10 ord");
//	}
//}


//9
/*
 Bokstavspyramid
Skapa ett program som skriver ut första tecknet i "Hello World" på första raden, de 2 första tecknen på andra raden osv.

Exempel:

H
He
Hel
...
Hello Worl
Hello World
 */

//string helloWorld = "Hello World";
//char[] charFromString = helloWorld.ToCharArray();
//string oldLetters = "";

//	for (int i = 0; i < charFromString.Length; i++)
//	{
//		oldLetters = oldLetters + charFromString[i];
//		Console.Write(oldLetters + "\n\n");
//	}

//10

/*
 Färgade bokstäver
Man kan byta färg som används för utskrift i console med hjälp av Console.ForegroundColor (t.ex Console.ForegroundColor = ConsoleColor.Red)

Skapa ett program som ber användaren mata in en text. Be sedan användaren mata in en bokstav. Skriv ut strängen som matades in; de bokstäver som är samma som den användaren valde ska skriva ut med röd färg, alla andra med grå..

Exempel:

Mata in en text: Hejsan hoppsan!
Välj en bokstav: s
Hejsan hoppsan!

OBS! Färgkodning i markdown verkar inte visas på GitHub. Check ut och visa denna filen i visual studio eller visual studio code istället!
 */

//TODO

//be användaren skriva in en text
//be användaren skriva in en bokstav
//Jämför bokstaven med strängen
//de bokstäver som matchar i strängen ska vara röda, resten ska vara grå

//Console.WriteLine("Skriv en text");

//string userInput = Console.ReadLine();
//char[] inputCharArray = userInput.ToCharArray();

//Console.WriteLine("Skriv in en bokstav");

//string userLetterInput = Console.ReadLine();
//char[] letterChar = userLetterInput.ToCharArray();

//if (userInput.Contains(userLetterInput))
//{
//    foreach (char chr in inputCharArray)
//    {
//        if (chr == letterChar[0])
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.Write(chr);

//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Gray;
//        Console.Write(chr);

//        }
//        Console.ResetColor();
//    }
//}

//Bättre lösning


//Console.WriteLine("Skriv en text");

//string userInput = Console.ReadLine();
//char[] inputCharArray = userInput.ToCharArray();

//Console.WriteLine("Skriv in en bokstav");

//string userLetterInput = Console.ReadLine();

//    foreach (char chr in inputCharArray)
//    {
//        if (chr == userLetterInput[0])
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.Write(chr);

//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Gray;
//            Console.Write(chr);

//        }
//        Console.ResetColor();
//    }

//11
/*
 Start & Stop
Be användaren mata in en text. Be sedan om ett startindex, och sedan om ett stopindex. Skriv ut hela texten, men alla tecken från startindex till stopindex ska vara röda.

Exempel:

Mata in en text: Detta är en text
Välj startindex: 3
Välj stopindex: 9
Detta är en text
 */

//skriv ut texten
// alla tecken från startindex-stopindex ska vara röda


//Console.WriteLine("Skriv in en text: ");
//string userInput = Console.ReadLine();
//char[] inputCharArray = userInput.ToCharArray();

//Console.WriteLine("\n\nVälj ett startindex (en lägre siffra): ");
//int startIndex = Int32.Parse(Console.ReadLine());

//Console.WriteLine("\n\nVälj ett stopindex (en högre siffra): ");
//int stopIndex = Int32.Parse(Console.ReadLine());

//for (int index = 0; index < inputCharArray.Length; index++)
//{
//    if (index >= startIndex && index <= stopIndex)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.Write(inputCharArray[index]);
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Gray;
//        Console.Write(inputCharArray[index]);
//    }
//    Console.ResetColor();
//}

// 12

/*
 Växla färg
Be användaren mata in en text. Be sedan användaren mata in en bokstav. 
Skriv ut hela texten, rödmarkera från första stället den hittar bokstaven till andra stället den hittar bokstaven, från tredje stället till fjärde o.s.v.

Exempel:

Mata in text: How much wood would a woodchuck chuck if a woodchuck could chuck wood?
Välj bokstav: o

How much wood would a woodchuck chuck if a woodchuck could chuck wood?
 */

//Console.WriteLine("Mata in en text: ");
//string textInput = Console.ReadLine();
//char[] textArray = textInput.ToCharArray();

//Console.WriteLine("Mata in en bokstav: ");
//string charInput = Console.ReadLine();
//bool redMarking = false;


//    for (int index = 0; index < textArray.Length; index++)
//    {

//        if (textArray[index] == charInput[0])
//        {
//            redMarking = !redMarking;
//        }

//        Console.ForegroundColor = redMarking ? ConsoleColor.Red : ConsoleColor.Gray;

//        Console.Write(textArray[index]);

//        Console.ResetColor();
//    }


// FUNKTIONER

//1
/*
 Slå ihop för- och efternamn - skriv ut
Skriv en funktion som tar två parametrar: firstName och lastName. 
Funktionen ska skriva ut hela namnet på skärmen. Testa genom att anropa funktionen med ditt namn.

Exempel:

PrintName("Fredrik", "Johansson");
Skriver ut: Fredrik Johansson
 */


//static void FullNameFunction(string firstName, string LastName)
//{
//    Console.WriteLine(firstName + " " + LastName);
//}

//FullNameFunction("Malin", "Almqvist");


//2
/*
 Slå ihop för- och efternamn - returnera
Skriv om funktionen ovan så att den istället för att skriva ut namnet returnerar en string med hela namnet. 
Anropa funktionen och skriv ut returvärdet.
 */


//static string FullNameFunction(string firstName, string lastName)
//{
//   string fullName = firstName + " " + lastName;
//    return fullName;
//}

//Console.WriteLine(FullNameFunction("Anna", "Panna")); 


//3
/*
  Kolla om stängen är längre än ett givet antal tecken.
Skriv en funktion som tar in en sträng och ett heltal. 
Om längden på strängen är större än heltalet returnera true, annars false.
 */

//static bool LengthFunction(string word, int count)
//{
//			return word.Length > count;
//}

//Console.WriteLine(LengthFunction("hejsan", 2)); 


//4
/*
 Omvandla Celsius till Fahrenheit
Skriv en funktion som översätter ett värde från Celsius till Fahrenheit. 
Både in-parameter och returvärde ska vara av datatyp double.
 */

//static double TemperatureFunction(double celcius)
//{
//    double farenheit = (celcius * 9) / 5 + 32;
//    return farenheit;
//}

//TemperatureFunction(-2);

//5
/*
 Lägg in bindesträck mellan tecken i en sträng
Skriv en funktion som tar in en sträng och returnerar en sträng med ett bindestreck mellan varje tecken.
T.ex om man skickar in “Fredrik” , så returnerar den “F-r-e-d-r-i-k”
 */

//static string NameFunction(string name)
//{   
//    string sign = "-";
//    string result = "";

//    for (int i = 0; i < name.Length; i++)
//    {
//        result = result + name[i];

//        if (i < name.Length -1)
//        {
//            result = result + sign;
//        }

//    }
//    return result;
//        }

//för att skriv ut resultatet som returneras, skapa en variabel för anropet av funktionen
//och använd det senare i tex en Console.WriteLine
//string output = NameFunction("Malin");
//Console.WriteLine(output);


//6
/*
  Egen version av String.Join();
Skriv en egen funktion som fungerar på samma sätt som String.Join();

Exempel:

MyJoin("->", "Sverige", "Norge", "Finland");
Returvärde: "Sverige->Norge->Finland"
 */

//Skapa en funktion
//Testa String.Join
//Skriv en egen funktion som motsvarar String.Join


//static string MyJoin( string separator, params string[] theStrings)
//{
//    string result = "";

//    for (int index = 0; index < theStrings.Length; index++)
//    {
//        result = result + theStrings[index];

//        if (index < theStrings.Length - 1 )
//        {
//            result = result + separator;
//        }
//    }
//    return result;
//}

//string finishedString = MyJoin("->", "Sverige", "Norge", "Finland");
//Console.WriteLine(finishedString);

//Nedan används String.Join. Ovan är min egna funktion som gör samma sak
//static string MyJoinFunction(string arrow, string sweden, string norway, string finland)
//{
//    string result = String.Join(arrow, sweden, norway, finland);
//    Console.WriteLine(String.Join(result));

//    return result;
//}

//string joinedString = MyJoinFunction("->", "Sverige", "Norge", "Finland");
////Console.WriteLine(joinedString);


//7
/*
 Beräkna medelvärde av int-array
Skriv en funktion som tar en int[] in, och returnerar medelvärdet som en double.
 */

//static double AverageValue(params double[] numbers)
//{

//    double calculation = 0;

//    for (int i = 0; i < numbers.Length; i++)
//    {
//        calculation = calculation + numbers[i];
//    }
//    Console.WriteLine(calculation/ numbers.Length);
//    return calculation / numbers.Length;
//}

//AverageValue(1, 4, 5, 7, 8, 54, 32, 2);


//8
/*
 Siffror till text
Skriv en funktion som tar ett heltal in, och returnerar en string[] 
där varje element innehåller ordet för varje siffra i talet.

Exempel:

NumberToWords(6543);
Returvärde: {"sex", "fem", "fyra", "tre"}
 */

static string[] NumberToWords(int number)
{
    string[] stringNumbers = new string[10] { "noll","ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
    string numberString = number.ToString();
    string[] result = new string[numberString.Length];

    for (int i = 0; i < numberString.Length; i++)
    {
        int digit = numberString[i] - '0';
        string convertedNumber = stringNumbers[digit];
        result[i] = convertedNumber;
    }

    return result;
}

string[] words = NumberToWords(456863990);
Console.WriteLine(string.Join(", ", words));

