
using CSharpPractice;

/*Solutions.Greetings();

Console.WriteLine("==== And \n of \n course....");

Solutions.GreetingsLogan();

Console.WriteLine("=====================================");*/

/*string userInput = Console.ReadLine();

Solutions.GreetingsLogan(userInput);*/

/*string parameter1 = "john";
string parameter2 = "doe";
int parameter3 = 3;
*/

/*Solutions.FormattingStringPractice(parameter1, "doe");*//*
Solutions.FormattingStringPractice(parameter1, parameter2, parameter3);
Console.WriteLine("\n=====================================\n");
Solutions.StringInterpolationPractice(parameter1, parameter2, parameter3);*/

/*string parameter1 = "0000 1111 2222 3333 4444";
string parameter2 = "06/24";
string parameter3 = "123";
string parameter4 = "Jane Doe";*/


//Solutions.PrintCreditCard(parameter1, parameter2, parameter3, parameter4);

/*string ibrahimCCN = "1232 3212 2312 1212 4545";
string ibrahimExp = "10/02";
string ibrahimCCV = "321";
string ibrahimFN = "Ibrahim Kayikci";*/

//Solutions.PrintCreditCard(ibrahimCCN, ibrahimExp, ibrahimCCV, ibrahimFN);


/*int theVarToPrint = Solutions.AddTwoInts(1, 2);
Console.WriteLine(theVarToPrint);

theVarToPrint = Solutions.AddTwoInts(-100, 101);
Console.WriteLine(theVarToPrint);

theVarToPrint = Solutions.AddTwoInts(1000, 1);
Console.WriteLine(theVarToPrint);

theVarToPrint = Solutions.AddTwoInts(10, 10);
Console.WriteLine(theVarToPrint);*/

/*int resultOfSubThree = Solutions.SubstractThreeFromInt(7);
Console.WriteLine(resultOfSubThree);*/

/*string homework2 = Solutions.Homework2(2, 9, 5, 3);
Console.WriteLine(homework2);

homework2 = Solutions.Homework2(20, -9, 5, 3);
Console.WriteLine(homework2);*/

/*string Homework3 = Solutions.Homework3(1, 2, 3, 4);
Console.WriteLine(Homework3);*/

/*Console.WriteLine(
    Solutions.Homework3(2, 4, 3, 4) + "\n"
    + Solutions.Homework3(1, 9, 3, 0) + "\n"
    + Solutions.Homework3(0, 5, 2, 1) + "\n"
    + Solutions.Homework3(2, 5, 2, 4) + "\n"
    + Solutions.Homework3(1, 2, 0, 4) + "\n"
    + Solutions.Homework3(1, 0, 1, 0) + "\n");*/

/*string Homework4 = Solutions.Homework4("Jane", 5, "John", 8);
Console.WriteLine(Homework4);

Console.WriteLine(
    Solutions.Homework4("Jane", 5, "John", 8) + "\n"
    + Solutions.Homework4("Mark", 31, "Joe", 11) + "\n"
    + Solutions.Homework4("Johnny", 21, "Kelly", 23) + "\n"
    + Solutions.Homework4("Cole", 1, "Corey", 8) + "\n"
    + Solutions.Homework4("Jane", 87, "John",92) + "\n"
    + Solutions.Homework4("Jane", 45, "John", 65) + "\n"
    );
*/


/*int age = (17);
bool anything = Solutions.CanDrink(age);*/


/*Console.WriteLine(anything);*/


/*while (true)
{
    if (Solutions.TakeUserStringInput().Equals("stop"))
    {
        break;
    }

    Solutions.TellTheUser("Please enter your age:");
    int age = Solutions.TakeUserIntInput();

    Solutions.TellTheUser("Do you have a license? y/n");
    bool hasLicense = Solutions.TakeUserBoolInput();

    Solutions.TellTheUser("is your license suspended? y/n");
    bool licenseSuspended = Solutions.TakeUserBoolInput();

    bool isEligible = LogicOperatorsPractice.EligibleToRentCar(age, hasLicense, licenseSuspended);
    Console.WriteLine($"Are you eligible to rent the car? {isEligible}");
}*/

/*double gpa = 3.3;
bool result = gpa > 3.0;
Console.WriteLine(result);*/

/*string myLine = "abra cadabra";

int lengthOfMyLine = myLine.Length;

Console.WriteLine("The length of my line is {0}", lengthOfMyLine);*/

/*string lengthOfMyDogsNames = StringPractice.MyDogs("Gavin", "Georgie");

Console.WriteLine(lengthOfMyDogsNames);

lengthOfMyDogsNames = StringPractice.MyDogs("Max", "Sammy");

Console.WriteLine(lengthOfMyDogsNames);*/

/*string getridofspaces = StringPractice.ReplaceSpacesWithUnderscores("Small Government, Big Solutions");
Console.WriteLine(getridofspaces);

getridofspaces = StringPractice.ReplaceSpacesWithUnderscores("I love coffee");
Console.WriteLine(getridofspaces);*/

/*string firstName1 = StringPractice.GetFirstNameFromFullName("John Doe");
string firstName2 = StringPractice.GetFirstNameFromFullName("Albert Einstein");
string firstName3 = StringPractice.GetFirstNameFromFullName("Nikola Tesla");
string firstName4 = StringPractice.GetFirstNameFromFullName("Arthur Conan Doyle");
string firstName5 = StringPractice.GetFirstNameFromFullName("Edgar Allen Poe");

Console.WriteLine("{0}, {1}, {2}, {3}, {4}", firstName1, firstName2, firstName3, firstName4, firstName5);*/


string name1 = "Johnny";
string name2 = "Jane";
int age1 = 21;
int age2 = 21;

/*IfElsePractice.CompareNameLengths(name1, name2);
*/

string ageComparisonResult = IfElsePractice.CompareAges(age1, age2, name1, name2);
Console.WriteLine(ageComparisonResult);