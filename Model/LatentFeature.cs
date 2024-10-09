
using System.Numerics;

namespace Simulation.Model;

public class LatentFeature{
    
    public LatentFeature(int amount) {
        values = new double[amount];
    }
    
    public int key { get; set; }
    public double[] values { get; }
    
    
    
}

