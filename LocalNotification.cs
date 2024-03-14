using Microsoft.Toolkit.Uwp.Notifications;

namespace QueuePopDesktop
{
    public class LocalNotification
    {

        private ToastContentBuilder _toastBuilder;

        private LocalNotification(ToastContentBuilder toastBuilder)
        {
            _toastBuilder = toastBuilder;
        }

        static public LocalNotification create(string title, string text)
        {
            return new LocalNotification(new ToastContentBuilder()
                                            .AddText(title)
                                            .AddText(text));
        }

        public void send()
        {
            try
            {
                _toastBuilder?.Show();
            }
            catch (Exception)
            {
                //Could sometime throw the notification service unavailable (happened once in testing)
            }
            
        }

    }
}
