using System.Collections.Generic;
using GDIInterface.Models.Entities.Web.ApiResultModels.Base;

namespace GDIInterface.Models.Entities.Web.ApiResultModels.Request
{
    public class UpdateAddressesSuccess : ApiResult
    {
        public List<long> failed_adressId { get; set; }

        public UpdateAddressesSuccess(List<long> failed_adressId) : base(true)
        {
            this.failed_adressId = failed_adressId;
        }
    }
}