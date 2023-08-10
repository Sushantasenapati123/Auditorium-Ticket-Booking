using Auditorium.Domain.BookingMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.IRepository.Booking
{
    public interface BookingIRepository
    {
        Task<int> CreateBooking(int Id, DateTime BookingDate, string UserId, int AuditoriumId,int BlockId, int RowId, int SeatId);
        Task<List<BookingMaster>> GetAll(); 
        Task<List<BookingMaster>> ViewTicket(int NoOfTicket,DateTime date,string userid);
        Task<int> Delete(int Id);
        Task<BookingMaster> Getbyid(int id);
        Task<List<BookingMaster>> GetBookedSeatsForAuditorium(int AuditoriumId,DateTime BookingDate);
    }
}
