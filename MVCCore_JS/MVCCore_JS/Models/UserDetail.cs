using System.ComponentModel.DataAnnotations;

namespace MVCCore_JS.Models
{
    public class UserDetail
    {
        [Key]
        public int Id { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public UserDetail GetUserData()
        {
            return new UserDetail { Id = 1, Name = "Amit", Password = "abcd1234", UserID = "abcd@yahoo.com" };
        }
    }
}
