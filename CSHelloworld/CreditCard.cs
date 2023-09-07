using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHelloworld
{
    abstract class CreditCard
    {
        protected string cardholderName { get; set; }
        protected string cardNumber { get; set; }
        protected string cardExpiryDate { get; set; }
        protected string cardVerificationValue { get; set; }
        protected double creditCardLimitUSD { get; set; }
        private const double rateUSDToEURO = 0.93;

        public void UpdateCardInfo(string name, string number, string expiryDate, string verificationValue)
        {
            cardholderName = name;
            cardNumber = number;
            cardExpiryDate = expiryDate;
            cardVerificationValue = verificationValue;
        }

        public void ViewCardInfo()
        {
            Console.WriteLine("Cardholder Name: " +  cardholderName);
            Console.WriteLine("Card Number: " + cardNumber);
            Console.WriteLine("Credit Card Limit: " + creditCardLimitUSD + " USD");
        }

        public void PutMoney(double amount)
        {
            creditCardLimitUSD += amount;
            Console.WriteLine("Your card has received a payment: " +  amount);
            Console.WriteLine("Current balance: " + creditCardLimitUSD + " USD");
        }

        public void CurrencyConversion()
        {
            double euro = creditCardLimitUSD * rateUSDToEURO;
            Console.WriteLine("Cardholder Name: " + cardholderName);
            Console.WriteLine("Card Number: " + cardNumber);
            Console.WriteLine("Credit Card Limit: " + euro + " EURO");
        }

        public void Payment(double amountUSD, string cardExpiryDate, string cardVerificationValue)
        {
            if (cardExpiryDate == this.cardExpiryDate && cardVerificationValue == this.cardVerificationValue)
            {
                if (amountUSD <= creditCardLimitUSD)
                {
                    creditCardLimitUSD -= amountUSD;
                    Console.WriteLine("Your card has been charged: " + amountUSD + " USD");
                    Console.WriteLine("Current balance: " + creditCardLimitUSD + " USD");
                }
                else
                {
                    Console.WriteLine("Transaction declined: " + amountUSD + " USD");
                    Console.WriteLine("Reason: Over limit");
                }
            }
            else
            {
                Console.WriteLine("The information you entered is not valid");
            }
        }
    }

    class VisaMaster : CreditCard { }

    class Program
    {
        static void Main(string[] args)
        {
            VisaMaster master = new VisaMaster();
            master.UpdateCardInfo("khanh", "khanh123", "07-09", "mk101010");
            
            Console.WriteLine();
            master.PutMoney(1050);

            Console.WriteLine();
            master.Payment(50, "07-09", "mk101010");

            Console.WriteLine();
            master.ViewCardInfo();

            Console.WriteLine();
            master.CurrencyConversion();
            
        }
    }
}
