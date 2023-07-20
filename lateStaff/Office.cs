namespace lateStaff
{
    public class Office
    {
        private List<StaffMember> StaffList = new List<StaffMember> ();

        public void LogArrivalTime(int staffId)
        {
           var staff = GetStaffById (staffId);
            staff.ArrivalTimes.Add(DateTime.Now);
        }

        public StaffMember? GetStaffById(int staffId)
        {
            var staffWithId = StaffList.Find(s =>  s.StaffId == staffId);
            return staffWithId;
        }

       /* public bool DoesStaffExist(int staffId)
        {
            var doesStaffExist = StaffList.Any(x => x.StaffId == staffId);
            return doesStaffExist;
        }*/
    }
}

