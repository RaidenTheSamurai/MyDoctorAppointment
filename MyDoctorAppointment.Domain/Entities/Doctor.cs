using MyDoctorAppointment.Domain.Enums;

namespace MyDoctorAppointment.Domain.Entities
{
    public class Doctor : UserBase
    {
        public DoctorTypes DoctorType { get; set; }

        public byte Experiance { get; set; }

        public decimal Salary { get; set; }
        public bool UseJson { get; set; }
    }
}
