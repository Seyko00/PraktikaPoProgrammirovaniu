using System;

namespace Задание_2
{
    public class Notification
    {
        // События для отправки уведомлений
        public event Action<string> OnMessageSent;
        public event Action<string> OnCallMade;
        public event Action<string> OnEmailSent;

        // Метод для отправки сообщения
        public void SendMessage(string message)
        {
            OnMessageSent?.Invoke(message);
        }

        // Метод для совершения звонка
        public void MakeCall(string phoneNumber)
        {
            OnCallMade?.Invoke(phoneNumber);
        }

        // Метод для отправки электронного письма
        public void SendEmail(string email)
        {
            OnEmailSent?.Invoke(email);
        }
    }
}
