MailAddress addressFrom = new MailAddress("jack.du@e-iceblue.com", "Jack Du");
MailAddress addressTo = new MailAddress("susanwong32@outlook.com");
MailMessage message = new MailMessage(addressFrom, addressTo);

message.Date = DateTime.Now;
message.Subject = "Sending Email with HTML Body";
string htmlString = @"<html>
                      <body>
                      <p>Dear Ms. Susan,</p>
                      <p>Thank you for your letter of yesterday inviting me to come for an interview on Friday afternoon, 5th July, at 2:30.
                              I shall be happy to be there as requested and will bring my diploma and other papers with me.</p>
                      <p>Sincerely,<br>-Jack</br></p>
                      </body>
                      </html>
                     ";
message.BodyHtml = htmlString;

SmtpClient client = new SmtpClient();
client.Host = "smtp.outlook.com";
client.Port = 587;
client.Username = addressFrom.Address;
client.Password = "password";
client.ConnectionProtocols = ConnectionProtocols.Ssl;
client.SendOne(message);

Console.WriteLine("Sent Successfully!");
Console.Read();