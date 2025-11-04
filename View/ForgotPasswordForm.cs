using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Jeep.View
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btn_send_otp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email address should be in a valid format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate OTP
            string otp = GenerateOTP();

            // Send OTP via email
            if (SendOTPEmail(email, otp))
            {
                MessageBox.Show($"OTP has been sent to {email}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open OTP verification form
                bool isForgotPassword = true;
                var form = new VerifyOTPForm(isForgotPassword, otp, email); 
                form.Show();
                this.Close();

            }
        }

        private string GenerateOTP()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString(); // 6-digit OTP
        }

        private bool SendOTPEmail(string toEmail, string otp)
        {
            try
            {
                string fromEmail = "your-email@gmail.com"; // Replace with your sender email
                string fromPassword = "your-email-password"; // Replace with your email app password

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = "Your OTP Code";
                mail.Body = $"Your OTP for password reset is: {otp}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
