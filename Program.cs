namespace Conditional_statements_240624
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roll = 1001;
            float fees = 15452.34f;
            string name = "rajesh";
            char div='a';
            // student information

            // roll=1001 Name of student = rajesh div= a fees paid=15452.34
            //1 string concat
            Console.WriteLine("roll="+roll+" Name of student ="+name+" div= "+div+" fees paid= "+fees);
            //2 place holder
            Console.WriteLine("roll= {0} Name of student = {1} ", roll,  name);
            //3 string interpolation.
            Console.WriteLine($"roll= {roll} Name of student = {name} ");
            //////////////////////////
            Console.WriteLine("sdfasd");
            Console.WriteLine("sdfasdf");
            //
            Console.WriteLine("dfkajslfksdaf");
        }
        
    }
}

