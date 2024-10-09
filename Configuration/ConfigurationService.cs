using Simulation.DAO;
using Microsoft.Extensions.Configuration;
using System.IO;
using Simulation.Configuration;
using Simulation.Model;

namespace Simulation;

public class ConfigurationService {
    IConfiguration                config;

    public ConfigurationService(string filePath) {
        // Sets the base path for file location
        this.config           = new ConfigurationFact().GetConfigurationRoot(filePath);
    }

    public IDataRetriever getDAO(Type featureType) {
         
        string daoType = config["AppSettings:ServiceType"];

        IDataRetriever result = null; 
        switch ((daoType, featureType)) {
            case (string daoT, Type featureT) when daoT == "" && featureT == typeof(LatentFeature):
                 result = new CsvReaderDataRetriever("");
                break;
        }
        return result;
    } 
    
}
