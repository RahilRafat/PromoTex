﻿namespace PromoTex.Services
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(string to, string subject, string htmlContent);
    }
}
