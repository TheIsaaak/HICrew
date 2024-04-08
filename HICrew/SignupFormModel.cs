using Syncfusion.Maui.Inputs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SignupFormModel
{
    [Display(Name = "Firstname")]
    public string Firstname { get; set; }

    [Display(Name = "Lastname")]
    public string Lastname { get; set; }

    [Display(Name = "Date of birth")]
    public DateTime? BirthDate { get; set; }

    [Display(Name = "Register as")]
    public SfComboBox RegisterAs { get; set; }

    [Display(Name = "Email")]
    public string Email { get; set; }

    [Display(Prompt = "use example@mail.com", Name = "Confirm Email")]
    public string ConfirmEmail { get; set; }

    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Prompt = "use 'demopassword'", Name = "Confirm Password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
}
