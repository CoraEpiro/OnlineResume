using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ResumeWithRazorPages.Model;
using ResumeWithRazorPages.Services;

namespace ResumeWithRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MailService _mailservice;

        public IndexModel()
        {
            _mailservice = new();
        }

        public void OnPost(Mail mail)
        {
            _mailservice.Send(mail);
        }

        public void OnGet()
        {

        }
    }
}