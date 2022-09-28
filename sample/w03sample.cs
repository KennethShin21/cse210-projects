// A code template for the category of things known as Person.
// The responsibility of a Person is to hold and display personal information.
public class Person
{
    public string givenName = "";
    public string familyName = "";

    // A special method, called a constructor that is invoked using the new
    // keyword followed by the class name and parentheses.
    public Person()
    {

    }
    // A method that displays the person's full name as used in eastern
    // countries or &lt;family name, given name&gt;.
    public string showEasternName()
    {
        Console.WriteLine($"{familyName}, {givenName}");
    }
    // A method that displays the person's full name as used in western
    // countries or &lt;given name, family name&gt;.
    public string showWesternName()
    {
        Console.Writeline($"{givenName} {familyName}");
    }

    Person person = new Person();
    person.givenName = "Joseph";
    person.familyName = "Smith";
    person.showWesternName();
    person.showEasternName();


}