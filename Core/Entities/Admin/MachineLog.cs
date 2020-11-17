using System;

namespace Core.Entities.Admin
{
    public class MachineLog : BaseEntity
    {
        public string Key { get; set; }

        public DateTime Date { get; set; }

        public int Requests { get; set; }

        public bool IsBlocked { get; set; }


    }
}
