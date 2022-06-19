namespace Ceres.Accounting
{
    internal class Account
    {
        private string _name;
        private string _number;
        private string _type;
        private string? _description;

        public Account(string name, string number, string type, string? description)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _number = number ?? throw new ArgumentNullException(nameof(number));
            _type = type ?? throw new ArgumentNullException(nameof(type));
            _description = description;
        }

        internal static Account From(AccountState accountState)
        {
            throw new NotImplementedException();
        }

        internal AccountState GetState()
        {
            return new AccountState(_name, _number, _type, _description);
        }
    }
}