namespace WhoHasItAPI.Manager
{
    public class ItemManager
    {
        WhoHasItContext WhoHasItContext { get; set; }

        public ItemManager(WhoHasItContext context)
        {
            WhoHasItContext = context;
        }

        public IEnumerable<Item> GetItems()
        {
            return WhoHasItContext.Items;
        }

        public Item? GetItemByID(int id)
        {
            return WhoHasItContext.Items.Find(id);
        }
    }
}
