using System;
using Sky.Entities.Abstract;

namespace Sky.Entities.Concrate
{
    public class OrderModel:IEntity
    {
        public Guid id { get; set; }
        public string CompanyName { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string DeliveryDate { get; set; }
    }
}