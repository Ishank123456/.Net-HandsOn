using Domain.Models;

public interface IPaymentRepository
{
    IEnumerable<PaymentDetail> GetAllPaymentDetails();
    PaymentDetail GetPaymentDetailsById(int id);
    int AddPaymentDetails(PaymentDetail paymentDetail);
    //int UpdatePaymentDetails(PaymentDetail paymentDetail);
    //bool DeletePaymentDetails(int id);

    IEnumerable<PaymentDetail> GetAllPaymentDetailsForUser(int userId);
    //int ConfirmPayment(PaymentDetail paymentDetail);
}