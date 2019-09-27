using System;

namespace RelativesProject {
    class Program {
        static void Main(string[] args)
        {
            Relative tray = new Relative() ;
            tray.Firstname = "Tracie";
            tray.Lastname = "Chan";
            tray.Phone = "5135501143";
            tray.Occupation = "Pharmacist";

            
        }
    }
}
    class Relative {
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Phone { get; set; }
    public string Occupation { get; set; }
    public string Relation { get; set; }
    public int Age { get; private set; }
}
