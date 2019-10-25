using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidHelper
{
    class AndroidHelper
    {
        public string GetAndroidVersionName(string Version)
        {
            string version = Version.Substring(0,3);
            string versionname;
            switch (version)
            {
                case "2.2":
                    return versionname = "Froyo";
                case "2.3":
                    return versionname = "Gingerbread";
                case "3.0":
                    return versionname = "Honeycomb";
                case "3.1":
                    return versionname = "Honeycomb";
                case "3.2":
                    return versionname = "Honeycomb";
                case "4.0":
                    return versionname = "Ice Cream Sandwich";
                case "4.1":
                    return versionname = "Jelly Bean";
                case "4.2":
                    return versionname = "Jelly Bean";
                case "4.3":
                    return versionname = "Jelly Bean";
                case "4.4":
                    return versionname = "KitKat";
                case "5.0":
                    return versionname = "Lollipop";
                case "5.1":
                    return versionname = "Lollipop";
                case "6.0":
                    return versionname = "Marshmallow";
                case "7.0":
                    return versionname = "Nougat";
                case "7.1":
                    return versionname = "Nougat";
                case "8.0":
                    return versionname = "Oreo";
                case "8.1":
                    return versionname = "Oreo";
                case "9.0":
                    return versionname = "Pie";
                case "10.":
                    return versionname = "Android 10";
                default:
                    return versionname = "Unknown";
            }
        }
    }
}
