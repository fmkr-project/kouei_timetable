namespace Planner.Models;

public static class StationParser
// Parser for the Data/Stations station file
{
    public static IEnumerable<Station> GetStations()
    {
        const string path = @"Data/Stations";

        if (!File.Exists(path))
            throw new FileNotFoundException("Stations file does not exist!");

        using var sr = new StreamReader(path);
        string line;
        while ((line = sr.ReadLine()) is not null)
        {
            // Lines starting with # are comments
            if (line[0] == '#') continue;
            var split = line.Split('・');
            yield return new Station(split[0], split[1], split[2]);
        }
    }
}