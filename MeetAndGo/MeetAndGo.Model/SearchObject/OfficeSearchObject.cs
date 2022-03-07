namespace MeetAndGo.Model.SearchObject
{
    public class OfficeSearchObject
    {
        public string Name { get; set; }
        public int? TypeOfOfficeId { get; set; }
        public int? CityId { get; set; }
        public bool? IncludeTypeOfOffice { get; set; }
    }
}
