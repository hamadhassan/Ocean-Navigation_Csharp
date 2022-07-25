using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using System.IO;

namespace Ocean_Navigation.DL
{
    internal class ShipDL
    {
        public static List<Ship> ShipList = new List<Ship>();
        public static void setIntoShipList(Ship s)
        {
            ShipList.Add(s);
        }
        public static void storeintoFileShip(string path,List< Ship> shipList)
        {
            StreamWriter f = new StreamWriter(path);
            string location="";
            foreach(Ship ship in shipList)
            {
                for (int i = 0; i < ship.position.Count; i++)
                {
                    location += ship.position[i].getDegree() + ";" + ship.position[i].getMinutes() + ";" + ship.position[i].getDirection() + ";" + ship.position[i].getLocation() + ";";
                }
                f.WriteLine(ship.getShip() + "," + location);
            }
            f.Flush();
            f.Close();
        }
        public static void readFromFileShip(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string shipNumber = splittedRecord[0];
                    string[] splittedRecordForPosition =splittedRecord[1].Split(';');
                    List<Angle> position = new List<Angle>();
                    int x = 0;
                    for(int i = 0; i < 2; i++)
                    {
                        int degree=int.Parse(splittedRecordForPosition[x]);
                        float minutes=float.Parse(splittedRecordForPosition[x+1]);
                        char direction=char.Parse(splittedRecordForPosition[x+2]);
                        string loaction= splittedRecordForPosition[x+3];
                        Angle a=new Angle(degree, minutes, direction,loaction);
                        x = 4;
                        position.Add(a);
                    }
                    Ship s=new Ship(shipNumber,position);
                    setIntoShipList(s);
                }
                f.Close();
            }
        }

    }
}
