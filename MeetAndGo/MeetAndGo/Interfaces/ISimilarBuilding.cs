using System.Collections.Generic;

namespace MeetAndGo.Interfaces
{
    public interface ISimilarBuilding
    {
        List<Model.Building> GetAll(int id);
    }
}
