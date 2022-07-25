using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.DL;
using Ocean_Navigation.UL;
namespace Ocean_Navigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathShip = "ship.txt";
            ShipDL.readFromFileShip(pathShip);
            while (true)
            {
                char op = MiscUL.mainMenu();
                if (op == '1')
                { 
                    List<Angle> angleList = new List<Angle>();
                    string shipNumber =ShipUL.getShipNumber();
                    Angle latitiudeDirection=ShipUL.getShipLatitude();
                    Angle longitudeDirection = ShipUL.getShipLongitude();
                    angleList.Add(latitiudeDirection);
                    angleList.Add(longitudeDirection);
                    Ship newShip = new Ship(shipNumber, angleList);
                    ShipDL.setIntoShipList(newShip);
                    ShipDL.storeintoFileShip(pathShip, ShipDL.ShipList);
                }
                else if(op == '2')
                {
                    string shipNumber = ShipUL.getShipNumber();
                    Ship shipPosition = new Ship(shipNumber);
                    string position = shipPosition.setPosition(shipNumber, "Longitude");
                    ShipUL.viewPositionLongitude(position);
                    position = shipPosition.setPosition(shipNumber, "Latitude");
                    ShipUL.viewPositionLatitue(position);
                }
                else if (op == '3')
                {
                    List<Angle> angleList = new List<Angle>();
                    Angle longitudeDirection = ShipUL.getShipLongitude();
                    Angle latitiudeDirection = ShipUL.getShipLatitude();
                    angleList.Add(longitudeDirection);
                    angleList.Add(latitiudeDirection);
                    Ship position=new Ship(angleList);
                    string shipNumber=position.viewShipNumber(angleList);
                    ShipUL.viewShipNumber(shipNumber);
                }
                else if (op == '4')
                {
                    string shipNumber = ShipUL.getShipNumber();
                    Ship shipPosition = new Ship(shipNumber);
                    shipPosition.setNewShipPosition(shipNumber);
                    ShipDL.storeintoFileShip(pathShip, ShipDL.ShipList);
                }
                else if (op == '5')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }

                MiscUL.clearScreen();
            }
        }
    }
}
