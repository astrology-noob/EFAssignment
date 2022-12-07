using EFAssignment.Data;

namespace EFAssignment.Services;

public class UserService
{
    private AppDBContext _dbContext;

    public UserService(AppDBContext db)
    {
        _dbContext = db;
    }

    public List<User> GetUsers()
    {
        return _dbContext.Users.ToList();
    }

    public async Task<User> AddUserAsync(User user)
    {
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        _dbContext.Update(user);
        await _dbContext.SaveChangesAsync();
        return user;
    }

    public async Task<User> DeleteUserAsync(User user)
    {
        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync();

        return user;
    }
}
