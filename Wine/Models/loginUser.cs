namespace Wine.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class loginUser
    {
        [Key]
        public int userID { get; set; }

        [Required(ErrorMessage ="Username required.", AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage ="Password required.", AllowEmptyStrings =false)]

        [StringLength(50)]
        public string Password { get; set; }
    }
}
