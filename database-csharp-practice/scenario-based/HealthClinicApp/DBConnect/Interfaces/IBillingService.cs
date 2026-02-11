namespace DBConnect.Interfaces

{
    public interface IBillingService
    {
        void GenerateBill(int visitId, decimal amount);
        void RecordPayment(int billId);
    }
}
