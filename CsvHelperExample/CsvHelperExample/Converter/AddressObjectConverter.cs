using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CsvHelperExample.Model;

namespace CsvHelperExample.Converter
{
  public class AddressObjectConverter : DefaultTypeConverter
  {
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
      var emptyObj = new AddressObject();
      // if you are reading back the CSV then additional code should be needed here
      return emptyObj;
    }

    public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
    {
      if (value != null && value is AddressObject)
      {
        var addressObject = value as AddressObject;
        return $"{addressObject.City} {addressObject.Road} {addressObject.RoadNumber}";
      }
      else
      {
        return "";
      }
    }
  }
}
