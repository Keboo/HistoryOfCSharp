#:property LangVersion preview

Person? p = null;
p?.Name = "John";
p.DisplayName();

p = new() { Name = "Jane" };
p.DisplayName();

Console.WriteLine(Guid.NewBestGuid());

class Person
{
    public string? Name
    {
        get;
        set => field = value ?? throw new ArgumentNullException(nameof(value));
    }
}

static class Extensions
{
    extension(Person? person)
    {
        private bool HasName => !string.IsNullOrEmpty(person?.Name);

        public void DisplayName()
        {
            Console.WriteLine(person!.HasName ? person.Name : "<unset>");
        }
    }

    extension(Guid)
    {
        public static Guid NewBestGuid() => Guid.Parse("42424242-4242-4242-4242-424242424242");
    }
}


