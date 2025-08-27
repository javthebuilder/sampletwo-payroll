namespace aspnetapp.Model
{
    public class User
    {
        int userId = 0;
        string userName = "";

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
