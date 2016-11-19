using BeYourMarket.Model.Models;
using Repository.Pattern.Repositories;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeYourMarket.Service
{
    public interface IOrderBuyCoinService : IService<OrderBuyCoin>
    {
    }

    public class OrderBuyCoinService : Service<OrderBuyCoin>, IOrderBuyCoinService
    {
        public OrderBuyCoinService(IRepositoryAsync<OrderBuyCoin> repository)
            : base(repository)
        {
        }
    }
}
