namespace GDIInterface.Models.Entities.Web.ApiResultModels.Base
{
    public class ApiResultFailed : ApiResult
    {
        public string errorMessage = "";

        public ApiResultFailed(string errorMessage) : base(false)
        {
            this.errorMessage = errorMessage;
        }

    }
}