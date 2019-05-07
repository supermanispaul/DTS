using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Tracking_w_Barcode
{
    public class Document : Connection,IDisposable
    {
        public string Tags { get; set; }
        public string UploadedFile { get; set; }
        public string DocumentType { get; set; }
        public string PrimaryDocument { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateReceived { get; set; }
        public string EmployeeFrom { get; set; }
        public List<string> SendTo = new List<string>();
        public string Transportation { get; set; }
        public int DocType { get; set; }
        public string Subject { get; set; }
        public int PrimaryDoc { get; set; }
        public string Title { get; set; }
        public string Remarks { get; set; }
        public int RemarkID { get; set; }
        public int LastRemarkID { get; set; }
        public List<string> RemarksList { get; set; }
        public string BarcodeNo { get; set; }
        public string DocumentLocation { get; set; }
        public bool SavedDoc { get; set; }
        public string DelayedDocument { get; set; }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Document()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
