using System;

namespace inventory
{
    public class DeviceType
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string SerialNoRegex { get; set; }
    }
}