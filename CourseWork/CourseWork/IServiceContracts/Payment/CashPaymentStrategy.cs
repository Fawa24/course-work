namespace CourseWork.IServiceContracts.Payment
{
    public class CashPaymentStrategy : PaymentStrategy
    {
        public override void SetPaymentMethod()
        {
            SetPaymentMethodName = "Cash";
        }

        public CashPaymentStrategy()
        {
            SetPaymentMethod();
        }
    }
}
