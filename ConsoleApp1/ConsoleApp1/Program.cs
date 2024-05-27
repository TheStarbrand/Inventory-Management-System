using System.Security;

var person = new person();
person.Name = null;
person.PrintNameLength();
class person
{
    public string Name { get; set; } = string.Empty;

    public void PrintNameLength()
    {
        if(Name != null)
        {
            Console.WriteLine(Name.Length);
        }
        else
        {
            Console.WriteLine("NULL VALUE!");
        }
       
    }
}