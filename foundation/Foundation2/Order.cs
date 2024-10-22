public class Order
{
    private Customer _customer;
    private List<Product> _products= new List<Product>();

    public Order()
    {

    }
    public Order(Customer customer,List<Product> list)
    {
        _customer=customer;
        _products=list;

    }
    public Order(Customer customer,Product product)
    {
       _customer=customer;
       _products.Add(product);
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string GetPackingLabel()
    {
        string packingList;
        List<string> productList = new List<string>();
        foreach(Product product in _products)
        {
           productList.Add($"{product.GetQuantity()} {product.GetId()} {product.GetName()}");
        }
        packingList=string.Join("\n",productList);
        string packingLabel=$"---PACKING LABEL---\n\n\nFROM:\nIvan's\nAccra,Ghana\nPhone:00223592311882\n\nTO:\n{_customer.GetName()}\n{_customer.GetAddress().GetDisplayText()}\nTRACKING NO: 29848-58303\nPRODUCTS:\n{packingList}\n\n\nHANDLING: Fragile-Handle with care\nSHIPPING METHOD: Standard Shipping\n";
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel=$"---SHIPPING LABEL---\n\n\nSHIP TO:\n{_customer.GetName()}\n{_customer.GetAddress().GetDisplayText()}";
        return shippingLabel;
    }
    public double GetTotalCost()
    {
        double subTotal=0;
        foreach (Product product in _products)
        {
            subTotal+=product.GetTotalCost();
        }
        if (_customer.FromUSAOrNot()==true)
        {
            subTotal+=5;
        }
        else
        {
            subTotal+=35;
        }
        return subTotal;

    }
}