namespace DBConnect.Interfaces

{
    public interface IVisitService
    {
        void RecordVisit(int appointmentId, string diagnosis, string notes);
    }
}
