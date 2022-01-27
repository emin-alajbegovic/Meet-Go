namespace MeetAndGo.Model.Requests
{
    public class OfficeUpsertRequest
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Area { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public bool Rented { get; set; }
        public int NumberOfFloors { get; set; }
        public int CityId { get; set; }
        public int TypeOfOfficeId { get; set; }
        public bool IsDeleted { get; set; }
        public bool Parking { get; set; }
        public bool Cameras { get; set; }
    }
}
