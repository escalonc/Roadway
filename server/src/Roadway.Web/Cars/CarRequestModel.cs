using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Roadway.Web.Cars
{
    public class CarRequestModel
    {
        [Required]
        public string Vin { get; set; }

        [Required]
        public string LicensePlate { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Version { get; set; }

        [Required]
        [NotNull]
        public ushort? Year { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        [NotNull]
        public int? Fuel { get; set; }

        [Required]
        [NotNull]
        public int? Size { get; set; }

        [Required]
        [NotNull]
        public int? Use { get; set; }

        [Required]
        [NotNull]
        public int? CarTypeId { get; set; }

        [Required]
        [NotNull]
        public int? CustomerId { get; set; }
    }
}