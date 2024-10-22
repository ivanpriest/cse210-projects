public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product ()
    {

    }
    public Product (string name,string id,double price,int quantity)
    {
        _name=name;
        _id=id;
        _price=price;
        _quantity=quantity;
    }
    public void SetName(string name)
    {
       _name=name;
    }
    public void SetId(string id)
    {
       _id=id;
    }
    public void SetPrice(float price)
    {
       _price=price; 
    }
    public void SetQuantity(int quantity)
    {
       _quantity=quantity ;
    }
    public string GetName()
    {
       return _name;
    }
     public string GetId()
    {
        return _id;
    }
     public double  GetPrice()
    {
        return _price;
    }
     public int GetQuantity()
    {
        return _quantity; 
    }

    public double GetTotalCost()
    {
        double totalCost;
        totalCost=_price*_quantity;
        return totalCost;
    }



}