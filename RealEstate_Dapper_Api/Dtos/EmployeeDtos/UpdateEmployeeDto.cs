namespace RealEstate_Dapper_Api.Dtos.EmployeeDtos
{
    public class UpdateEmployeeDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
