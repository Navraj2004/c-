using System;

class Program
{
    static void Main(string[] args)
    {
       int a, b;
       char op;


       Console.WriteLine("Enter the value of a ");
       a=Convert.ToInt32(Console.ReadLine());
        
       Console.WriteLine("Enter the value of b");
       b=Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Enter the operation to perform subtraction(-) or multiplication(*) or division(/) or addition(+)");
       op=op = Convert.ToChar(Console.ReadLine());



       switch(op)
        {
            case '+':
                {
                    int ans=a+b;
                    Console.WriteLine(" Result " + ans);
                    break;
                }
            
            case '-':
                {
                    int ans=a-b;
                    Console.WriteLine(" Result " + ans);
                    break;
                }
            case '*':
                {
                    int ans=a*b;
                    Console.WriteLine(" Result " + ans);
                    break;
                }
            case '/':
                {
                    if(b==0)
                    {
                        Console.WriteLine("Value is invalid");
                        break;
                    }
             
                    else{
                    int ans=a/b;
                    Console.WriteLine(ans);
                    break;
                    }
                }

            default:
                   Console.WriteLine("Invalid operation");
                   break;

        }

       



    }
}
