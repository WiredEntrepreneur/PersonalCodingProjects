using System;
using System.Collections.Generic;

public class CustomerSorter : IComparer<Customer>
{
    public int Compare(Customer lhs, Customer rhs)
    {
        if(lhs == null) return -1;
        if(rhs == null) return 1;
        return lhs.FirstName.CompareTo(rhs.FirstName);
    }
}