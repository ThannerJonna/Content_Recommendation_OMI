using Microsoft.Extensions.Configuration;

namespace Simulation.Configuration;

public class ConfigurationFact {
    public ConfigurationFact() {
    }

    public IConfiguration GetConfigurationRoot(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentException("The configuration file name cannot be null or empty.", nameof(fileName));
        }

        // Check if the file exists
        if (!File.Exists(fileName))
        {
            throw new FileNotFoundException($"The configuration file '{fileName}' was not found.");
        }

        var currentDirectory = Directory.GetCurrentDirectory();

        // Create a ConfigurationBuilder and add the JSON file to it
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(currentDirectory)  // Set the base path to the current directory
            .AddJsonFile(fileName, optional: false, reloadOnChange: true)  // Add the JSON configuration file
            .Build();  // Build the configuration

        return config;
    }
}