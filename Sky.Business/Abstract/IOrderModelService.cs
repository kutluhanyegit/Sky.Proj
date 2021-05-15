using System.Collections.Generic;
using Sky.Entities.Concrate;

namespace Sky.Business.Abstract
{
    public interface IOrderModelService
    {
         List<OrderModel> GetAll();
         void Add(OrderModel entity);
    }
}