﻿namespace RealEstate_Dapper_Api.Dtos.WhoWeAreDtos
{
    public class GetByIdWhoWeAreDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }
}