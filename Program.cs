
using System;
using Simulation.DAO;

namespace Simulation;

class Program {
    
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Moon!");
        Simulation           simulation           = new Simulation();
        ConfigurationService configurationService = new ConfigurationService("C:\\Users\\carov\\University\\OnderzoeksMethoden2\\Content_Recommendation_OMI\\Configuration\\Test.json");
        IDataRetriever                  dataRetriever                  = configurationService.getDAO();
    }
    
    //paar generate functions voor users of movies
    
}
