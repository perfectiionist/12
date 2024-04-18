using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemApp.Data
{
    public class ClassPerson
    {
        public string ApplicationNumber { get; set; }
        public string Date { get; set; }
        public string Equipment { get; set; }
        public string TypeOfFault { get; set; }
        public string Description { get; set; }
        public string ClientLastName { get; set; }
        public string ApplicationStatus { get; set; }
        

        public ClassPerson()
        {
        }
        public static List<ClassPerson> list = new List<ClassPerson>();
        public ClassPerson(string Id, string date, string equipment, string Malfunction_type, string Problem_desc, string Client, string Status)
        {
            ApplicationNumber = Id;
            Date = date;
            Equipment = equipment;
            TypeOfFault = Malfunction_type;
            Description = Problem_desc;
            ClientLastName = Client;
            ApplicationStatus = Status;
        }

        
        public string Id
        {
            get { return ApplicationNumber; }
            set { ApplicationNumber = value; }
        }
        public string date
        {
            get { return Date; }
            set { Date = value; }
        }

        public string equipment
        {
            get { return Equipment; }
            set { Equipment = value; }
        }

        public string Malfunction_type
        {
            get { return TypeOfFault; }
            set { TypeOfFault = value; }
        }

        public string Problem_desc
        {
            get { return Description; }
            set { Description = value; }
        }

        public string Client
        {
            get { return ClientLastName; }
            set { ClientLastName = value; }
        }

        public string Status
        {
            get { return ApplicationStatus; }
            set { ApplicationStatus = value; }
        }
    }
}
