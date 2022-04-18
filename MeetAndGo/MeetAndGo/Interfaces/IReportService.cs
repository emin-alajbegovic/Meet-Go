using System.Collections.Generic;

namespace MeetAndGo.Interfaces
{
    public interface IReportService
    {
        List<Model.Report.Report> GetReport();
    }
}
