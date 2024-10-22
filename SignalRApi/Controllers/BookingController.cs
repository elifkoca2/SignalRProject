using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using SinalR.DtoLayer.BookingDto;
using System.Net.Mail;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList() 
        {
            var values = _bookingService.TGetListAll();
            return Ok(values); 
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
           Booking booking = new Booking();
            {
                booking.Mail = createBookingDto.Mail;
                booking.Date = createBookingDto.Date;
                booking.Name = createBookingDto.Name;
                booking.PersonCount = createBookingDto.PersonCount;
                booking.Phone = createBookingDto.Phone;
            };

            _bookingService.TAdd(booking);
            return Ok("Rezervasyon yapıldı.");
        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id) 
        {
           var value= _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
           return Ok("Rezervasyon silindi.");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        { 
            Booking booking=new Booking();
            {
                booking.Mail =updateBookingDto.Mail;
                booking.BookingID = updateBookingDto.BookingID;
                booking.Name=updateBookingDto.Name;
                booking.PersonCount =updateBookingDto.PersonCount;
                booking.Phone=updateBookingDto.Phone;
                booking.Date=updateBookingDto.Date;
            };

            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon güncellendi");
        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id) 
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }
    }
}
