using System;
using CoursePractices.Interfaces;
using CoursePractices.Utils;

namespace CoursePractices.Classes
{
    class Installment : IPaymentService
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public double CalculateInstallment(double amount, int monthNumber)
        {
            double calculatedValue = amount + ((amount * 0.01) * monthNumber);

            double paymentFee = calculatedValue * 0.02;

            return calculatedValue + paymentFee;
        }
    }
}
