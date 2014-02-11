using System;

public class Courtney_Elliott_HW2
{
   // Main method begins execution of C# application
   public static void Main (string[] args)
   {
      Account account1 = new Account(50.00M); // create Account object
      Account account2 = new Account(-7.53M); // create Account object

      Console.WriteLine("account1 balance: {0:C}", // display initial balance of each object using a property
         account1.getBalance()); // display balance
      Console.WriteLine("account2 balance: {0:C}\n",
         account2.getBalance()); // display balance

      decimal depositAmount; // deposit amount read from user

      Console.Write("Enter deposit amount for account1: "); // prompt and obtain user input
      depositAmount = Convert.ToDecimal(Console.ReadLine());
      Console.WriteLine("adding {0:C} to account1 balance\n",
         depositAmount);
      account1.Credit(depositAmount); // add to account1 balance

      // display balances
      Console.WriteLine("account1 balance: {0:C}",
         account1.getBalance());
      Console.WriteLine("account2 balance: {0:C}\n",
         account2.getBalance());

      // prompt and obtain user input
      Console.Write("Enter deposit amount for account2: ");
      depositAmount = Convert.ToDecimal(Console.ReadLine());
      Console.WriteLine("adding {0:C} to account2 balance\n",
         depositAmount);
      account2.Credit(depositAmount); // add to account2 balance

      // display balances
      Console.WriteLine("account1 balance: {0:C}", account1.getBalance());
      Console.WriteLine("account2 balance: {0:C}", account2.getBalance());


      decimal interestRate;

      Console.WriteLine("enter interest rate for account1: ");
      interestRate = Convert.ToDecimal(Console.ReadLine());
      account1.addInterest(interestRate); // add to account1 balance

      // display balances
      Console.WriteLine("account1 balance after interest: {0:C}",
         account1.getBalance());
      Console.WriteLine("account2 balance: {0:C}\n",
         account2.getBalance());

      // prompt and obtain user input
      Console.Write("Enter interest rate for account2: ");
      interestRate = Convert.ToDecimal(Console.ReadLine());
      account2.addInterest(interestRate);

      Console.WriteLine("account1 balance after interest: {0:C}",
   account1.getBalance());
      Console.WriteLine("account2 balance: {0:C}\n",
         account2.getBalance());

      Console.ReadLine();
   } // end Main
} // end class Courtney_Elliott_HW2

public class Account
{
   private decimal balance; // instance variable that stores the balance

   // constructor  
   public Account(decimal initialBalance)
   {
      balance = initialBalance; // set balance
   } // end Account constructor

   // credit (add) an amount to the account
   public void Credit(decimal amount)
   {
      // declare a variable to hold the new balance
      decimal newBalance = getBalance() + amount;

      setBalance(newBalance); // call setBalance

   } // end method Credit

   /*
    * setBalance
    * A mutator method (a setter) that modifies the balance to a 
    * given value (amount) that is passed as a parameter
    */
   public void setBalance(decimal amount)
   {
      balance = amount; // change the old balance 
   }

   /*
   * getBalance
   * An accessor method (a getter) that returns the variable balance
   * This method does not need parameters
   */
   public decimal getBalance()
   {
      return balance;
   }

   // my addition **********************************


   public void addInterest(decimal interest)
   {

      decimal balancePlus = ((getBalance()*interest)/100)+ balance;

        //balancePlus is the balance plus the interest
      balance = balancePlus;
   }
} // end class Account



