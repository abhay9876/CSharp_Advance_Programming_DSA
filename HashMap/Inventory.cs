/*Inventory Management System
Use Case: Maintain a mapping of product IDs to product information.
OOP Concepts:
● Interface: Product
● Encapsulation: Inventory manager manages internal map.
● Abstraction: Simple add(), get() interface.
● Polymorphism: Products can be electronics, clothing, etc.*/

using System;

public interface Product
{
	void Details();
}

public interface Inventory
{
	void Add(int id, Product product);
	Product Get(int id);
}

public class Electronics : Product
{
	private string name;
    private double price;
	public Electronics(string name, double price)
	{
		this.name = name;
		this.price = price;
	}

	public void Details()
	{
		Console.WriteLine($"Name : {name}  Price : {price} ");
	}

}

public class Cloths : Product
{
    private string name;
    private double price;
    public Cloths(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public void Details()
    {
        Console.WriteLine($"Name : {name}  Price : {price} ");
    }

}



public class InventoryManager : Inventory
{
	private Dictionary<int, Product> inventory = new Dictionary<int, Product>();

	public void Add(int id , Product product)
	{
		inventory[id] = product;
		Console.WriteLine($"product {id} added in inventory");
	}

    public Product Get(int id)
    {
        if (inventory.ContainsKey(id))
        {
            return inventory[id];
        }
        return null;
    }
}
