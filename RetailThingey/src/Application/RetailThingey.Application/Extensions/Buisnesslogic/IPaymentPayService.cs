namespace RetailThingey.Application.Extensions.Buisnesslogic;

public interface IPaymentPayService
{
    bool ProcessPayment(decimal amount);
}

public class PaymentPayService : IPaymentPayService
{
    public bool ProcessPayment(decimal amount)
    {
        if (amount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}