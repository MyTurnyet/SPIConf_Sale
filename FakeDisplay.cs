namespace Sale
{
    public class FakeDisplay : IDisplay
    {
        private string _lastShowedItem;

        public void LastItem(string itemDisplay)
        {
            _lastShowedItem = itemDisplay;
        }

        public string lastShowedItem()
        {
            return _lastShowedItem;
        }
    }
}
