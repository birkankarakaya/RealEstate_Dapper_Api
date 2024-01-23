using Dapper;
using RealEstate_Dapper_Api.Dtos.EmployeeDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmployee(CreateEmployeeDto employeeDto)
        {
            string query = "INSERT INTO Employee (Name, Title, Mail, Phone, ImageUrl, Status) VALUES (@name, @title, @mail, @phone, @imageUrl, @status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", employeeDto.name);
            parameters.Add("@title", employeeDto.title);
            parameters.Add("@mail", employeeDto.mail);
            parameters.Add("@phone", employeeDto.phone);
            parameters.Add("@imageUrl", employeeDto.imageUrl);
            parameters.Add("@status", true);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployee(int id)
        {
            string query = "DELETE  FROM Employee WHERE ID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "SELECT * FROM Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdEmployeeDto> GetEmployee(int id)
        {
            string query = "SELECT * FROM Employee WHERE ID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdEmployeeDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployee(UpdateEmployeeDto employeeDto)
        {
            string query = "UPDATE Employee SET Name = @name, Title = @title, Mail = @mail, Phone = @phone, ImageUrl = @imageUrl, Status = @status WHERE ID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@name", employeeDto.name);
            parameters.Add("@title", employeeDto.title);
            parameters.Add("@mail", employeeDto.mail);
            parameters.Add("@phone", employeeDto.phone);
            parameters.Add("@imageUrl", employeeDto.imageUrl);
            parameters.Add("@status", employeeDto.status);
            parameters.Add("@employeeID", employeeDto.id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
