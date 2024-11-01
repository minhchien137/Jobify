using System.ComponentModel.DataAnnotations;

namespace Jobify.Models
{
    public partial class TblUser
    {

        [Key]
        public string SUserName { get; set; }

        public string SPhoneNumber { get; set; }

        public string SEmail {  get; set; }


        public string SPassword { get; set; }


        public DateOnly DDateOfBirth { get; set; }


        public string SRole { get; set; }







    }
}
