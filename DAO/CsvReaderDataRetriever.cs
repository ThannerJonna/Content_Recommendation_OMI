using System.Globalization;
using Simulation.Model;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using CsvHelper.Configuration;


namespace Simulation.DAO;

public class CsvReaderDataRetriever : IDataRetriever {
    string filePath;

    public CsvReaderDataRetriever(string filePath) {
        this.filePath = filePath;
    }

    public List<LatentFeature> getFeatures()
    {
          var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true 
                    
                };
        List<MovieLatentFeature> movieLatentFeatures = new List<MovieLatentFeature>();
        

        using (StreamReader reader = new StreamReader(filePath))
        using (CsvReader csv = new CsvReader(reader, config)
               )
        {
            //csv.Configuration.HasHeaderRecord = true; // Assuming the CSV file has a header
            List<MovieLatentFeature> records = csv.GetRecords<MovieLatentFeature>().ToList();
            movieLatentFeatures = records;
            // foreach (var record in records)
            // {
            //     // Create a MovieLatentFeature object from the CSV record
            //     var movieLatentFeature = new MovieLatentFeature(record.Key);
            //     movieLatentFeature.values = new double[] { record.Action, record.Comedy, record.Romance, record.Horror };
            //     
            //     movieLatentFeatures.Add(movieLatentFeature);
            // }
        }

        List<LatentFeature> latentFeatures = movieLatentFeatures.Cast<LatentFeature>().ToList();
        return latentFeatures;
    }


    public List<LatentFeature> generateFeatures(string fileNamebool) {
        throw new NotImplementedException();
    }
}