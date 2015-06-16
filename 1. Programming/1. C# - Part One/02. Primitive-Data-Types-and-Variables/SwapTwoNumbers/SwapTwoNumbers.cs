using System;

class SwapTwoNumbers
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        int temp = int.MinValue;
        temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
        Console.WriteLine("Numbers after swap : \nfirstNumber : {0}\nsecondNumber {1}",firstNumber,secondNumber);
    }
}

