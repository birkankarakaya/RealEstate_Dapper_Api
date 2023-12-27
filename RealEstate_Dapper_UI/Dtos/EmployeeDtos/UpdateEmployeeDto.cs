namespace RealEstate_Dapper_UI.Dtos.EmployeeDtos
{
    public class UpdateEmployeeDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
        public string imageUrl { get; set; }
        public bool status { get; set; }
    }
}
