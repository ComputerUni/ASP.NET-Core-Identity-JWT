using Microsoft.AspNetCore.Mvc;

namespace NotikaIdentityEmail.Models
{
    public class UserLoginViewModel : Controller
    {

        public string Username { get; set; }
        public string Password { get; set; }

    }
}