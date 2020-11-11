
using CsvHelper.Configuration;
using CsvHelperExample.Converter;
using CsvHelperExample.Model;

namespace CsvHelperExample.Mapping
{
  public class LocationRowMap : ClassMap<LocationRow>
  {
    public LocationRowMap()
    {
      Map(m => m.RowId);
      Map(m => m.Address).TypeConverter<AddressObjectConverter>();
      Map(m => m.Longitude);
      Map(m => m.Latitude);
    }
  }
}
