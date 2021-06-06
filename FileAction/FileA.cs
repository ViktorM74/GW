using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FileAction
{
    public class FileA
    {
        public static bool RunPath(string path)
        {
            if (GetAtributesPath(path))
                return RunFile(path);
            else
                return RunFolder(path);
        }


        // Запускает файл по указанному пути
        public static bool RunFile(string path)
        {
            if (File.Exists(path))
            {
                Process.Start(path);
                return true;
            }
            else
                MessageBox.Show("Ошибка! Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Открывает папку по указанному пути
        public static bool RunFolder(string path)
        {
            if (Directory.Exists(path))
            {
                Process.Start(path);
                return true;
            }
            else
                MessageBox.Show("Ошибка! Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Создает папку с именем Name по пути path
        public static bool CreateFolder(string Name, string path)
        {
            //path = path + "\\" + Name;
            path = Path.Combine(path, Name);
            bool folderExists = Directory.Exists(path);

            if (!folderExists)
            {
                Directory.CreateDirectory(path);
                return true;
            }
            else
            {
                //MessageBox.Show("Папка существует");
                return false;
            }
        }

        public static bool CreateFolder(string newPath)
        {
            bool folderExists = Directory.Exists(newPath);

            if (!folderExists)
            {
                Directory.CreateDirectory(newPath);
                return true;
            }
            else
            {
                //MessageBox.Show("Папка существует");
                return false;
            }
        }

        // Удаляет папку по указанному пути
        public static bool DeleteFolder(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (folderExists)
            {
                Directory.Delete(path, true);
                return true;
            }
            else
            {
                MessageBox.Show("Папка не найдена");
                return false;
            }
        }

        // Копирует файл по указанному полному пути file в новое место path
        public static bool CopyFile(string file, string path)
        {
            string fileName = Path.GetFileName(file);
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                path = Path.Combine(path, fileName);
                File.Copy(file, path);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка копирования" + ex.Message);
                return false;
            }

        }

        // Копирует папку  source со всем подпапками и файлами в новое место target
        // В качестве параметров принимает DirectoryInfo
        public static void CopyDirRecursive(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);
            // Копируем все файлы из папки
            foreach (FileInfo f1 in source.GetFiles())
            {
                f1.CopyTo(Path.Combine(target.FullName, f1.Name), true);
            }
            // копируем все подпапки
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyDirRecursive(diSourceSubDir, nextTargetSubDir);
            }
        }

        // Копирует папку  source со всем подпапками и файлами в новое место target
        // В качестве параметров принимает string
        public static void CopyFolder(string FromDir, string ToDir)
        {
            DirectoryInfo fDir = new DirectoryInfo(FromDir);
            DirectoryInfo tDir = new DirectoryInfo(ToDir);

            DirectoryInfo NewtDir = new DirectoryInfo(Path.Combine(tDir.FullName, fDir.Name));
            CopyDirRecursive(fDir, NewtDir);
        }

        // Копирует файлы либо папки переданные в виде списка listF 
        // в новое место newPath
        public static bool CopyListFiles(List<string> listF, string newPath)
        {
            try
            {
                foreach (string f in listF)
                {
                    if (GetAtributesPath(f))
                        CopyFile(f, newPath);
                    else
                        CopyFolder(f, newPath);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public static bool CopyListFiles(List<string> listF, List<string> newPath)
        {
            try
            {
                foreach (string f in listF)
                {
                    if (GetAtributesPath(f))
                        foreach (string p in newPath)
                            CopyFile(f, p);
                    else
                        foreach (string p in newPath)
                            CopyFolder(f, p);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        // Проверяет что является целью пути path
        // true - file
        // false - Directory
        public static bool GetAtributesPath(string path)
        {
            // get the file attributes for file or directory
            try
            {
                FileAttributes attr = File.GetAttributes(path);

                if (attr.HasFlag(FileAttributes.Directory))
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }

        // Удаляет файл или папку name по двум указанным путям  pLocal, pServer
        public static void DeleteDocument(string name, string pLocal, string pServer)
        {
            void D(string p)
            {
                string p1 = Path.Combine(p, name);
                if (GetAtributesPath(p1))
                {
                    if (File.Exists(p1))
                        File.Delete(p1);
                }
                else
                    DeleteFolder(p1);
            }

            if (!String.IsNullOrEmpty(pLocal))
                      D(pLocal);
            if (!String.IsNullOrEmpty(pServer))
                      D(pServer);

        }

        //Переименовывает папку по пути dirPath используя новое имя newName
        public static bool RenameDirectory(string dirPath, string newName)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);

            if (Directory.Exists(dir.FullName))
            {
                string newpath = Path.Combine(dir.Parent.FullName, newName);

                try
                {
                    Directory.Move(dir.FullName, newpath);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
