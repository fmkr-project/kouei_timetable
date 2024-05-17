using System.Collections;

namespace Planner.Models;

public static class StationTable
{
    public static HashSet<Station> Stations = new();

    public static void PopulateHashTable()
    {
        Stations = new HashSet<Station>();
        foreach (var sta in StationParser.GetStations())
        {
            Stations.Add(sta);
        }
    }
}