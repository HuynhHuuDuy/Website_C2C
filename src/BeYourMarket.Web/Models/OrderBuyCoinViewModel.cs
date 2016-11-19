using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeYourMarket.Model.Models;

namespace BeYourMarket.Web.Models
{
    public class OrderBuyCoinViewModel
    {
        public OrderBuyCoinViewModel() { }

        public OrderBuyCoinViewModel(OrderBuyCoin obj) 
        {
            ID = obj.ID;
            Date = obj.Date;
            Price = obj.Price;
            Coins = obj.Coins;
            UserBuyCoin = obj.UserBuyCoin;
        }

        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public double Price { get; set; }
        public int Coins { get; set; }
        public string UserBuyCoin { get; set; }
    }
}