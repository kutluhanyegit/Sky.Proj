using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Sky.DataAccess.Abstract;
using Sky.Entities.Concrate;

namespace Sky.DataAccess.Concrate.EntityFramework
{
    public class EfOrderModelDal : IOrderModelDal
    {
        public void Add(OrderModel entity)
        {
            using (appDbContext context = new appDbContext())
            {
                context.OrderModels.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(OrderModel entity)
        {
            throw new NotImplementedException();
        }

        public OrderModel Get(Expression<Func<OrderModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> GetAll(Expression<Func<OrderModel, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderModel entity)
        {
            throw new NotImplementedException();
        }
    }
}