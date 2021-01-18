using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Mail;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Cors;
using WebAPICore.Models;
using System.IO;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class MailController : ControllerBase
    {

        [HttpPost]
        [Route("MailSend")]

        public IActionResult SendMail(Mail MailDetails)
        {
            try
            {
                using (MailMessage EMail = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(MailDetails.Sender, "From LTI");
                    List<System.Net.Mail.Attachment> mailattachment = new List<System.Net.Mail.Attachment>();
                    EMail.From = fromAddress;
                    if (!string.IsNullOrEmpty(MailDetails.To))
                    {
                        foreach (string email in MailDetails.To.Split(','))
                        {
                            if (!string.IsNullOrEmpty(email))
                            {
                                try
                                {
                                    EMail.To.Add(email);
                                }
                                catch { }
                            }
                        }
                    }
                    if (EMail.To.Count == 0)
                    {
                        throw new Exception("To address is not present in the mail");
                    }
                    if (!string.IsNullOrEmpty(MailDetails.CC))
                    {
                        foreach (string email in MailDetails.CC.Split(','))
                        {
                            if (!string.IsNullOrEmpty(email))
                            {
                                try
                                {
                                    EMail.CC.Add(email);
                                }
                                catch { }
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(MailDetails.BCC))
                    {
                        foreach (string email in MailDetails.BCC.Split(','))
                        {
                            if (!string.IsNullOrEmpty(email))
                            {
                                try
                                {
                                    EMail.Bcc.Add(email);
                                }
                                catch { }
                            }
                        }
                    }

                    if (MailDetails.Attachments != null && MailDetails.Attachments.Any())
                    {
                        foreach (var attachment in MailDetails.Attachments)
                        {
                            var contentType = new System.Net.Mime.ContentType(System.Net.Mime.MediaTypeNames.Application.Pdf);
                            var emailAttachment = new System.Net.Mail.Attachment(attachment.Value, contentType);
                            emailAttachment.ContentDisposition.FileName = attachment.Key;
                            EMail.Attachments.Add(emailAttachment);
                        }
                    }


                    EMail.IsBodyHtml = true;
                    EMail.Body = MailDetails.Body;
                    EMail.Subject = MailDetails.Subject;

                    using (SmtpClient smtpClient = new SmtpClient())
                    {
                       //  smtpClient.Host = "smtp.office365.com";
                         smtpClient.Host = "smtp.gmail.com";
                        //  smtpClient.EnableSsl = false;
                        smtpClient.Port = 587;
                       // smtpClient.Port = 25;
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.UseDefaultCredentials = false;

                        //   smtpClient.Credentials = new System.Net.NetworkCredential("amitkumar.jaiswal@lntinfotech.com", "Lnt@0987654");
                        smtpClient.Credentials = new System.Net.NetworkCredential("jamit8720@gmail.com", "amit1989");

                        smtpClient.EnableSsl = true;

                        smtpClient.Timeout = 6000000;
                        smtpClient.Send(EMail);
                    }
                    MailDetails.Status = "Success";
                    // return Content(HttpStatusCode.OK, true);
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                MailDetails.Status = "Fail";
                return BadRequest(ex.Message.ToString());
            }
        }


        [HttpGet]
        [Route("Send_LeaveRequestMail")]
        public IActionResult Send_LeaveRequestMail()
        {
            string currentMethod = MethodBase.GetCurrentMethod().Name;

            #region Send Mail Code
            try
            {
               
                StringBuilder MailBody_PM = new StringBuilder();
               // string fileuplaod =   "D:/textfile.txt";
                string fileuplaod = "D:/Agile.pdf";

                byte[] bytes = System.IO.File.ReadAllBytes(fileuplaod);

                var stream = new MemoryStream(bytes);
               stream.Position = 0;
               
                MailBody_PM.Append("<font face=\"calibri\" size=\"3\">Dear Manager_name,<br/><br/></font>");
                
                MailBody_PM.Append("<font face=\"calibri\" size=\"3\">Leave Request has been subbmitteed by the below employee -<br/><br/></font>");

               // MailBody_PM.Append("<font face=\"calibri\" size=\"3\" font-weight=\"bold\">Leave Details<br/><br/></font>");

                
                MailBody_PM.Append("<table width='95%' cellpadding = '5' cellspacing = '0' style = 'border: 1px solid #000000;font-size: \"3\";font-family:calibri'> ");
                MailBody_PM.Append("<tr>");
                MailBody_PM.Append("<th style='background-color: #B8DBFD;border: 1px solid #000000'> Employee Name </th> ");
                MailBody_PM.Append("<th style='background-color: #B8DBFD;border: 1px solid #000000'> Leave Start Date</th> ");
                MailBody_PM.Append("<th style='background-color: #B8DBFD;border: 1px solid #000000'> Leave End Date</th> ");
                MailBody_PM.Append("</tr>");

                MailBody_PM.Append("<tr>");
                MailBody_PM.Append("<td style='text-align:center '>" + "Amit Jaiswal" + "</td>");
                MailBody_PM.Append("<td style='text-align:center '>" + "21/01/2020" + "</td>");
                MailBody_PM.Append("<td style='text-align:center'>" + "21/01/2020" + "</td>");
                MailBody_PM.Append("</tr>");


                MailBody_PM.Append("</tr></table>");
                  MailBody_PM.Append("<br/><br/><br/>");
                MailBody_PM.Append("<font face=\"calibri\" size=\"3\">Note: If no action performed on the request, the request will be autorejected after 5 days.</font>");

                MailBody_PM.Append("<br/><br/>");
                MailBody_PM.Append("<font face=\"calibri\" size=\"3\">Regards,<br/>Leave Administrator</font><br/><br/></font>");
                MailBody_PM.Append("<font face=\"calibri\" size=\"3\"><hr width=\"96%\"><p style=\"color: red;\"> Note: This is an automatically generated email. Please do not reply directly to this mail.</p></font>");

              
                Mail ObjMail_PM = new Mail()
                {
                    To = "10670758@lntinfotech.com",
                    //To = "ajaiswal44@gmail.com",
                      //  CC = "10639274" + "@lntinfotech.com," + "10643265" + "@lntinfotech.com," + "10655380" + "@lntinfotech.com",
                    CC = "10670758@lntinfotech.com",

                    Subject = "Leave Application requested by Employee",
                    Body = MailBody_PM.ToString(),
                    Sender = "jamit8720@gmail.com",
                    CallingMethodName = MethodBase.GetCurrentMethod().Name,
                    Status = "Pending"
                };
              
                ObjMail_PM.Attachments = new Dictionary<string, Stream>
                            {
                                { "Leave_Request_Attachemnt.pdf", stream }
                            };
                MailController obj = new MailController();
                obj.SendMail(ObjMail_PM);

                return Ok();
            }
            #endregion

            catch (Exception ex)
            {
                return BadRequest("Something went wrong");
            }
        }



    }
}
