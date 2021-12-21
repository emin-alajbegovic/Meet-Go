using AutoMapper;
using MeetAndGo.Model.Requests;

namespace MeetAndGo.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Database.User, Model.User>();
            CreateMap<Database.Building, Model.Building>();
            CreateMap<Database.Office, Model.Office>();
            CreateMap<Database.Role, Model.Role>();
            CreateMap<Database.City, Model.City>();
            CreateMap<Database.Transactions, Model.Transactions>();
            CreateMap<Database.TypeOfBuilding, Model.TypeOfBuilding>();
            CreateMap<Database.TypeOfOffice, Model.TypeOfOffice>();
            CreateMap<Database.UserAccount, Model.UserAccount>();

            CreateMap<OfficeUpsertRequest, Database.Office>();
            CreateMap<BuildingUpsertRequest, Database.Office>();
            CreateMap<UserUpsertRequest, Database.User>();
            CreateMap<UserAccountUpsertRequest, Database.UserAccount>();
        }
    }
}
