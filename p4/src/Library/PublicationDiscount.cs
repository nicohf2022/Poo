using System;
using System.Text;
using System.Collections.Generic;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount: IPublicationItem
    {
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
            if (value >=0)
            {
                throw new ArgumentException("El valor  tiene que ser negativo");
                
            }
            this.amount=value;
            }
        }

        public PublicationDiscount(int amount)
        {
            this.SubTotal = amount;
        }
    }
}