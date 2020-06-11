using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MegaDesk.Models
{
    public class Quote
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Range(24, 96)]
        [Display(Name = "Width (in)")]
        public int DeskWidth { get; set; }

        [Range(12, 48)]
        [Display(Name = "Depth (in)")]
        public int DeskDepth { get; set; }

        [Range(0, 7)]
        [Display(Name = "# Drawers")]
        public int DrawerCount { get; set; }

        [Display(Name = "Material")]
        public SurfaceMaterial DeskSurfaceMaterial { get; set; }

        [Display(Name = "Order Speed (days)")]
        public int OrderTime { get; set; }

        [Display(Name = "Quote")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DeskQuote { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

    }
    public enum SurfaceMaterial
    {
        laminate,
        oak,
        rosewood,
        veneer,
        pine
    }

    
}
