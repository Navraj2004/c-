using System;

class Program
{
    static void Main(string[] args)
    {
      
      string val;
      Console.WriteLine("Enter the string to reverse the value ");
      val=Console.ReadLine();

      char[] character= val.ToCharArray();

      int start = 0;
      int end=character.Length-1;

      while(start<end)
      {
         
        char temp=character[start];
        character[start]=character[end];
        character[end]=temp;
        start++;
        end--;

      }

      string reversed = new string(character);

      Console.WriteLine("The value is "+ reversed);


    }
}
