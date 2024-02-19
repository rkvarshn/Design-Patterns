namespace builder;
// Progressive Builder (progressive interface)
public class PersonBuilder
{
    private Person person;
    public PersonBuilder()
    {
        person = new Person();
    }
    public PersonBuilder WithFirstName(string firstName)
    {
        person.FirstName = firstName;
        return this;
    }
    public PersonBuilder WithLastName(string lastName)
    {
        person.LastName = lastName;
        return this;
    }
    public PersonBuilder WithAge(int age)
    {
        person.Age = age;
        return this;
    }
    public PersonBuilder WithAddress(string address)
    {
        person.Address = address;
        return this;
    }
    public Person Build()
    {
        return person;
    }
    public void Reset()
    {
        person = new Person();
    }
}