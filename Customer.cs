using System;

public class Customer : 
//IComparable, 
IComparable<Customer>
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Customer(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public override string ToString()
    {
        return LastName + ", " + FirstName;
    }

  /*   public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        var cust = obj as Customer;
        if (cust != null)
        {
            return this.LastName.CompareTo(cust.LastName);
        }
        else
        {
            throw new ArgumentException("Object not of type cusomter");
        }
    } */

    public int CompareTo(Customer customer)
    {
        if (customer == null) return 1;

        return this.LastName.CompareTo(customer.LastName);


    }
}
