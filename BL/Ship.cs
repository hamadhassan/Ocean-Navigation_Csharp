using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.DL;
using Ocean_Navigation.UL;
namespace Ocean_Navigation.BL
{
    internal class Ship
    {
        private string shipNumber;
        public List<Angle> position = new List<Angle>();
        public Ship(string shipNumber,List<Angle> angleList)
        {
            this.shipNumber = shipNumber;
            this.position = angleList;
        }
        public Ship(string shipNumber)
        {
            this.shipNumber=shipNumber;
        }
        public Ship(List<Angle> position)
        {
            this.position = position;
        }
        public string getShip()
        {
            return shipNumber;
        }
        public string setPosition(string shipNumber,string location)
        {
            string position = "";
            foreach (Ship storeShip in ShipDL.ShipList)
            {
                foreach (Angle storeAngle in storeShip.position)
                {
                    if (shipNumber == storeShip.shipNumber && storeAngle.getLocation() ==location)
                    {
                        position= storeAngle.displayFormate(storeAngle.getDegree(), storeAngle.getMinutes(), storeAngle.getDirection());
                        break;
                    }
                }
            }
            return position;
        }
        public string viewShipNumber(List<Angle> checkAngle)
        {
            string shipNumber = "";
            foreach (Ship storeShip in ShipDL.ShipList)
            {
                for(int x = 0; x <2; x++)
                {
                    if (checkAngle[x].getDegree() == storeShip.position[x].getDegree() || checkAngle[x].getMinutes() == storeShip.position[x].getMinutes() || checkAngle[x].getDirection() == storeShip.position[x].getDirection())
                    {
                        shipNumber=storeShip.shipNumber;
                    }
                }
            }
            return shipNumber;
        }
       
        public  void setNewShipPosition(string shipNumber)
        {
            List<Angle> angleList = new List<Angle>();
            for (int x = 0; x < ShipDL.ShipList.Count; x++)
            {
                if (shipNumber == ShipDL.ShipList[x].shipNumber)
                {
                    ShipDL.ShipList.RemoveAt(x);
                    Angle positionLat = ShipUL.getShipLatitude();
                    Angle latitudeAngle = new Angle(positionLat.getDegree(), positionLat.getMinutes(), positionLat.getDirection(),ShipUL.setLocation(positionLat.getDirection()));
                    Angle positionLon = ShipUL.getShipLongitude();
                    Angle longitudeAngle = new Angle(positionLon.getDegree(), positionLon.getMinutes(), positionLon.getDirection(), ShipUL.setLocation(positionLon.getDirection()));
                    angleList.Add(latitudeAngle);
                    angleList.Add(longitudeAngle);
                    Ship newPosition = new Ship(shipNumber, angleList);
                    ShipDL.ShipList.Insert(x, newPosition);
                    Ship newShip = new Ship(shipNumber, angleList);
                    break;
                }
            }
        }
    }
}
