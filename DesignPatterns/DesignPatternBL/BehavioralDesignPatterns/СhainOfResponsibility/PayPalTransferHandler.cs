namespace DesignPatternBL.СhainOfResponsibility
{
    public class PayPalTransferHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Bitcoin")
            {
                return $"PayPal Transfer called {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
