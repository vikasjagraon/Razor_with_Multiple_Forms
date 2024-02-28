using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_with_Multiple_Form.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public class Introduction
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }
        public void OnPost()
        {
            
        }


        //public void OnPostForm1()
        //{
        //    Introduction introduction = new Introduction();
        //    introduction.Name = Request.Form["Name"];
        //    introduction.Surname = Request.Form["Surname"];

        //    ViewData["sentence"] = $"Hi, my name is {introduction.Name} {introduction.Surname}!  form 1";
        //}

        //public void OnPostForm2()
        //{
        //    Introduction introduction = new Introduction();
        //    introduction.Name = Request.Form["Name"];
        //    introduction.Surname = Request.Form["Surname"];

        //    ViewData["sentence"] = $"Hi, my name is {introduction.Name} {introduction.Surname}! form 2";
        //}
    }
}
