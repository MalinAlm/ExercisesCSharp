
/* Förberedelseövningar - Labb 1 */

//1
/*
 Bokstav för bokstav - fram till space
Utgå från strängen (skapa en variabel med) "Hello World!", 
skriv ut hela strängen bokstav för bokstav, men avsluta när det kommer ett space. 
(Den ska alltså bara skriva “Hello”).
 */

//string text = "Hello World!";

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == ' ')
//    {
//        break;    
//        }
//    Console.Write(text[i]);
//}

//2
/*
 Bokstav för bokstav - radbyte på space
Utgå från strängen "This is just some other text". 
Skriv ut strängen bokstav för bokstav, men när det kommer ett space, gör radbyte istället. 
(Du ska få ett ord på varje rad).
 */
//string text = "This is just some other text";

//for (int i = 0; i < text.Length; i++)
//{

//    if (text[i] == ' ')
//    {
//        Console.WriteLine("\n");
//    }
//    else
//    {
//        Console.Write(text[i]);
//    }
//}


//3
/*
 Bokstav för bokstav - varannan stjärna
Utgå från strängen "Detta är uppgift 3". Skriv ut bokstav för bokstav. 
Men om index är en jämn siffra, skriv istället ut *
 */

//string text = "Detta är uppgift 3";

//for (int i = 0; i < text.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.Write("*");
//    }
//    else
//    {
//        Console.Write(text[i]);
//    }
//}

//4
/*
 Bokstav för bokstav - gröna o, röda l
Utgå från strängen "Hello world!". Skriv ut bokstav för bokstav. 
Alla 'o' ska vara grön färg, alla 'l' ska vara röd färg. 
Övriga bokstäver är vita/grå.
 */

//string text = "Hello world!";

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == 'o')
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.Write(text[i]);
//    }
//    else if (text[i] == 'l')
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.Write(text[i]);

//    }
//    else
//    {

//        Console.Write(text[i]);
//        Console.ResetColor();
//    }
//}

//5
/*
Bokstav för bokstav - dubbla med grön färg
Utgå från strängen "Hello world". Skriv ut bokstav för bokstav. 
Om två tecken på rad är samma så ska dessa vara grön färg. 
Övriga bokstäver är vita/grå.
 */

//bool greenMarking = false;
//string text = "Hello worldde";

//for (int i = 0; i < text.Length; i++)
//{
//        if (i < text.Length - 1 && text[i] == text[i + 1])
//        {
//            greenMarking = true;
//        }
//        else if (i > 0 && text[i] == text[i - 1])
//        {
//            greenMarking = true;
//        }
//        else
//        {
//            greenMarking = false;
//        }

//        Console.ForegroundColor = greenMarking ? ConsoleColor.Green : ConsoleColor.Gray;
//        Console.WriteLine(text[i]);
//        Console.ResetColor();
//}

//6
/*
 Bokstav för bokstav - grön substring
Utgå från strängen "How much wood would a woodchuck chuck if a woodchuck could chuck wood?", 
samt den mindre strängen "oo". Skriv ut den långa strängen bokstav för bokstav. 
Varje gång den mindre strängen förekommer (två 'o' på raken) så ska dessa vara med grön färg. 
Övriga bokstäver är vita/grå.
 */

//static void ColorLettersFunction(string text, string letters)
//{
//    bool greenMarking = false;
//    int remainingGreenCount = 0;

//    for (int i = 0; i < text.Length; i++)
//    {

//        if (i <= text.Length - 2)
//        {
//        string letterCombo = text.Substring(i,2);

//            if (letterCombo == letters)
//            {
//                remainingGreenCount = letters.Length;

//                greenMarking = remainingGreenCount > 0;


//            }

//            if (remainingGreenCount > 0)
//            {
//                remainingGreenCount--;
//            }
//            else
//            {
//                greenMarking = false;
//            }
//        }
//        Console.ForegroundColor = greenMarking ? ConsoleColor.Green : ConsoleColor.Gray;
//        Console.Write(text[i]);

//        Console.ResetColor();
//    }
//}

//ColorLettersFunction("How much wood would a woodchuck chuck if a woodchuck could chuck wood?", "oo");



//7
/*
  Bokstav för bokstav - grön substring 2
Samma som uppgift 6, men den mindre strängen är "chuck" istället för "oo".
D.v.s. alla gånger "chuck" förekommer i den längre strängen skrivs dessa med grön text.
 */

//static void ColorLettersFunction(string text, string word)
//{
//    bool greenMarking = false;
//    int remainingGreenCount = 0;

//    for (int i = 0; i < text.Length; i++)
//    {

//        if (i <= text.Length - 5)
//        {
//            string letterCombo = text.Substring(i, 5);

//            if (letterCombo == word)
//            {
//                remainingGreenCount = word.Length;

//                greenMarking = remainingGreenCount > 0;


//            }

//            if (remainingGreenCount > 0)
//            {
//                remainingGreenCount--;
//            }
//            else
//            {
//                greenMarking = false;
//            }
//        }
//        Console.ForegroundColor = greenMarking ? ConsoleColor.Green : ConsoleColor.Gray;
//        Console.Write(text[i]);

//        Console.ResetColor();
//    }
//}

//ColorLettersFunction("How much wood would a woodchuck chuck if a woodchuck could chuck wood?", "chuck");



//8
/*
 Bokstav för bokstav - grön substring 3
Samma som uppgift 6 igen, men denna gången kan användaren mata in den kortare strängen, 
alltså valfri text som ska sökas (färgas grön) i den längre texten.
 */

