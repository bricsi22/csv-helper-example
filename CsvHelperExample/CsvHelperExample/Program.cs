

using CsvHelper;
using CsvHelper.Configuration;
using CsvHelperExample.Mapping;
using CsvHelperExample.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CsvHelperExample
{
  class Program
  {
    static void Main(string[] args)
    {
      var locationRowList = new List<LocationRow>();

      #region Location Row List initialization
      locationRowList.Add(new LocationRow
      {
        RowId = Guid.NewGuid(),
        Address = null,
        Latitude = 10,
        Longitude = 20
      });

      locationRowList.Add(new LocationRow
      {
        RowId = Guid.NewGuid(),
        Address = new AddressObject {
          City = "Győr",
          Road = "Vámbéry Ármin street",
          RoadNumber = 51
        },
        Latitude = 10,
        Longitude = 20
      });

      locationRowList.Add(new LocationRow
      {
        RowId = Guid.NewGuid(),
        Address = new AddressObject
        {
          City = "Győr",
          Road = "Vámbéry Ármin street",
          RoadNumber = 51
        },
        Latitude = null,
        Longitude = null
      });

      locationRowList.Add(new LocationRow
      {
        RowId = Guid.NewGuid(),
      });
      #endregion

      using (var writer = new StreamWriter(@"D:\temp\NullValuesTest.csv")) {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
        csvConfig.RegisterClassMap<LocationRowMap>();
        using (var csv = new CsvWriter(writer, csvConfig))
        {
          csv.WriteRecords(locationRowList);
        }
      }
    }
  }
}
