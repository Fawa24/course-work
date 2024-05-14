namespace CourseWork.IServiceContracts.Payment
{
    public class OnlinePaymentStrategy : PaymentStrategy
    {
        public override void SetPaymentMethod()
        {
            SetPaymentMethodName = "Online";
        }

        public OnlinePaymentStrategy()
        {
            SetPaymentMethod();
        }
    }
}
