using GDIInterface.Models.Entities.Web.ApiResultModels.Base;

namespace GDIInterface.Models.Entities.Web.ApiResultModels.Request
{
    public class CreateAddressSuccess :ApiResult
    {
        public long erpId { get; set; }

        public CreateAddressSuccess(long erpid):base(true)
        {
            this.erpId = erpid;
        }
    }
}