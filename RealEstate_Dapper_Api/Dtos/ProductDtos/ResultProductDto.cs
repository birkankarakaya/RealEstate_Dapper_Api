﻿namespace RealEstate_Dapper_Api.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ProductCategory { get; set; }
    }
}
