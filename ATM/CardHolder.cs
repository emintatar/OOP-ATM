using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
     public class CardHolder
    {
        string firstName;
        string lastName;
        string cardNumber;
        int pin;
        double balance;

        public CardHolder(string firstName, string lastName, string cardNumber, int pin, double balance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cardNumber = cardNumber;
            this.pin = pin;
            this.balance = balance;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getCardNumber()
        {
            return cardNumber;
        }

        public int getPin()
        {
            return pin;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public void setCardNumber(string newCardNumber)
        {
            cardNumber = newCardNumber;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
    }
}
