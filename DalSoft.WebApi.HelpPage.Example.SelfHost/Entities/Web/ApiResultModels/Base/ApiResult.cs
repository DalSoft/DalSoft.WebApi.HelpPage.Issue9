namespace GDIInterface.Models.Entities.Web.ApiResultModels.Base
{
    public class ApiResult
    {
        public bool success = false;

        public ApiResult(bool success)
        {
            this.success = success;
        }
    }
}