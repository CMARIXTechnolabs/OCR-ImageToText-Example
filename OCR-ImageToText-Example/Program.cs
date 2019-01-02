namespace OCR_ImageToText_Example
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Program start points
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BasicForm());
        }
    }
}
