using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

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
    
        //se agrega metodo AsText para saber el string de la publicacion.
        public string AsText()
        {
        
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Publicacion");
            sb.AppendLine("Fecha de finalizacion: " + this.EndDate);
            sb.AppendLine("Items:");
            foreach (PublicationItem item in this.items)
            {
                sb.AppendLine(item.Price+ " " + item.Material.Name + " " + item.Quantity);
            }
            return sb.ToString();
        }

    }
}