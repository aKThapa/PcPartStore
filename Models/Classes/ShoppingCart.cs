using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PCpartStore.Models
{
    public class ShoppingCart
    {
        private static List<Parts> parts = new List<Parts>();

        public void AddItem(Parts part)
        { 
            parts.Add(part);
        }

        public void DeleteItem(int id)
        {
            var toDelete = parts.Find(d => d.ID == id);
            parts.Remove(toDelete);
        }

        public List<Parts> ShoppingCartSummary()
        {
            return parts;
        }

        //This method purely exists for debugging
        public void DisplayFor(int id)
        {
            var item = parts.Find(x => x.ID == id);
            Debug.WriteLine("Name : " + item.Name);
            Debug.WriteLine("Price : £" + item.Price);
            Debug.WriteLine("ID : " + item.ID);
        }

        public int TotalItems()
        {
            return parts.Count;
        }


        public decimal ComputeTotalValue()
        {
            return parts.Sum(t => t.Price);
        }

        public void RemoveItemFromCart(int productID)
        {
            parts.RemoveAll(p => p.ID == productID);
        }

        
    }
}