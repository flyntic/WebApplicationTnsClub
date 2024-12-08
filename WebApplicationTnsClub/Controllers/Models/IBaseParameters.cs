using WebApplicationTnsClub.Models;

namespace WebApplicationTnsClub.Controllers.Models
{
    public interface IBaseParameters<T>
    {
        public T Id { get; set; }
       // public IBaseParameters ApiBaseId(IBaseId item);
    }

   /* public class BaseParameters<T> : IBaseParameters<T>
    {
        public T Id { get; set; } //= Guid.NewGuid().ToString();

      //  IBaseParameters IBaseParameters.ApiBaseId(IBaseId item)
      //  {
      //      throw new NotImplementedException();
      //  }

        //  public static implicit operator ApiBaseId(ApiUser v)
        ///  {

        //      return new 
        //throw new NotImplementedException();
        //  }
    }*/
}
