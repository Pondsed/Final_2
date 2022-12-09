using System;

class Program
{
    static void Main(string[] args)
    {
        Stack<char>WonglebStack = new Stack<char>();
        Console.WriteLine("Please input your Wongleb");
        Console.WriteLine("Input Any only one letter to Finish");
        while(true){
            Console.Write("Input : ");
            char input = char.Parse(Console.ReadLine());
            if(input == '(' || input == ')'){
                WonglebStack.Push(input);
            }
            else{
                break;
            }
        }
        if((WonglebStack.GetLength() %2) != 0){
            Console.WriteLine("Invalid");
        }
        else if ((WonglebStack.GetLength() %2) == 0){
            int leftcurvecheck = 0;
            int rightcurvecheck = 0;
            Stack<char>MockWonglebStack = WonglebStack;
            while(true){
                if(MockWonglebStack.GetLength() > 0){
                    char temppop = MockWonglebStack.Pop();
                    if(temppop == '('){
                        leftcurvecheck++;
                    }
                    if(temppop == ')'){
                        rightcurvecheck++;
                    }
                }
                else{
                    break;
                }
            }
            if(leftcurvecheck != rightcurvecheck){
                Console.WriteLine("Invalid");
            }
            if(leftcurvecheck == rightcurvecheck){
                Console.WriteLine("Valid");
            }
        }
    }
}
