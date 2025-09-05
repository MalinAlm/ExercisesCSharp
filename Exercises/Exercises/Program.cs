// Exercises 

//1

//Console.WriteLine("Skriv ditt namn");

//string name = Console.ReadLine();

//Console.WriteLine("Hej " + name + "!\n");

//2

//Console.WriteLine("Skriv in två heltal\n");

//Console.WriteLine("Skriv in första talet:");
//int firstNumber = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Skriv in andra talet:");
//int secondNumber = Int32.Parse(Console.ReadLine());

//Console.WriteLine("\n" + firstNumber + " * " + secondNumber + " = " + firstNumber * secondNumber + "\n");


//3:1

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

//Console.WriteLine("Skriv ett tal:");

//int inputNumber = Int32.Parse(Console.ReadLine());

//if (inputNumber != null)
//{
//    Console.WriteLine(inputNumber * 2 + " är dubbelt så mycket som " + inputNumber);
//    Console.WriteLine(inputNumber / 2.0 + " är hälften så mycket som " + inputNumber );
//}

//6

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







