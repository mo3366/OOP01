using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01
{
    #region Part 01 : Theoretical Questions - Question 1
    public struct DeliveryAddress
    {
        public string City;
        public string Street;
    }
    public class Customer
    {
        public string Name;
    }
    //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
    // answer:DeliveryAddress is a struct  which is a value type  When you assign one DeliveryAddress variable
    // to another the entire contents are copied into a brand-new memory location
    // Modifying the copy afterwards only changes that copy — the original variable remain untouched.

    //b) What happens when a Customer variable is copied into another variable and one variable modifies the object
    // answer: Customer is a class, which is a reference type. Assigning one Customer variable to another just copies
    // the reference (the memory address), so both variables end up pointing to the same object. Modifying a field through
    // either variable changes the one shared object so the change is visible through both.
    #endregion
}
