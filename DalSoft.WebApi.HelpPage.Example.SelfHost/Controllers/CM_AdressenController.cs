
using System.Collections.Generic;
using System.Web.Http;
using GDIInterface.Models.Entities.Web;
using GDIInterface.Models.Entities.Web.ApiResultModels.Base;
using GDIInterface.Models.Entities.Web.ApiResultModels.Request;


namespace GDIInterface.Controllers
{
    [RoutePrefix("api/v1.0/cm_address")]
    public class CM_AdressenController : ApiController
    {
        public CM_AdressenController()
        {
           
        }


        /// <summary>
        /// Erstellt ein Kundenkonto in GDI.
        /// </summary>
        [HttpPost]
        [Route("create_address")]
        public ApiResult createAddress(AddressDTO dto)
        {
            return new CreateAddressSuccess(1);
        }


        /// <summary>
        /// Erstellt ein Kundenkonto in GDI.
        /// </summary>
        [HttpPost]
        [Route("create_addresses")]
        public ApiResult createAddress(List<AddressDTO> dtos)
        {
            return new CreateAddressesSuccess(null);
        }



        /// <summary>
        /// Updatet Kundenadressen in GDI.
        /// </summary>
        [HttpPost]
        [Route("update_addresses")]
        public ApiResult updateAdress(List<AddressDTO> dtos)
        {
            return new UpdateAddressesSuccess(null);
        }


    }
}
