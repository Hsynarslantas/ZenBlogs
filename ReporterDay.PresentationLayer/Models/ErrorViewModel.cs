using Microsoft.AspNetCore.Identity;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.PresentationLayer.Models
{
    public class ErrorViewModel
    {
        
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
