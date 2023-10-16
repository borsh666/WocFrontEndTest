using System.ComponentModel.DataAnnotations;

namespace BlazorTempFrontEnd.Models
{
    public enum ReportType
    {
         GSM, GSM_GL, UMTS, LTE, ALL, ALL_GL
    }
    public class ReportInfo
    {
        [Required]
        [RegularExpression(@"([A-Z]{2}[\d]{4})+", ErrorMessage = "SiteID name contains invalid characters. Example: SF1001")]
        public string SiteId { get; set; }

        [Required]
        public ReportType ReportType { get; set; }

    }
}
