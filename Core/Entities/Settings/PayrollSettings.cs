using Core.Entities.Customers;

namespace Core.Entities.Settings
{
    public class PayrollSettings
    {
        public int BranchId { get; set; }
        public int AllowedLeave { get; set; }
        public AllowedLeaveType AllowedLeaveType { get; set; }

        public WorkingUnit WorkingUnit { get; set; }

        public WeekDayType WeekDay { get; set; }

        public Branch Branch { get; set; }
    }

    public enum AllowedLeaveType : byte
    {
        Monthly,
        Yearly
    }

    public enum WorkingUnit : byte
    {
        Hour,
        Month
    }

    public enum WeekDayType : byte
    {
        MonToFriday,
        MonToSat

    }
}
