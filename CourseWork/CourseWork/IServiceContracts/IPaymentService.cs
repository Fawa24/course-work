using CourseWork.IServiceContracts.Payment;

namespace CourseWork.IServiceContracts
{
    public interface IPaymentService
    {
		// TODO: Rewrite using reflection
		public static PaymentStrategy CreatePaymentStrategy(string strategy) 
        {
            switch (strategy)
            {
                case "Online":
                    return new OnlinePaymentStrategy();
                case "Cash":
                    return new CashPaymentStrategy();
                case "Terminal":
                    return new TerminalPaymentStrategy();
                default:
                    throw new ArgumentException("No strategy found");
            }
        }
    }
}
