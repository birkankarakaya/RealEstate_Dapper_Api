﻿namespace RealEstate_Dapper_UI.Dtos.ContactDtos
{
    public class ResultLastFourContactDto
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
