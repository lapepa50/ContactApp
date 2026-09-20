using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ContactApp.Pages
{
    public class ContactModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

public class Contact
{
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(200)]
    public string Message { get; set; }
}
