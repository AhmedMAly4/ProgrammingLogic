namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        //Step 1
        Console.WriteLine("Ahmed Mohamed");
        Console.WriteLine("IT-1050");
        
        //Step 2
        /*Name:[Ahmed]
        Title:[IT-1050 - Lab]*/
        
        //Step 3
        int favNum = 4;
        string favLang = "Java";
        double programsWritten = 20;
        bool experience = true;

        //Step 4
        Console.WriteLine("My favorite number is " + favNum + ".");
        Console.WriteLine("My favorite programming language is " + favLang + ".");
        Console.WriteLine("I have written about " + programsWritten + " programs.");
        if(experience == true){
        Console.WriteLine(experience + ", I do have programming experience.");
        } else {
        Console.WriteLine(experience + ", I do not have programming experience.");
        }
        
        //Step 5
        const string schoolName = "Westlake High School";
        Console.WriteLine("I go to " + schoolName + ".");

        //Step 6
        //All variables have meaningful names.
    }
}
