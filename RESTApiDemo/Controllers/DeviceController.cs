using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTApiDemo.Models;


namespace RESTApiDemo.Controllers
{
    public class DeviceController : ApiController
    {
        private static devicesList devicelist = new devicesList();
        private static List<Device> deviceList = devicelist.getAllDevices();
        
        // GET: api/Device
        public List<Device> Get()
        {

            return deviceList;
        }

        // GET: api/Device/5
        public Device Get(int id)
        {
            Device d1 = new Device();
            d1.id = 1;
            d1.name = "Entrance 1";
            d1.type = "IR";
            return d1;
        }

        // POST: api/Device
        public bool Post([FromBody] Device value)
        {
            bool result = true;
            Device newDevice = new Device();
            newDevice.id = value.id;
            newDevice.name = value.name;
            newDevice.type = value.type;
            deviceList.Add(newDevice);
            return result;
        }

        // PUT: api/Device/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Device/5
        public void Delete(int id)
        {
        }
    }
}
