using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BabyCarrot.Tools
{
    public class LogManager
    {
        private string _path;
        

        #region Constructors
        public LogManager(string path)
        {
            _path = path;
            _SetLogPath();
        }

        public LogManager()
            :this(Path.Combine(Application.Root, "Log"))
        {
        }
        /*경로를 받지 않은 생성자에서 클래스내의 생성자를 호출하여 경로를 리턴해주는 형태*/
        #endregion

        #region Methods
        private void _SetLogPath()
        {
            if(!System.IO.Directory.Exists(_path))
                System.IO.Directory.CreateDirectory(_path);

            string logFile = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            _path = Path.Combine(_path, logFile);
        }

        public void Write(string data)
        {
            using (StreamWriter writer = new StreamWriter(_path, true))
            {
                writer.Write(data);
            }
        }

        public void WriteLine(string data)
        {
            using (StreamWriter writer = new StreamWriter(_path, true))
            {
                writer.WriteLine(data);
            }
        }
        #endregion
    }
}
