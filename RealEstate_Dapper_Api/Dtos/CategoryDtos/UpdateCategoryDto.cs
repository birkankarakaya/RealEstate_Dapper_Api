namespace RealEstate_Dapper_Api.Dtos.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
