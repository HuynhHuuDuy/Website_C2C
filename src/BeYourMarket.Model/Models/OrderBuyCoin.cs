using System;
using System.Collections.Generic;

namespace BeYourMarket.Model.Models
{

    public partial class OrderBuyCoin : Repository.Pattern.Ef6.Entity
    {
        public OrderBuyCoin() { }
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public double Price { get; set; }
        public int Coins { get; set; }
        public string UserBuyCoin { get; set; }
        public virtual AspNetUser AspNetUserBuyCoin { get; set; }
    }
}
