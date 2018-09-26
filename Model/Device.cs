using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace inventory
{
    public class Device
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public int DeviceTypeId { get; set; }
        public int DestinationId { get; set; }
        public int SourceId { get; set; }
        public string Comment { get; set; }


        
        private readonly ApplicationDbContext _context;

        public Device ()
        {
            _context = new ApplicationDbContext();
        }

        void add()
        {
            _context.Devices.Add(this);
            _context.SaveChanges();
            Console.WriteLine("device with sn="+SerialNumber+" saved to db");
        }

        string getName ()
        {
            string name = "S";

            try
            {
                string lastNumber = _context.Devices.Last ().Name;
                int nextNumber = Int32.Parse (lastNumber.Substring (1,lastNumber.Length-1));
                nextNumber++;

                name += nextNumber.ToString ();
            }
            catch (Exception)
            {
                name += "10001";
            }

            return name;
        }

        public Device findDevice(string serialNo)
        {
            var allDevices = _context.DeviceTypes.Select(p=>p).ToList();

            foreach(DeviceType dt in allDevices)
            {
                string regex = dt.SerialNoRegex;
                if(regexMatch(serialNo, regex))
                {                    
                    SerialNumber=serialNo;
                    DeviceTypeId=dt.Id;
                    Name=getName();
                    add();
                    Console.WriteLine("device type="+dt.Name);                                        
                }
            }
            return this;
        }

        bool regexMatch(string input, string regexString)
        {
            // \r\n(\w+)        Matches a new line, \u000A.
            // [ first - last ] Character range: Matches any single character in the range from first to last.
            // ^                By default, the match must start at the beginning of the string; in multiline mode, it must start at the beginning of the line.
            // \z 	            The match must occur at the end of the string.
            // \d 	            Matches any decimal digit.

            Regex regex = new Regex(regexString);
            return regex.Match(input).Success;
        }
    }
}