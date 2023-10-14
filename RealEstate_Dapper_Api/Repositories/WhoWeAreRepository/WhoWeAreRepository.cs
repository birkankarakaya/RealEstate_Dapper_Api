using Dapper;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.WhoWeAreRepository
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;

        public WhoWeAreRepository(Context context)
        {
            _context = context;
        }
        public async void CreateWhoWeAre(CreateWhoWeAreDto createWhoWeAreDto)
        {
            string query = "INSERT INTO WhoWeAre (Title, Subtitle, Description1, Description2) VALUES (@title, @subTitle, @description1, @description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createWhoWeAreDto.Title);
            parameters.Add("@subTitle", createWhoWeAreDto.Subtitle);
            parameters.Add("@description1", createWhoWeAreDto.Description1);
            parameters.Add("@description2", createWhoWeAreDto.Description2);
            

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAre(int id)
        {
            string query = "DELETE  FROM WhoWeAre WHERE ID = @whoWeAreID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDto>> GetAllWhoWeAreAsync()
        {
            string query = "SELECT * FROM WhoWeAre";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdWhoWeAreDto> GetWhoWeAre(int id)
        {
            string query = "SELECT * FROM WhoWeAre WHERE ID = @whoWeAreID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdWhoWeAreDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAre(UpdateWhoWeAreDto updateWhoWeAreDto)
        {
            string query = "UPDATE WhoWeAre SET Title=@title, Subtitle=@subTitle, Description1 = @description1, Description2 = @description2 WHERE ID = @whoWeAreID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateWhoWeAreDto.Title);
            parameters.Add("@subTitle", updateWhoWeAreDto.Subtitle);
            parameters.Add("@description1", updateWhoWeAreDto.Description1);
            parameters.Add("@description2", updateWhoWeAreDto.Description2);
            parameters.Add("@whoWeAreID", updateWhoWeAreDto.ID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
