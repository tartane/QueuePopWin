namespace QueuePopDesktop.Models
{
    internal class AppStatus
    {
        private AppStatus(string value) { Value = value; }

        public string Value { get; private set; }

        public static AppStatus LISTENING { get { return new AppStatus("Listening to audio output..."); } }

        public static AppStatus READY { get { return new AppStatus("Ready to start"); } }

        public static AppStatus CHECKING_UPDATE { get { return new AppStatus("Checking for update..."); } }

        public static AppStatus LOADING_FINGERPRINTS { get { return new AppStatus("Loading fingerprints..."); } }

        public override string ToString()
        {
            return Value;
        }

    }
}
