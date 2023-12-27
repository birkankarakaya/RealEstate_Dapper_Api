using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDtos;
using RealEstate_Dapper_Api.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreController : ControllerBase
    {
        private readonly IWhoWeAreRepository _whoWeAreRepository;

        public WhoWeAreController(IWhoWeAreRepository whoWeAreRepository)
        {
            _whoWeAreRepository = whoWeAreRepository;
        }

        [HttpGet]
        public async Task<IActionResult> whoWeAreList()
        {
            var values = await _whoWeAreRepository.GetAllWhoWeAreAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAre(CreateWhoWeAreDto createWhoWeAreDto)
        {
            _whoWeAreRepository.CreateWhoWeAre(createWhoWeAreDto);
            return Ok("Biz Kimiz başarıyla eklendi!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWhoWeAre(int id)
        {
            _whoWeAreRepository.DeleteWhoWeAre(id);
            return Ok("Biz Kimiz başarıyla silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAre(UpdateWhoWeAreDto updateWhoWeAreDto)
        {
            _whoWeAreRepository.UpdateWhoWeAre(updateWhoWeAreDto);
            return Ok("Biz Kimiz başarıyla güncellendi!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAre(int id)
        {
            var value = await _whoWeAreRepository.GetWhoWeAre(id);
            return Ok(value);
        }
    }
}
