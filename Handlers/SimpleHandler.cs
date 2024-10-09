using Simulation.DAO;
using Simulation.Model;

namespace Simulation.Handlers;

public class SimpleHandler : IHandler {
    
    private ConfigurationService configurationService;
    public SimpleHandler(ConfigurationService configurationService) {
        configurationService = configurationService;
    }

    public void handle(int loopAmount) {
        IDataRetriever                dataRetriever            = configurationService.getDAO(typeof(MovieLatentFeature));
        List<LatentFeature> latentFeatures = dataRetriever.getFeatures();
    }
}