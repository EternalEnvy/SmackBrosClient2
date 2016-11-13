using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NeptuneRenderEngine.Engine.Utilities.IO
{
    public class FileListener
    {
        private readonly object _lock = 1;
        private bool _triggered;

        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            private set
            {
                _filePath = value;
                Update();
            }
        }

        private string _fullPath;
        public string FullPath
        {
            get { return _fullPath; }
            private set
            {
                _fullPath = value;
                Update();
            }
        }

        private string _directory;
        public string Directory
        {
            get { return _directory; }
            private set
            {
                _directory = value;
                Update();
            }
        }

        private readonly FileSystemWatcher _fileSystemWatcher;

        public FileListener(string filePath)
        {
            _filePath = filePath;
            _fullPath = Path.GetFullPath(_filePath);
            _directory = Path.GetFullPath(_filePath.Substring(0, _filePath.LastIndexOf('/')));

            _fileSystemWatcher = new FileSystemWatcher();
            Update();
            _fileSystemWatcher.Changed += (sender, args) =>
            {
                //Console.WriteLine("{0} {1} {2}", args.FullPath, FullPath, args.FullPath.Equals(FullPath));
                if (args.ChangeType == WatcherChangeTypes.Changed && args.FullPath.Equals(FullPath))
                {
                    Thread.Sleep(20);
                    lock (_lock)
                    {
                        _triggered = true;
                    }
                }
            };
        }

        private void UpdatePaths(string filePath)
        {
            FilePath = filePath;
            FullPath = Path.GetFullPath(FilePath);
            Directory = Path.GetFullPath(FilePath.Substring(0, FilePath.LastIndexOf('/')));
        }

        private void Update()
        {
            _fileSystemWatcher.Path = Directory;
            _fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size;
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        public bool Check()
        {
            lock (_lock)
            {
                return _triggered;
            }
        }

        public void Reset()
        {
            lock (_lock)
            {
                _triggered = false;
            }
        }
    }
}
