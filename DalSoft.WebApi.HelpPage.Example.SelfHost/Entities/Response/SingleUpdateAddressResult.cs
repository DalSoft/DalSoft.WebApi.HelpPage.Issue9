namespace GDIInterface.Models.Entities.Response
{
    public class SingleUpdateAddressResult
    {
        public SingleUpdateAddressResult(bool success, long data)
        {
            this.success = success;
            this.data = data;
        }
        public bool success = false;
        public long data;
    }
}