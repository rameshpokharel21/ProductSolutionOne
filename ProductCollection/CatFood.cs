﻿/*
 * CatFood is child class of base class Product
 * It has two own Properties WeightPounds of type double and KittenFood of type bool.
 * It inherits Name of type string, Price of type decimal, Quantity of type int and Description of type string from it's parent class Product.
 */

namespace ProductCollection;

internal class CatFood(string name, decimal price, int quantity, string description, double weightPounds, bool kittenFood) : Product(name, price, quantity, description)
{
    public double WeightPounds { get; private set; } = weightPounds;
    public bool KittenFood { get; private set; } = kittenFood;
}
