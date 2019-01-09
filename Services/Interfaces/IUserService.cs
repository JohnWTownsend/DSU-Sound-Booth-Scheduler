using Data;
namespace Services.Services
{
    public interface IUserService
    {
        DSUSoundBoothSchedulerUser GetUserById(string id);
    }
}