using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EASendMail;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        

void Send_OAUTH(string email, string access_token ) 
{ 
    SmtpMail oMail = new SmtpMail("TryIt"); 
    SmtpClient oSmtp = new SmtpClient(); 

    // Your gmail email address
    oMail.From = email; 

    // Set recipient email address
    oMail.To = "samithaadikari@gmail.com"; 

    // Set email subject
    oMail.Subject = "test email from gmail account with OAUTH 2"; 

    // Set email body
    oMail.TextBody = "this is a test email sent from c# project with gmail."; 

    // Gmail SMTP server address
    SmtpServer oServer = new SmtpServer("smtp.gmail.com"); 

    // Using 587 port, you can also use 465 port
    oServer.Port = 587;

    // enable SSL connection
    oServer.ConnectType = SmtpConnectType.ConnectSSLAuto; 

    // use Gmail SMTP OAUTH 2.0 authentication
    oServer.AuthType = SmtpAuthType.XOAUTH2;
    oServer.User = email; 

    // use the access token as password
    oServer.Password = access_token;   

    try 
    { 
        Console.WriteLine("start to send email using OAUTH 2.0 ..."); 
        oSmtp.SendMail(oServer, oMail); 
        Console.WriteLine("email was sent successfully!"); 
    } 
    catch (Exception ep) 
    { 
        Console.WriteLine("failed to send email with the following error:"); 
        Console.WriteLine(ep.Message); 
    } 
} 
    }
}
