﻿namespace WebApi.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string PaidPrice { get; set; }
        public string UnitPrice { get; set; }
        public string RemoteCode { get; set; }
        public string Description { get; set; }
        public string VatPercentage { get; set; }
        public string DiscountAmount { get; set; }
    }
}
