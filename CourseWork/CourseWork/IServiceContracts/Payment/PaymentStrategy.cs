namespace CourseWork.IServiceContracts.Payment
{
    public abstract class PaymentStrategy
    {
        private string paymentMethodName;

        protected string SetPaymentMethodName { set { paymentMethodName = value; } }

        public abstract void SetPaymentMethod();

        public string getViewPath()
        {
            return $"Payment/{paymentMethodName}";
        }
    }
}
