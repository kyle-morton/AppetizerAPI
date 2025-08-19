using Microsoft.EntityFrameworkCore;

namespace AppetizerAPI.Services;

public interface IUserService
{
    Task<User> CreateUser(User user);
    Task<User> UpdateUser(User user);
    Task<User> GetUser(int id);
}

public class UserService(AppetizerDbContext dbContext) : IUserService
{
    private readonly AppetizerDbContext _dbContext;
    
    public async Task<User> CreateUser(User user)
    {
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async Task<User> UpdateUser(User user)
    {
        _dbContext.Users.Update(user);
        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async Task<User> GetUser(int id)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
    }
}