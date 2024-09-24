using System.Numerics;
using System.Runtime.CompilerServices;

namespace Simulation;

public class Recommender {
    public Vector4[] Movies { get; }

    public Recommender(Vector4[] movies) {
        Movies = movies;
    }

    public void UpdatePredictions(double[] ratings) { }
}