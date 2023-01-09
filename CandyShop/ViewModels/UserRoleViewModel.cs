namespace CandyShop.ViewModels
{
    public class UserRoleViewModel
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public List<string>Roles { get; set; }= new List<string>();
    }
}
