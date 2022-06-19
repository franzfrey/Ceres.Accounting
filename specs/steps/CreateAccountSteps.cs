namespace Ceres.Accounting.Specs 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Gauge.CSharp.Lib;
    using Gauge.CSharp.Lib.Attribute;
 
    public class CreateAccountSteps
    {
        private AccountingSystem sut = new AccountingSystem();
        private Account account;

        [Step("User has role <role>")]
        public void UserHasRole(string userRole)
        {
        }
   
		[Step("Create account <accountName> with number <accountNumber> of type <accountType>")]
		public void CreateAccountWithNumberOfType(string accountName, string accountNumber, string accountType)
		{
			sut.Send(new CreateAccount(accountName, accountNumber, accountType));
		}
	
		[Step("Set description of account <accountName> to <description>")]
		public void SetDescriptionOfAccountTo(string accountName, string description)
		{
            sut.Send(new UpdateAccount(accountName, description: description));
		}
	
		[Step("Get account <accountName>")]
		public void GetAccount(string accountName)
	    {
			// account = sut.Query(new GetAccount(accountName));
		}
	
		[Step("Account <accountName> should be of type <Asset>")]
		public void AccountShouldBeOfType(string accountName, string accountType)
		{
			// account.Type.ToString() == accountType;
		}
	
		[Step("and should have the number <accountNumber>")]
		public void AndShouldHaveTheNumber(string accountNumber)
		{
			// account.Number == accountNumber;
		}
	
		[Step("and should have <description> as description")]
		public void AndShouldHaveAsDescription(string description)
		{
			// account.Description == description;
		}
	}
}