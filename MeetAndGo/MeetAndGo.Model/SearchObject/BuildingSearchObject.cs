namespace MeetAndGo.Model.SearchObject
{
    public class BuildingSearchObject
    {
        public string Name { get; set; }
        public int? TypeOfBuildingId { get; set; }
        public int? CityId { get; set; }
        public bool? IncludeTypeOfBuilding { get; set; }

    }
}
