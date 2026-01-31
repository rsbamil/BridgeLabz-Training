using System.Collections.Generic;

public class VesselUtil
{
    private List<Vessel> vesselList = new List<Vessel>();

    public List<Vessel> VesselList
    {
        get { return vesselList; }
        set { vesselList = value; }
    }

    // Requirement 1
    public void AddVesselPerformance(Vessel vessel)
    {
        vesselList.Add(vessel);
    }

    // Requirement 2
    public Vessel GetVesselById(string vesselId)
    {
        foreach (Vessel v in vesselList)
        {
            if (v.VesselId.Equals(vesselId))
            {
                return v;
            }
        }
        return null;
    }

    // Requirement 3
    public List<Vessel> GetHighPerformanceVessels()
    {
        List<Vessel> result = new List<Vessel>();

        if (vesselList.Count == 0)
        {
            return result;
        }

        double maxSpeed = vesselList[0].AverageSpeed;

        foreach (Vessel v in vesselList)
        {
            if (v.AverageSpeed > maxSpeed)
            {
                maxSpeed = v.AverageSpeed;
            }
        }

        foreach (Vessel v in vesselList)
        {
            if (v.AverageSpeed == maxSpeed)
            {
                result.Add(v);
            }
        }

        return result;
    }
}
