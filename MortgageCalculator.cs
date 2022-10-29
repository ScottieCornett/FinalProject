using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class MortgageCalculator
    {
        private int principal;
        private float annualInterest;
        private byte years;
        private const byte MONTHS_IN_YEAR = 12;
        private const byte PERCENT = 100;

        public MortgageCalculator(int principal, float annualInterest, byte years)
        {
            this.principal = principal;
            this.annualInterest = annualInterest;
            this.years = years;
        }

        public double CalculateBalance(short numberOfPaymentsMade)
        {
            float monthlyInterest = annualInterest / PERCENT / MONTHS_IN_YEAR;
            float numberOfPayments = years * MONTHS_IN_YEAR;

            double balance = principal
                * (Math.Pow(1 + monthlyInterest, numberOfPayments) - Math.Pow(1 + monthlyInterest, numberOfPaymentsMade))
                / (Math.Pow(1 + monthlyInterest, numberOfPayments) - 1);
            return balance;
        }
        public double CalculateMortgage()
        {
            int numberOfPayments = years * MONTHS_IN_YEAR;
            float monthlyInterest = annualInterest / PERCENT / MONTHS_IN_YEAR;

            double mortgage = principal
                * (monthlyInterest * Math.Pow(1 + monthlyInterest, numberOfPayments))
                / (Math.Pow(1 + monthlyInterest, numberOfPayments) - 1);
            return mortgage;
        }

    }
}
