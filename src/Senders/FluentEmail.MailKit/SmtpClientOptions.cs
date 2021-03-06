﻿using MailKit.Security;

namespace FluentEmail.MailKitSmtp
{
    public class SmtpClientOptions
    {
        public string Server { get; set; } = string.Empty;
        public int Port { get; set; } = 25;
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool UseSsl { get; set; } = false;
        public bool RequiresAuthentication { get; set; } = false;
        public string PreferredEncoding { get; set; } = string.Empty;
        public bool UsePickupDirectory { get; set; } = false;
        public string MailPickupDirectory { get; set; } = string.Empty;
        public SecureSocketOptions? SocketOptions { get; set; }
        public bool BypassCertificateValidation { get; set; } = false;
        public Dkim Dkim { get; set; }
    }

    public class Dkim
    {
        public bool Sign { get; set; } = false;
        public string Selector { get; set; } = string.Empty;
        public string Domain { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
    }
}
