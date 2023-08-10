
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OHSB.Repository.Factory;
using OHSB.IRepository.Factory;
using OHSB.IRepository.OHSB_IRepository;
using OHSB.Repository.OHSB_Repository;
using OHSB.Repository.EmployeeMaster;
using OHSB.IRepository.Employee_Master;
using OHSB.IRepository.RowMaster;
using OHSB.Repository.RowMaster;
using OHSB.Repository.AuditoriumMaster;
using OHSB.IRepository.AuditoriumIRepository;
using OHSB.IRepository.Row_SeatMaster;
using OHSB.Repository.Row_SeatMaster;
using OHSB.Repository.SlotMaster;
using OHSB.IRepository.SlotMaster;
using OHSB.IRepository.ShowsMaster;
using OHSB.Repository.ShowsMaster;
using OHSB.Repository.SlotMappingMaster;
using OHSB.IRepository.SlotMappingMaster;
using OHSB.IRepository.MenuMaster;
using OHSB.Repository.MenuMaster;
using OHSB.IRepository.SubMenuMaster;
using OHSB.Repository.SubMenuMaster;
using OHSB.Repository.PermissionMaster;
using OHSB.IRepository.PermissionMaster;
using OHSB.IRepository.SeatMaster;
using OHSB.Repository.SeatMaster;
using OHSB.IRepository.BlockMaster;
using OHSB.Repository.BlockMaster;
using OHSB.IRepository.BlockRowMapping;
using OHSB.Repository.BlockRowMapping;
using OHSB.Repository.Show_Master;
using OHSB.IRepository.Show_Master;
using OHSB.IRepository.ScreenMap;
using OHSB.Repository.ScreenMap;
using OHSB.IRepository.PriceMaster;
using OHSB.Repository.PriceMaster;
using Auditorium.IRepository.Auditorium;
using Auditorium.Repository.AuditoriumRepository;

using Auditorium.IRepository.Booking;
using Auditorium.Repository.BookingRepository;
using Auditorium.IRepository.ShowSelectIRepo;
using Auditorium.Repository.ShowSelectMasterRepository;
using OHSB.IRepository.Block;
using OHSB.Repository.BlockRepository;
using Auditorium.IRepository.Seat;
using Auditorium.Repository.SeatRepository;

namespace OHSB.Web.DIContainer
{
    public static class CustomContainer
    {
        public static void AddCustomContainer(this IServiceCollection services, IConfiguration configuration)
        {
            IConnectionFactory connectionFactory = new ConnectionFactory(configuration.GetConnectionString("DefaultConnection"));
            services.AddSingleton(connectionFactory);
            services.AddSingleton<IOHSB_Master, OHSB_Repo>();
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            services.AddSingleton<IRowSeatRepo, RowSeatRepository>();
            services.AddSingleton<ISlotRepository, SlotRepository>();
            services.AddSingleton<IShowRepository, ShowsRepository>();
            services.AddSingleton<ISlotMapping, SlotMappingRepo>();
            //Authentication
            services.AddSingleton<IMenuRepository, MenuRepository>();
            services.AddSingleton<ISubMenuRepo, SubMenuRepository>();
            services.AddSingleton<IPermissionRepo, PermissionRepository>();

            //new
            services.AddSingleton<IRowRepository, RowRepository>();
            services.AddSingleton<IAuditoriumRepo, AuditoriumRepository>();
            services.AddSingleton<ISeatRepo, SeatRepository>();
            services.AddSingleton<IBlockRepo, BlockRepository>();
            services.AddSingleton<IBlockMappingRepository, BlockRowRepository>();
            services.AddSingleton<IShow_Master, Show_MasterRepository>();
            services.AddSingleton<IScreenMap, ScreenMapRepository>();
            services.AddSingleton<IPriceRepository, PriceRepository>();



            services.AddSingleton<AuditoriumIRepository, AuditoriumRepo>();
            //services.AddSingleton<RowIRepository, RowRepository>();
            services.AddSingleton<SeatIRepository, SeatRepositoryy>();
            //services.AddSingleton<BlockIRepository, BlockRepository>();
            //services.AddSingleton<ShowsIRepository, ShowsRepository>();
           
            services.AddSingleton<ShowSelectIRepository, ShowSelectMasterRepository>();
            //services.AddSingleton<UserLoginIRepository, UserLoginRepository>();
            services.AddSingleton<BookingIRepository, BookingRepository>();
            services.AddSingleton<BlockIRepository, BlockRepositoryy>();

        }
    }
}
