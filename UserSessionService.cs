public class UserSessionService
{
    public string UserName { get; set; }

    public bool IsLoggedIn => !string.IsNullOrEmpty(UserName);

    public void Login(string userName)
    {
        UserName = userName;
    }

    public void Logout()
    {
        UserName = null;
    }
}
