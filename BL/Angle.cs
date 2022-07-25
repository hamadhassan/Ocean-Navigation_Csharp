using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.BL
{
    class Angle
    {
        private int degree;
        private float minutes;
        private char direction;
        private string loaction;
        public Angle(int degree,float minutes,char direction,string loaction)
        {
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;
            this.loaction = loaction;
        }
        public Angle(int degree, float minutes, char direction)
        {
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;
        }
        public int getDegree()
        {
            return degree;
        }
        public float getMinutes()
        {
            return minutes;
        }
        public char getDirection()
        {
            return direction;
        }
        public string getLocation()
        {
            return loaction;
        }
        public string displayFormate(int degree,float minutes,char direction)
        {
           return degree+"\u00b0 "+minutes+ "' "+direction;
        }

    }
}
