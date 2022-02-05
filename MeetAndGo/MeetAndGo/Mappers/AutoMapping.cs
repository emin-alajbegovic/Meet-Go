using AutoMapper;
using MeetAndGo.Model.Requests;

namespace MeetAndGo.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Database.Country, Model.Country>();
            CreateMap<Database.City, Model.City>();

            CreateMap<Database.Office, Model.Office>();
            CreateMap<Database.RentedOffice, Model.RentedOffice>();
            CreateMap<Database.TypeOfOffice, Model.TypeOfOffice>();
            CreateMap<Database.CanceledOffice, Model.CanceledOffice>();
            CreateMap<Database.OfficeReview, Model.OfficeReview>();

            CreateMap<Database.Transactions, Model.Transactions>();

            CreateMap<Database.Building, Model.Building>();
            CreateMap<Database.RentedBuilding, Model.RentedBuilding>();
            CreateMap<Database.TypeOfBuilding, Model.TypeOfBuilding>();
            CreateMap<Database.CanceledBuilding, Model.CanceledBuilding>();
            CreateMap<Database.BuildingReview, Model.BuildingReview>();

            CreateMap<Database.User, Model.User>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.UserAccount.Email));
            CreateMap<Database.UserAccount, Model.UserAccount>();
            CreateMap<Database.UserAccountRole, Model.UserAccountRole>();
            CreateMap<Database.Role, Model.Role>();

            CreateMap<OfficeUpsertRequest, Database.Office>();
            CreateMap<BuildingUpsertRequest, Database.Building>();
            CreateMap<UserUpsertRequest, Database.User>();
            CreateMap<UserAccountUpsertRequest, Database.UserAccount>();
        }
    }
}
