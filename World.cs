using System;
using System.Collections.Generic;
using System.IO;
//using Microsoft.VisualBasic;

public class World
{
    public Location startingLocation;
    private Dictionary<int, Location> worldLocs;
    private string winDir = System.Environment.GetEnvironmentVariable("windir");
    public World()
    {
        Console.WriteLine("\nEntering Constructor for World in directory {0}", winDir);

        worldLocs = new Dictionary<int, Location>();
        buildWorld();
    }

    private void buildWorld()
    {
        processLongNameFile();
        Location c = new Location();

        //Console.WriteLine("Location Succesful");
        c.setName("Carnival");
        c.addDescriptionLine("large and bustling with children");
        //starting location
        startingLocation = c;

        Location directions = new Location();
        directions.setName("city");
        directions.addDescriptionLine("a jungle of concrete and brick");

        Location directionsII = new Location();
        directionsII.setName("seaport");
        directionsII.addDescriptionLine("smelly and muddy");

        c.setEastneighbor(directionsII);

        c.setWestneighbor(directions);

        c.setEastneighbor(c);

        directionsII.setWestneighbor(c);

        c.describeMe();

        directions.describeMe();

        directionsII.describeMe();

    }
    void processLongNameFile()
    {
        string path = "c:/temp/data/LongDescriptions.txt";
        string descLine;
        string[]? descFields;
        string errorMsg;
        int thisLocIndex = 0;   // location index of the currently formatted location
        int newLocIndex = 1000; // location index of line just read
        Location thisLoc = new Location(); // throw-away to satisfy compiler?!?

        int lineCount = 0;

        if (!File.Exists(path))
        {
            Console.WriteLine("data file {0} missing", path);
            Environment.Exit(-1);
        }

        StreamReader longDescReader = new StreamReader(path);

        while (longDescReader.Peek() > -1)
        {
            descLine = longDescReader.ReadLine();
            lineCount++;
            try
            {
                descFields = descLine.Split(Convert.ToChar(9)); // ASCII tab character
                if (descFields.Length != 2)
                {
                    errorMsg = "Parse of description file " + path + "failed at line " + lineCount + 
                        "/n" + descLine;
                    throw new DescriptionException(errorMsg);
                }
                // parsed line ok - process line
                newLocIndex = int.Parse(descFields[0]);
                if (newLocIndex != thisLocIndex)
                {
                    thisLoc = new Location();
                    thisLoc.addDescriptionLine(descFields[1]);
                    thisLocIndex++;
                    worldLocs.Add(thisLocIndex, thisLoc);
                }
                else // changed location - format a new location and add to world
                {
                    thisLoc.addDescriptionLine(descFields[1]);
                }

            }
            catch (DescriptionException exception)
            {
                Console.WriteLine(exception.Message);
                continue;
            }
        }
    }

private class DescriptionException : ArgumentException
    {
        public DescriptionException()
        {
        }

        public DescriptionException(string message)
        : base(message)
        {
        }

        public DescriptionException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}



