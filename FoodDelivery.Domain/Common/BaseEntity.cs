using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastDateModified{ get; set; }
    }
}
