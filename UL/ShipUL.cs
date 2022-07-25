using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.DL;
namespace Ocean_Navigation.UL
{
    internal class ShipUL
    {
       
        public static string getShipNumber()
        {
            string shipNumber;
            Console.Write("Enter Ship Number : ");
            shipNumber = Console.ReadLine();
            return shipNumber;

        }
        public static string setLocation(char direction)
        {
            if (direction == 'E' || direction == 'W')
            {
                return "Longitude";
            }
            return "Latitude";
        }
        public static Angle getShipLatitude()
        {
            int degree;
            float minutes;
            char direction;
            Console.WriteLine("Enter Ship Latitude :-");
            Console.Write("Enter Latitude’s Degree : ");
            degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Minutes : ");
            minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction : ");
            direction = char.Parse(Console.ReadLine());
            Angle latitiudeDirection = new Angle(degree, minutes, direction,setLocation(direction));
            return latitiudeDirection;
        }
        public static Angle getShipLongitude()
        {
            int degree;
            float minutes;
            char direction;
            Console.WriteLine("Enter Ship Longitude :- ");
            Console.Write("Enter Longitude’s Degree: ");
            degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minutes: ");
            minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Direction: ");
            direction = char.Parse(Console.ReadLine());
            Angle longitudeDirection = new Angle(degree, minutes, direction,setLocation(direction));
            return longitudeDirection;
        }
        public static void viewPositionLongitude(string position)
        {
            Console.WriteLine("Longitude : "+position);
        }
        public static void viewPositionLatitue(string position)
        {
            Console.WriteLine("Latitude : " + position);
        }
        public static void viewShipNumber(string shipNumber)
        {
            Console.WriteLine("Ship’s serial number is: "+shipNumber);
        }
    }
}
