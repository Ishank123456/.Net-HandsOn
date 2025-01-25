namespace Wipro_FinalProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Product> LstProduct { get; set; }
    }
}
