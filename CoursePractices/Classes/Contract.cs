using System;
using System.Collections.Generic;
using CoursePractices.Interfaces;

namespace CoursePractices.Classes
{
    class Contract
    {
        #region Public Properties

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public IPaymentService _paymentService;

        #endregion

        #region Constructors
        public Contract() { }

        public Contract(int number, DateTime date, double totalValue, IPaymentService paymentService)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            _paymentService = paymentService;
        }

        #endregion

        #region Public Methods

        public void PopulateInstallments(int numberOfInstallments, DateTime initialDate)
        {
            //Adiciona a parcela para a lista de parcelas do contrato ao passar por cada iteracao.
            for (int i = 1; i <= numberOfInstallments; i++)
            {
                initialDate = initialDate.AddMonths(1);
                double installmentAmount = TotalValue / numberOfInstallments;
                Installments.Add(new Installment()
                {
                    Amount = _paymentService.CalculateInstallment(installmentAmount, i),
                    DueDate = initialDate
                });
            }
        }

        #endregion
    }
}
