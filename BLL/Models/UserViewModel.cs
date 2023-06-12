using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class UserViewModel : BaseModel
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

        public string Phone { get; set; }

        public string Role { get; set; }

        public string? ProfilePicture { get; set; }

        public string? ProfilePictureFormat { get; set; }

        public int? NumberOfCompletedApplications { get; set; }

        public List<UserSkillViewModel> UserSkills { get; set; } = new List<UserSkillViewModel>();

        //public override bool Equals(object p)
        //{
        //    if (p is null)
        //    {
        //        return false;
        //    }

        //    if (Object.ReferenceEquals(this, p))
        //    {
        //        return true;
        //    }


        //    if (this.GetType() != p.GetType())
        //    {
        //        return false;
        //    }

        //    var input = (UserViewModel)p;
        //    return (Id == input.Id);
        //}

        //public override int GetHashCode()
        //{
        //    return System.HashCode.Combine(Id, Login, Password, FirstName, LastName);
        //}
    }
}
