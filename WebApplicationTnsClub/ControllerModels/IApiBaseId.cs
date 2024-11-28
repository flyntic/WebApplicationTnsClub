using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.ControllerModels
{
    public interface IApiBaseId
    {
        public string Id { get; set; }
        public IApiBaseId ApiBaseId(IBaseId item);
    }

    public class ApiBaseId:IApiBaseId
    {
        public string Id { get; set; } = Guid.NewGuid().ToString()  ;

        IApiBaseId IApiBaseId.ApiBaseId(IBaseId item)
        {
            throw new NotImplementedException();
        }

      //  public static implicit operator ApiBaseId(ApiUser v)
      ///  {

      //      return new 
            //throw new NotImplementedException();
      //  }
    }
}
