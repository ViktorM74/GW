using System;
using System.Collections;
using System.Collections.Generic;

namespace AddFilesToFolder
{
    public class NewPath : IEnumerable, IEnumerator
    {
        private List<string> pathLocalValue = new List<string>();
        private List<string> pathServerValue = new List<string>();
        int index = -1;

        public List<string> pathLocal
        {
            get {
                return pathLocalValue;
            }

            set {
                pathLocalValue.Add(value.ToString());
            }
        }

        public List<string> pathServer
        {
            get {
                return pathServerValue;
            }

            set {
                pathServerValue.Add(value.ToString());
            }
        }

        public object Current => throw new NotImplementedException();

        // Реализуем интерфейс IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        // Реализуем интерфейс IEnumerator
        public bool MoveNext()
        {
            int locCount = pathLocalValue.Count;
            int serCount = pathServerValue.Count;
            int len = locCount;
            if (locCount < serCount)
                len = serCount;

            if (index == len - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }

    public class ListFile
    {
        public string Name
        {
            get; set;
        }
        public string Date
        {
            get; set;
        }
        public string OldPath
        {
            get; set;
        }

        public NewPath NewPathFile = new NewPath();
        //NewPathFile { get; set; }

        public ListFile(string oldpath, string name, string date)
        {
            Name = name;
            Date = date;
            OldPath = oldpath;
        }
    }
}
