using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.PresentationLayer.Models
{
    public class DashboardViewModel
    {
        public List<Artical> RecentArtical { get; set; }
        public int TotalArticles { get; set; }
        public int TotalComments { get; set; }
    }
}