//Console.WriteLine("skriv in ett valfritt ord från följande sträng");
//Console.WriteLine("How much wood would a woodchuck chuck if a woodchuck could chuck wood?");
//string userWordInput = Console.ReadLine();

//static void ColorLettersFunction(string text, string word)
//{
//    bool greenMarking = false;
//    int remainingGreenCount = 0;

//    for (int i = 0; i < text.Length; i++)
//    {

//        if (i <= text.Length - word.Length)
//        {
//            string letterCombo = text.Substring(i, word.Length);

//            if (letterCombo == word)
//            {
//                remainingGreenCount = word.Length;

//                greenMarking = remainingGreenCount > 0;
//            }

//            if (remainingGreenCount > 0)
//            {
//                remainingGreenCount--;
//            }
//            else
//            {
//                greenMarking = false;
//            }
//        }
//        Console.ForegroundColor = greenMarking ? ConsoleColor.Green : ConsoleColor.Gray;
//        Console.Write(text[i]);

//        Console.ResetColor();
//    }
//}

//ColorLettersFunction("How much wood would a woodchuck chuck if a woodchuck could chuck wood?", userWordInput);



//9
/*
 Bokstavspyramid
Utgå från strängen "Hello world!". 
Gör ett program som skriver ut första bokstaven en gång på första raden. 
Andra bokstaven 2 gånger på andra raden. Tredje 3 gånger på nästa rad osv. 

Alltså:
H
ee
lll
... etc
 */

//string text = "Hello World!";
//int count;

//    for (int letterIndex = 0; letterIndex < text.Length; letterIndex++)
//    {   
//        string charCount = new string(text[letterIndex], count = letterIndex + 1);

//        Console.WriteLine(charCount);

//}

//10
/*
Ordpyramid
Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”. 
Gör ett program som skriver ut första ordet en gång på första raden; andra ordet två gånger på nästa rad. 
Tredje ordet tre gånger på nästa. etc. alltså:

How
much much
wood wood wood
... etc
 */


//string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//int count = 1;

//string[] splitWord = text.Split(' ');

//foreach (var word in splitWord)
//{

//    Console.WriteLine(String.Join(" ", Enumerable.Repeat(word, count++)));

//}



//11
/*
 Ordpyramid 2
Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”. ¨
Gör ett program som på första raden skriver ut första ordet. 
På nästa rad skriver ut de två första orden, 
sedan de tre första orden på nästa rad o.s.v till man kommit till raden som skriver ut hela meningen. Alltså:

How
How much
How much wood
... etc
 */

//string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//int count = 1;
//string currentSentence = "";

//string[] splitWord = text.Split(' ');

//foreach (var word in splitWord)
//{
//    currentSentence = currentSentence + " " + word;

//    Console.WriteLine(currentSentence);
//}



//12
/*
 Rödmarkerade ord
Utgå från samma sträng igen, men denna gång ska programmet skriva ut hela strängen på varje rad. 
På första raden ska första ordet vara rött (övriga vita), på andra raden ska andra ordet vara rött. 
På tredje raden ska tredje vara rött osv. Alltså:

How much wood would a woodchuck chuck if a woodchuck could chuck wood?
How much wood would a woodchuck chuck if a woodchuck could chuck wood?
How much wood would a woodchuck chuck if a woodchuck could chuck wood?
... etc
 */

//string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
//bool redMarkedWord = false;
//int redWordIndex = 0;
//int wordIndex = 0;

//string[] splitWord = text.Split(' ');

//foreach (var word in splitWord)
//{

//    foreach (var word2 in splitWord)
//    {  
//        if (wordIndex == redWordIndex)
//        {
//            redMarkedWord = true;
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.Write(word2 + " ");

//        }
//        else
//        {
//            redMarkedWord = false;
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.Write(word2 + " ");
//        }
//        wordIndex++;

//    }

//    Console.WriteLine();
//    redWordIndex++;
//    wordIndex = 0;

//}

//Console.ResetColor();   



//13
/*
 Rödmarkerade bokstäver
Utgå från strängen "abcdefghijklmnopqrstuvwxyz". Hela strängen skrivs ut på varje rad. 
På första raden är de 5 första tecknen röda. På nästa rad är “bcdef” röda, sedan “cedfg” osv.. alltså alltid 5 tecken, 
men de flyttas ett steg åt höger för varje rad, tills sista raden har “vwxyz” rödfärgad. 
Alltså:

abcdefghijklmnopqrstuvwxyz
abcdefghijklmnopqrstuvwxyz
abcdefghijklmnopqrstuvwxyz
... etc
 */


//string text = "abcdefghijklmnopqrstuvwxyz";
//bool redMarkedLetters = false;
//int startIndex = 0;
//int endIndex = startIndex + 4;


//for (int letter = 0; letter < text.Length; letter++)

//{
//	for (int letterIndex = 0; letterIndex < text.Length; letterIndex++)
//	{
//		if (letterIndex >= startIndex && letterIndex <= endIndex)
//		{
//			redMarkedLetters = true;
//			Console.ForegroundColor = ConsoleColor.Red;
//			Console.Write(text[letterIndex]);
//		}
//		else if (endIndex >= text.Length)
//		{
//			break;
//		}
//		else
//		{

//			redMarkedLetters = false;
//			Console.ForegroundColor = ConsoleColor.White;
//			Console.Write(text[letterIndex]);
//		}
//	}
//	startIndex++;
//	endIndex++;
//	Console.WriteLine();
//}
//Console.ResetColor();



