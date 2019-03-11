namespace GDIInterface.Models.Entities.Response
{
    public class SingleInsertAddressResult
    {
        public SingleInsertAddressResult(bool success, long adressid)
        {
            this.success = success;
            this.adressid = adressid;
        }
        public bool success = false;
        public long adressid;
    }
}