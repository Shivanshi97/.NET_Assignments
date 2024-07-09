namespace ProductsOnline.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? UnitPrice { get; set; }
        public int? Quantity { get; set; }

        public override string? ToString()
        {
          //  return base.ToString();
          return "Id: "+Id+" Title: "+Title+" Description: "+Description+" Unit Price: "+UnitPrice+" Quantity: "+Quantity;
        }
    }
}
