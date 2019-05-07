using System;

namespace Document_Tracking_w_Barcode
{
    public partial class Connection
    {
        public class MySqlNotificationEventArgs : EventArgs
        {
            public delegate void OnChangeEventHandler(object sender, MySqlNotificationEventArgs e);
        }
    }
}
