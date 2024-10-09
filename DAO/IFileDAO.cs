using Simulation.Model;

namespace Simulation.DAO;

public interface IFileDAO {

    public void saveFeaturesToFile(List<LatentFeature> features, string filePath);

}