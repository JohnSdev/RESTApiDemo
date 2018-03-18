using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTApiDemo.Models
{
    public class devicesList
    {
        public List<Device> getAllDevices()
        {
            List<Device> dList = new List<Device> { };
            Device d1 = new Device();
            d1.id = 1;
            d1.name = "Room1";
            d1.type = "Temp";
            dList.Add(d1);
            return dList;
        }
    }
}