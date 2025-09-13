
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



