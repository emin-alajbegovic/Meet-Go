using System.Collections.Generic;

namespace MeetAndGo.Interfaces
{
    public interface ISimilarOffice
    {
        List<Model.Office> GetAll(int id);
    }
}
