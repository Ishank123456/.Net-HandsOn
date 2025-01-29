using Domain.Models;

public class PaymentRepository : IPaymentRepository
{
    private readonly WiproOnlineMovieBookingApplicationContext paymentDbContext;
    public PaymentRepository(WiproOnlineMovieBookingApplicationContext _paymentDbContext)
    {
        paymentDbContext = _paymentDbContext;
    }

    public int AddPaymentDetails(PaymentDetail paymentDetail)
    {
        paymentDbContext.PaymentDetails.Add(paymentDetail);
        return paymentDbContext.SaveChanges();
    }


    public IEnumerable<PaymentDetail> GetAllPaymentDetails()
    {
        return paymentDbContext.PaymentDetails
            .ToList();
    }

    public PaymentDetail GetPaymentDetailsById(int id)
    {
        return paymentDbContext.PaymentDetails
            .SingleOrDefault(p => p.PaymentId == id);
    }

    public IEnumerable<PaymentDetail> GetAllPaymentDetailsForUser(int userId)
    {
        return paymentDbContext.PaymentDetails.Where(p => p.UserId == userId).ToList();
    }
}