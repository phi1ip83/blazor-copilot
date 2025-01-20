using System.Collections.Generic;

public class UserService
{
    private List<User> registeredUsers = new List<User>();
    private string currentLoggedInUser;

    public void Register(User user)
    {
        if (registeredUsers.Exists(u => u.Username == user.Username))
        {
            throw new Exception("Username already exists.");
        }
        registeredUsers.Add(user);
    }

    public User Login(string username, string password)
    {
        var user = registeredUsers.Find(u => u.Username == username && u.Password == password);
        if (user != null)
        {
            currentLoggedInUser = username;
        }
        return user;
    }

    public void Logout()
    {
        currentLoggedInUser = null;
    }

    public string GetLoggedInUser()
    {
        return currentLoggedInUser;
    }
}
