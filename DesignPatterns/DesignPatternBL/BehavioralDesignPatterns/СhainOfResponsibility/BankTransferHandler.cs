namespace DesignPatternBL.СhainOfResponsibility
{
    public class BankTransferHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Cash")
            {
                return $"Bank Transfer called {request}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
