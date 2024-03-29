﻿/*
 * This is a base class with 4 Properties with both readable and writable accessors
 */

namespace ProductCollection;


internal class Product(string name, decimal price, int quantity, string description)
{

    public string Name { get; private set; } = name;

    public decimal Price { get; private set; } = price;
    public int Quantity { get; private set; } = quantity;
    public string Description { get; private set; } = description;
}
