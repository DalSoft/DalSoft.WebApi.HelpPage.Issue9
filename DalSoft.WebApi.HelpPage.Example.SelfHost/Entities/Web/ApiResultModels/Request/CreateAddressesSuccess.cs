using System.Collections.Generic;
using GDIInterface.Models.Entities.Data;
using GDIInterface.Models.Entities.Response;
using GDIInterface.Models.Entities.Web.ApiResultModels.Base;

namespace GDIInterface.Models.Entities.Web.ApiResultModels.Request
{
    public class CreateAddressesSuccess : ApiResult
    {
        public List<SingleInsertAddressResult> data { get; set; }

        public CreateAddressesSuccess(List<SingleInsertAddressResult> data) : base(true)
        {
            this.data = data;
        }
    }
}