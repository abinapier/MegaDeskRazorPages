using System;
namespace MegaDesk.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int DrawerCount { get; set; }
        public SurfaceMaterial DeskSurfaceMaterial { get; set; }
        public int OrderTime { get; set; }
        public double DeskQuote { get; set; }
        
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
