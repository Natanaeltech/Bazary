
using Microsoft.AspNetCore.Identity;

namespace bazary.Models
{
    public class User:IdentityUser
    {
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string? ImageName {get; set;}
        public string? ContentType {get;set;}
    }
}