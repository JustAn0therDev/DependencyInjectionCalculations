using System;
using CoursePractices.Classes;
using System.Globalization;

namespace CoursePractices
{
    class Program
    {
        static void Main()
        {
            int number, numberOfInstallments;
            DateTime date;
            double totalValue;
            try
            {
                Console.WriteLine("Enter contract data");

                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());

                Console.Write("Date (dd/MM/yyyy): ");
                date = DateTime.Parse(Console.ReadLine());

                Console.Write("Contract value: ");
                totalValue = double.Parse(Console.ReadLine());

                Console.Write("Enter number of installments: ");
                numberOfInstallments = int.Parse(Console.ReadLine());

                Console.WriteLine("Installments: ");

                /*Um objeto do tipo contrato e instanciado com o argumento de um construtor do tipo installment, que implementa 
                 * a interface injetada na classe (IPaymentService) como depedência na hora de chamar o método PopulateInstallments.
                 */
                Contract contract = new Contract(number, date, totalValue, new Installment());

                contract.PopulateInstallments(numberOfInstallments, contract.Date);

                foreach (Installment installment in contract.Installments)
                {
                    Console.WriteLine($"{installment.DueDate.ToShortDateString()} - {installment.Amount.ToString(CultureInfo.InvariantCulture)}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
