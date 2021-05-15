using System.Collections.Generic;
using Sky.Business.Abstract;
using Sky.DataAccess.Abstract;
using Sky.DataAccess.Concrate.EntityFramework;
using Sky.Entities.Concrate;

namespace Sky.Business.Concrate
{
    public class OrderModelManager : IOrderModelService
    {
        IOrderModelDal _orderModelDal;

        public OrderModelManager(IOrderModelDal orderModelDal)
        {
            _orderModelDal = orderModelDal;
        }

        public void Add(OrderModel entity)
        {
            throw new System.NotImplementedException();
        }

        public List<OrderModel> GetAll()
        {
            return _orderModelDal.GetAll();
        }
    }
}