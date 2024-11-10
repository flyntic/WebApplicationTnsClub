using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Security.Claims;
using WebApplicationTnsClub.DB;

namespace WebApplicationTnsClub.Endpoints
{
    public class ProjectEndPoint
    {
  /*      public static async Task<List<Project>> List(ClaimsPrincipal user, ApplicationContext db)
        {
            var userId=user.FindFirstValue(ClaimTypes.NameIdentifier);
            return await db.Projects
                .Include(x=>x.Tasks)
                .Where(x=>x.Users.Any(x=>x.UserId==userId))
                .ToListAsync();
        }

        public static async Task<Project>Get(
            int id,
            ClaimsPrincipal user,
            ApplicationContext db)
        {
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
            return await db.Projects
             .Include(x => x.Tasks)
             .Where(x => x.Users.Any(x => x.UserId == userId))
             .FirstOrDefaultAsync(x=> x.Id==id);
        }

        public static async Task<IResult> AddUserToProject(
            int id,
            Guid userIdToAdd,
            ApplicationContext db)
        { 
          var project=await db.Projects.FirstOrDefaultAsync(x=>x.Id==id);
            project.Users.Add(new ProjectUser() { UserId = userIdToAdd.ToString() });
            await db.SaveChangesAsync();

            return Results.Ok();
        }*/
    }
}
