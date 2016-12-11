using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich
{
    static class Program
    {
        public static string CompanyName = "OOD";
        public static string AppName = "TourManagement";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            initAppData();

            // Nếu chưa tồn tại file db thì copy file db gốc vào thư mục db
            if (DatabaseManager.getInsance().isValidDataFile() == false)
            {
                DatabaseManager.getInsance().createDataFile();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmMain());
        }

        private static void initAppData()
        {
            AppDataDirectory.OriginRoot = System.IO.Directory.GetCurrentDirectory();
            // Get đường dẫn tuyệt đối cho %AppData%
            string windowAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // thư mục root của ứng dụng là %AppData%\TênTổChức\TênApp
            AppDataDirectory.AppDataRoot = windowAppDataPath + "\\" + CompanyName + "\\" + AppName;

            // Nếu thư mục không tồn tại thì tạo thư mục mới
            if (Directory.Exists(AppDataDirectory.AppDataRoot) == false)
                System.IO.Directory.CreateDirectory(AppDataDirectory.AppDataRoot);

            // Set thư mục gốc của ứng dụng trở thành thư mục AppData
            System.IO.Directory.SetCurrentDirectory(AppDataDirectory.AppDataRoot);

            // Set thư mục DataDirectory để dùng cho connectionString
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDataDirectory.AppDataRoot);
        }

        public class AppDataDirectory
        {
            public static string OriginRoot = "";
            public static string AppDataRoot = "";
        }
    }
}
