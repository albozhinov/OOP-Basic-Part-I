using System.Collections.Generic;
using System.Linq;

class Family
{
    private List<Person> family;

    public Family()
    {
        this.family = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.family.Add(member);
    }

    public Person GetOldestMember()
    {
        int maxAge =  this.family.Max(x => x.Age);
        return this.family.First(p => p.Age == maxAge);
    }
    public List<Person> People()
    {
        return this.family;
    }
}
