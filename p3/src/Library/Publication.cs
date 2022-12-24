using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }
        //segun el patron expert, la clase Publication es la experta en calcular el total ya que contiene la informacion de los items.
        public int Total
        {
            get
            {
                int total = 0;
                foreach (PublicationItem item in this.items)
                {
                    total += item.Quantity * item.Price;
                }
                return total;
            }
        }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }

       
    
    }

}