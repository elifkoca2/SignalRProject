using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using SinalR.DtoLayer.AboutDto;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(_mapper.Map<List<ResultAboutDto>>(values));
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto )
        {
            var value=_mapper.Map<About>(createAboutDto);
            _aboutService.TAdd(value);
            return Ok("Hakkımda kısmı başarılı bir şekilde eklendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımda alanı silindi.");
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
            return Ok("Hakkımda alanı güncellendi.");
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value= _aboutService.TGetByID(id);
            return Ok(_mapper.Map<GetAboutDto>(value));
        }
    }
}
