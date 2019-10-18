namespace CoursePractices.Interfaces
{
    interface IPaymentService
    {
        double CalculateInstallment(double amount, int monthNumber);
    }
}
