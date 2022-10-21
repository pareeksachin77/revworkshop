// See https://aka.ms/new-console-template for more information


using UserRegistration;

Console.WriteLine("Welcome to User Registration Problem");
Console.WriteLine("Use case #1: First Name");
Console.WriteLine("Use case #2: Last Name");
Console.WriteLine("Use case #3: Email");
Console.WriteLine("Use case #4: Phone Numbers");
Console.WriteLine("Use case #5: Password Rule One: minimum 8 characters");

Console.Write("Please select a program to run from options above: ");

int yourchoice = Convert.ToInt32(Console.ReadLine());

switch(yourchoice){
    case 1:
            bool FName = RegexFirstName.validatestring("Sachin");
            Console.WriteLine("{0}", (FName) ? "Valid" : "Invalid");
            break;
    case 2:
            bool LName = RegexLastname.validatestring("Pareek");
            Console.WriteLine("{0}",(LName)? "Valid": "Invalid");
            break;
    case 3:
        bool EmailValidate = RegexEmail.validatestring("pareek.sachin@bridgelabz.co.in");
        Console.WriteLine("{0}",(EmailValidate)?"valid":"Invalid");
        break;
    case 4:
        bool NumberToValidate = RegexNumber.validatestring("91 8209177331");
        Console.WriteLine("{0}",(NumberToValidate)?"Valid":"Invalid");
        break;
    case 5:
        bool password1ToValidate = PasswordRuleOne.validateString("sachin123");
        Console.WriteLine("{0}",(password1ToValidate)?"valid":"Invalid");
        break;
    case 6:
        bool passwordTwoValidate = PasswordRuleTwo.validateString("qweRty123");
        Console.WriteLine("{0}",(passwordTwoValidate)?"valid":"Invalid");
        break;
    case 7:
        bool passwordThreeValidate = PasswordRuleThree.validateString("qweRty123");
        Console.WriteLine("{0}",(passwordThreeValidate)?"valid":"Invalid");
        break;
    case 8:
        bool passwordFourValidate = PasswordRuleFour.validateString("s@chin123");
        Console.WriteLine("{0}", (passwordFourValidate) ? "valid" : "Invalid");
        break;
    case 9:
        bool emailSampleValidate = EmailSample.validateString("abc+100@gmail.com");
        Console.WriteLine("{0}",(emailSampleValidate)?"Valid":"Invalid");
        break;
    default:
        Console.WriteLine("Please enter a valid number from given options");
        break;
}



