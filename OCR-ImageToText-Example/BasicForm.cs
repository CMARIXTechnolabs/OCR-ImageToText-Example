namespace OCR_ImageToText_Example
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Windows.Forms;
    using IronOcr;

    /// <summary>
    /// Basic form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class BasicForm : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicForm"/> class.
        /// </summary>
        public BasicForm()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// Handles the Click event of the ConvertToText button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnConvertToText_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = string.Empty;
                rtcText.Text = string.Empty;
                //// https://www.cmarix.com/git/DotNet/OCR-ImageToText-Example/Sample_1.tiff
                AutoOcr autoOcr = new AutoOcr();
                Image inputImage = this.GetImageFromURI(tbInputURL.Text);
                string inputFileName = this.GetFileNameURI(tbInputURL.Text);
                var result = autoOcr.Read(inputImage);

                if (result != null)
                {
                    lblStatus.Text = "Sucess : File name -" + inputFileName;
                    rtcText.Text = result.Text;
                }
                else
                {
                    lblStatus.Text = "Error : Sorry!! we are not getting any response from the library...";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error : " + ex.Message;
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Gets the image from URI.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        /// Object of System.Drawing.Image
        /// </returns>
        /// <exception cref="Exception">
        /// Invalid image
        /// or
        /// Invalid URL
        /// </exception>
        private Image GetImageFromURI(string url)
        {
            string exception = string.Empty;
            try
            {
                WebClient webClient = new WebClient();
                byte[] bytes = webClient.DownloadData(url);

                try
                {
                    MemoryStream memoryStream = new MemoryStream(bytes);
                    Image image = Image.FromStream(memoryStream);
                    return image;
                }
                catch
                {
                    exception = "Please provide only valid image path";
                    throw new Exception(exception);
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrEmpty(exception))
                {
                    throw new Exception("Invalid URL");
                }
                else
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Gets the file name URI.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>
        /// File name form URL
        /// </returns>
        private string GetFileNameURI(string url)
        {
            string filename = string.Empty;
            Uri uri = new Uri(url);
            filename = Path.GetFileName(uri.LocalPath);
            return filename;
        }

        #endregion
    }
}
