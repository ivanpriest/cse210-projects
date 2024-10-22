using System;

class Program
{
    static void Main(string[] args)
    {
        Address customerAddress1= new Address("Abeka","Accra","Greater Accra","Ghana");
        Customer customer1= new Customer("Ivan",customerAddress1);
        Product product1 =new Product("Egg","eg",2.0,10);
        Product product2 =new Product("Bread","brd",5.0,2);
        Product product3 =new Product("Milk","mlk",10.0,1);
        Product product4 =new Product("Coffee","cfe",3.0,5);
        Order order1 =new Order(customer1,product1);
        order1.AddProduct(product2);
        Order order2 =new Order(customer1,product3);
        order2.AddProduct(product4);
        string packingLabel1= order1.GetPackingLabel();
        string packingLabel2= order2.GetPackingLabel();
        string shippingLabel1= order1.GetShippingLabel();
        string shippingLabel2=order2.GetShippingLabel();
        double subTotal1=order1.GetTotalCost();
        double subTotal2=order2.GetTotalCost();
        Console.WriteLine($"{packingLabel1}\n{shippingLabel1}\nSubtotal= ${subTotal1}\n\n{packingLabel2}\n{shippingLabel2}\nSubtotal= ${subTotal2}");

    }
}

