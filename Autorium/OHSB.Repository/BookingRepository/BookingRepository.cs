using Auditorium.Domain.BookingMaster;
using Auditorium.IRepository.Booking;

using Dapper;
using OHSB.IRepository.Factory;
using OHSB.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.Repository.BookingRepository
{
    public class BookingRepository : RepositoryBase, BookingIRepository
    {
        public BookingRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public async Task<int> CreateBooking(int Id, DateTime BookingDate, string UserId, int AuditoriumId, int BlockId, int RowId, int SeatId)
        {
            try
            {
                int result = 0;
                //foreach (int row in RowId)
                //{
                //    foreach (int seat in SeatId)
                //    {
                        DynamicParameters param = new DynamicParameters();
                        param.Add("@Id", Id);
                        param.Add("@BookingDate", BookingDate);
                        param.Add("@UserId", UserId);
                        param.Add("@AuditoriumId", AuditoriumId);
                        param.Add("@BlockId", BlockId);
                        param.Add("@RowId", RowId);
                        param.Add("@SeatId", SeatId);
                        param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                        if (Id == 0)
                        {
                            param.Add("@action", "InsertBooking");
                        }
                        else
                        {
                            param.Add("@action", "UpdateBooking");
                        }
                        var query = "SP_Booking";
                        Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                        result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                //    }
                //}
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<BookingMaster>> GetAll()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<BookingMaster>("SP_Booking", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public async Task<List<BookingMaster>> ViewTicket(int NoOfTicket, DateTime date, string userid)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                
                 param.Add("@UserId", userid);
                param.Add("@BookingDate", date);
                param.Add("@NoOfTicket", NoOfTicket);
                param.Add("@action", "Ticket");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<BookingMaster>("SP_Booking", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> Delete(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "D");
                Connection.Execute("SP_Booking", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }
        public async Task<BookingMaster> Getbyid(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@Id", id);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "SP_Booking";
                var GetAppById = Connection.Query<BookingMaster>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }
        }
        public async Task<List<BookingMaster>> GetBookedSeatsForAuditorium(int AuditoriumId,DateTime BookingDate)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumId", AuditoriumId);
                param.Add("@BookingDate", BookingDate);
                param.Add("@action", "BookedSeat");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<BookingMaster>("SP_Booking", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
