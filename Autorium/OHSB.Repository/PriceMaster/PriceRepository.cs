using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.IRepository.Factory;
using OHSB.IRepository.PriceMaster;
using OHSB.Domain.PriceMaster;
using Dapper;
using System.Data;

namespace OHSB.Repository.PriceMaster
{
    public class PriceRepository:RepositoryBase,IPriceRepository
    {
        public PriceRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {

        }
        public async Task<List<PriceEntity>> GetAllRow( int BlockId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
               // param.Add("@AuditoriumID", AuditoriumID);
                param.Add("@BlockId", BlockId);
                param.Add("@action", "BindRow");
                var query = "Usp_PriceMaster";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var Get = Connection.Query<PriceEntity>(query, param, commandType: CommandType.StoredProcedure).ToList();
                return Get;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<PriceEntity>>GetAllblock(int AuditoriumID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumID", AuditoriumID);
                param.Add("@action", "BindBlock");
                var query = "Usp_PriceMaster";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var Get = Connection.Query<PriceEntity>(query, param, commandType: CommandType.StoredProcedure).ToList();
                return Get;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<PriceEntity>> GetAllAuditorium()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "BindAuditorium");
                var query = "Usp_PriceMaster";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<PriceEntity>(query, param, commandType: CommandType.StoredProcedure).AsList();
                return Get;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<int> insertupdate(PriceEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PriceId", entity.PriceId);
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@BlockId", entity.BlockId);
                param.Add("@Row_No", entity.Row_No);
                param.Add("@Price", entity.Price);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.PriceId == 0)
                {
                    param.Add("@action", "InsertPrice");
                }
                else
                {
                    param.Add("@action", "UpdatePrice");
                }

                var query = "[Usp_PriceMaster]";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<PriceEntity>> GetAllPrice()
        {
            try
            {

                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<PriceEntity>("Usp_PriceMaster", param, commandType: CommandType.StoredProcedure).ToList();
                return x;


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<int> delete(PriceEntity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@PriceId", p.PriceId);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "Delete");
                Connection.Execute("[Usp_PriceMaster]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }
        public async Task<PriceEntity> Getbyid(int PriceId)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@PriceId", PriceId);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "Usp_PriceMaster";
                var GetAppById = Connection.Query<PriceEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return GetAppById;
            }
            catch (Exception ex)
            {
                return null;

            }

        }
    }
}
