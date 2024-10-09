using Simulation.Model;

namespace Simulation.DAO;

public interface IDataGenerator {

    public List<LatentFeature> generateFeatures();

}