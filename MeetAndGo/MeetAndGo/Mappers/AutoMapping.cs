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
            CreateMap<Database.TypeOfOffice, Model.TypeOfOffice>();
            CreateMap<Database.CanceledOffice, Model.CanceledOffice>();
            CreateMap<Database.OfficeReview, Model.OfficeReview>();
            CreateMap<Database.RentedOffice, Model.RentedOffice>()
                .ForMember(dest => dest.Office, opt => opt.MapFrom(src => src.Office.Name))
                .ForMember(dest => dest.Firstname, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(dest => dest.Picture, opt => opt.MapFrom(src => src.Office.Picture))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Office.Price))
                .ForMember(dest => dest.Adress, opt => opt.MapFrom(src => src.Office.Adress));

            CreateMap<Database.Transactions, Model.Transactions>();

            CreateMap<Database.Building, Model.Building>();
            CreateMap<Database.TypeOfBuilding, Model.TypeOfBuilding>();
            CreateMap<Database.CanceledBuilding, Model.CanceledBuilding>();
            CreateMap<Database.BuildingReview, Model.BuildingReview>();
            CreateMap<Database.RentedBuilding, Model.RentedBuilding>()
                .ForMember(dest => dest.Building, opt => opt.MapFrom(src => src.Building.Name))
                .ForMember(dest => dest.Firstname, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(dest => dest.Picture, opt => opt.MapFrom(src => src.Building.Picture))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Building.Price))
                .ForMember(dest => dest.Adress, opt => opt.MapFrom(src => src.Building.Adress));

            CreateMap<Database.User, Model.User>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.UserAccount.Email));
            CreateMap<Database.UserAccount, Model.UserAccount>();
            CreateMap<Database.UserAccountRole, Model.UserAccountRole>();
            CreateMap<Database.Role, Model.Role>();

            CreateMap<OfficeUpsertRequest, Database.Office>();
            CreateMap<BuildingUpsertRequest, Database.Building>();
            CreateMap<UserUpsertRequest, Database.User>();
            CreateMap<UserAccountUpsertRequest, Database.UserAccount>();
            CreateMap<UserAccountRoleUpsertRequest, Database.UserAccountRole>();
        }
    }
}
