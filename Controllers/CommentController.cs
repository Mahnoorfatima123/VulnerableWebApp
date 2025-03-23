// 🔴 Risk: Users can inject malicious scripts.
// ✅ Fix: Encode output using HtmlEncoder.
using Microsoft.AspNetCore.Mvc;

namespace VulnerableWebApp.Controllers
{
    public class CommentController : Controller
    {
        [HttpPost]
        public IActionResult Post(string comment)
        {
            // ❌ No output encoding - vulnerable to XSS
            return Content($"<p>Comment: {comment}</p>", "text/html");
        }
    }
}
