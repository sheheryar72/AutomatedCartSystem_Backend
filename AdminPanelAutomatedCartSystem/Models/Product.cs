namespace AdminPanelAutomatedCartSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ShortDiscription { get; set; }
        public string LongDiscription { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Barcode { get; set; }
        public int AdminId { get; set; }
    }
}
