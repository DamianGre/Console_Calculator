// Console calculator
double firstNumber=0, secondNumber=0, result=0;
char operation;
bool doAgain = true;
String anotherOperation;
try {
    do
    {
        firstNumber = 0;
        secondNumber = 0;
        result = 0;
        doAgain = true;

        Console.Write("Enter first number: ");
        firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("For addition enter: \"+\"" +
            "\nFor subtraction enter: \"-\"" +
            "\nFor multiplication enter: \"*\"" +
            "\nFor division enter:  \"/\"" +
            "\nFor the root enter: \";\"" +
            "\nFor calculate the power enter: \"^\"");
        operation = Convert.ToChar(Console.ReadLine());
        if (operation != '+' && operation != '-' && operation != '*' && operation != '/' &&
            operation != ';' && operation != '^')
        {
            throw new Exception("Wrong data!");
        }

        if (operation != ';')
        {
            Console.Write("Enter second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
        }

        switch (operation)
        {
            case '+': result = firstNumber + secondNumber; break;
            case '-': result = firstNumber - secondNumber; break;
            case '*': result = firstNumber * secondNumber; break;
            case '/':
                {
                    if (secondNumber == 0)
                    {
                        throw new Exception("YOU CAN'T DIVIDE BY 0!");
                    }
                    result = firstNumber / secondNumber;
                }
                break;
            case ';': result = Math.Sqrt(firstNumber); break;
            case '^': result = Math.Pow(firstNumber, secondNumber); break;            
        }
        if (operation == ';') {
            Console.WriteLine("Square root of: " + firstNumber + " = " + result);
        }
        else if (operation == '^') {
            Console.WriteLine("Power of: " + firstNumber +  operation + secondNumber + " = " + result);
        }
        else{
            Console.WriteLine("Result of: " + firstNumber + " " + operation + " " + secondNumber + " " + " = " + result);
        }
        Console.Write("Do you want to do another math operation (Y/N)");
        anotherOperation = Console.ReadLine();
        anotherOperation = anotherOperation.ToUpper();

        if (anotherOperation == "Y"){
            doAgain = true;
        }
        else if(anotherOperation == "N"){
            doAgain = false;
        }
        else{
            throw new Exception("Entered data is wrong!");
        }
    } while (doAgain == true);
}
catch (Exception ex) {
    Console.WriteLine(ex);
}
