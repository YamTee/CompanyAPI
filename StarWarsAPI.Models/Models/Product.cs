namespace CompanyAPI.Models.Models;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public int SupplierId { get; set; }
    public decimal UnitPrice { get; set; }
    public string Package { get; set; } = string.Empty;
    public bool IsDiscontinued { get; set; }
    public virtual Supplier Supplier { get; set; } = new Supplier();
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}