﻿namespace RealEstate_Dapper_Api.Dtos.ToDoListDtos
{
    public class UpdateToDoListDto
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
