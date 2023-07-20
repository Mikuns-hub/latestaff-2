namespace lateStaff
{
    public class StaffMember
    {
        public string StaffName { get; set; }
        public int StaffId { get; set; }

        public List<DateTime> ArrivalTimes = new List<DateTime>();


    }
}