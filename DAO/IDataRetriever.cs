using Simulation.Model;

namespace Simulation.DAO;

public interface IDataRetriever {


	List<LatentFeature> getFeatures();


	List<LatentFeature> generateFeatures(string fileNamebool);
}