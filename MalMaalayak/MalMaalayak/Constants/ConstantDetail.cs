using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MalMaalayak.Constants
{
    public class ConstantDetail
    {

        public enum Gender {
            Male=1,
            FeMale=2,
            Other=3
        }

        public enum Religion {
            Hindu=1,
            Christian=2,
            Islam=3,
            Buddist=4
        }
        public enum Caste
        {
            High=1,
            Low=2
        }
        public enum Star
        {
            Star1=1,
            Star2=2

        }
        public enum Lagna
        {
            Aquarius=1,
            Pisces=2,
            Aries=3,
            Taurus =4,
            Gemini=5,
            Cancer=6,
            leo=7,
            Virgo=8,
            Libra=9,
            Scorpio=10,
            Sagittarius=11,
            Capricorn=12

        }
        public enum Qualification
        {
            OL=1,
            AL =2,
            UNI=3,
            Other=4

        }
        public enum Country
        {
            Srilanka=1,
            Canada=2,
            India=3,
            UK=4,
            USA=5,
            Other=6
        }
        public enum Expectation
        {
            Local=1,
            Forign=2,
            Any=3
        }


    }
}