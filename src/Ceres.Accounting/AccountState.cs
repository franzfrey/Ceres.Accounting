namespace Ceres.Accounting
{
    public class AccountState
    {
        public AccountState(string name, string number, string type, string? description)
        {
            Name = name;
            Number = number;
            Type = type;
            Description = description;
        }

        public string Name { get; }
        public string Number { get; }
        public string Type { get; }
        public string? Description { get; }
    }
}