namespace CourseWork.IServiceContracts.Payment
{
    public class TerminalPaymentStrategy : PaymentStrategy
    {
        public override void SetPaymentMethod()
        {
            SetPaymentMethodName = "Terminal";
        }

        public TerminalPaymentStrategy()
        {
            SetPaymentMethod();
        }
    }
}
