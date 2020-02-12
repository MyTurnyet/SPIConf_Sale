namespace Sale
{
    public class Sale
    {
        private readonly IDisplay _display;

        public Sale(IDisplay display)
        {
            _display = display;
        }

        public void AddBarcode(string barcode)
        {
        }
    }
}
