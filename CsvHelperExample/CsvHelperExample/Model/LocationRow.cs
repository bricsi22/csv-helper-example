using System;

namespace CsvHelperExample.Model
{
  public class LocationRow
  {
    public Guid RowId { get; set; }
    public AddressObject Address { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
  }
}
