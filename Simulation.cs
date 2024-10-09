using System.Numerics;

namespace Simulation;

public class Simulation {
    public Recommender System;
    public Vector4[] UserOpinions { get; }
    public Vector4[] Movies { get; }

    public Simulation() {
        //add a way to get the movies
        // Movies = RetrieveMovies();
        // System = new Recommender(Movies);
        // UserOpinions = RetrieveOpinions();
    }

    // private Vector4[] RetrieveMovies();
    //
    // private Vector4[] RetrieveOpinions();
    
    //Waar we echt ff een simulatie maken
    public void Run() { }

    // public Vector4[] RandomizeUsers() { }
    
    // public double[] GenerateRatings() { }
}