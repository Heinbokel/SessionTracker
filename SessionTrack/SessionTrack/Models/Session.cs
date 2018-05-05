using System;
namespace SessionTrack.Models
{
    public class Session
    {
        public int SessionId
        {
            get;
            set;
        }

        public string SessionName
        {
            get;
            set;
        }

        public string SessionDescription
        {
            get;
            set;
        }

        public DateTime SessionStart
        {
            get;
            set;
        }

        public DateTime SessionEnd
        {
            get;
            set;
        }

        //UserId
    }
}
