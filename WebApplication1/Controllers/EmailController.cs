using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;

using System;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
  
        
            private readonly EmailService _emailService;

        //ok 

            public EmailController(EmailService emailService)
            {
                _emailService = emailService;
            }

            [HttpPost("send")]
            public IActionResult SendEmail([FromBody] EmailRequest request)
            {
                try
                {
                // Generate Email Content
                var emailBody = _emailService.GenerateEmailContent(request.RecipientName, request.body);

                    // Send Email
                    _emailService.SendEmail(request.RecipientName, request.RecipientEmail, "Welcome to Our Service!", emailBody, request.body);

                    return Ok(new { message = "Email sent successfully!" });
                }
                catch (Exception ex)
                {
                    return BadRequest(new { error = ex.Message });
                }
            }
        }

        public class EmailRequest
        {
            public string RecipientName { get; set; }
            public string RecipientEmail { get; set; }

              public string body { get; set; }
    }

    }
