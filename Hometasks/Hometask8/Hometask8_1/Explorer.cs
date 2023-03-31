using System.Numerics;

namespace Hometask8.Hometask8_1
{
    internal class Explorer
    {
        private readonly string _dirName = @"E:\Files\Proj\C#\IT-Academy-CSharp\Hometasks\Hometask8\bin\Debug\net7.0";

        public void Manage()
        {
            bool loop = true;

            while (loop)
            {
                ShowMenu(_dirName);

                switch (GetIntNumber(0, 9))
                {
                    case 1:
                        CreateDirectory();
                        break;
                    case 2:
                        DeleteDirectory();
                        break;
                    case 3:
                        CreateFile();
                        break;
                    case 4:
                        DeleteFile();
                        break;
                    case 5:
                        CopyFile();
                        break;
                    case 6:
                        MoveFile();
                        break;
                    case 7:
                        RenameFile();
                        break;
                    case 8:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("[!] Input Error [!]");
                        break;
                }
            }
        }

        private static void ShowMenu(string dirName)
        {
            Console.Clear();
            Console.WriteLine($"\n\tCurrent directory: {dirName}");

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("\n\tFiles:\n");

                string[] files = Directory.GetFileSystemEntries(dirName);

                foreach (string s in files)
                {
                    Console.WriteLine($"\t{s.Split('\\')[^1]}");
                }
            }

            Console.WriteLine("\n   Menu:\n");
            Console.WriteLine(" 1 - Create directory");
            Console.WriteLine(" 2 - Delete directory");
            Console.WriteLine(" 3 - Create file");
            Console.WriteLine(" 4 - Delete file");
            Console.WriteLine(" 5 - Copy file");
            Console.WriteLine(" 6 - Move file");
            Console.WriteLine(" 7 - Rename file\n");
            Console.Write(" 8 - Exit\t");

        }

        private void CreateDirectory()
        {
            Console.Clear();

            Console.Write("Create directory:\nEnter directory name: ");
            Directory.CreateDirectory(Console.ReadLine());

            Console.WriteLine("Successfully created! Press any key...");
            Console.ReadKey();
        }
        private void DeleteDirectory()
        {
            Console.Clear();

            Console.Write("Delete directory:\nEnter directory name: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Console.WriteLine("Successfully deleted!");
            }
            else
            {
                Console.WriteLine("Directory doesn't exist!");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private void CreateFile()
        {
            Console.Clear();

            Console.Write("Create File:\nEnter file name: ");
            File.Create(Console.ReadLine());

            Console.WriteLine("Successfully created! Press any key...");
            Console.ReadKey();
        }

        private void DeleteFile()
        {
            Console.Clear();

            Console.Write("Delete File:\nEnter file name: ");
            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Successfully deleted!");
            }
            else
            {
                Console.WriteLine("File doesn't exist!");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private void CopyFile()
        {
            Console.Clear();

            Console.Write("Copy File:\nEnter source: ");
            string source = Console.ReadLine();

            Console.Write("Enter destination: ");
            string dest = Console.ReadLine();

            File.Copy(source, dest, true);

            Console.WriteLine("Successfully copied! Press any key...");
            Console.ReadKey();
        }


        private void MoveFile()
        {
            Console.Clear();

            Console.Write("Move File:\nEnter source: ");
            string source = Console.ReadLine();

            Console.Write("Enter destination: ");
            string dest = Console.ReadLine();

            File.Move(source, dest, true);

            Console.WriteLine("Successfully moved! Press any key...");
            Console.ReadKey();
        }

        private void RenameFile()
        {
            Console.Clear();

            Console.Write("Rename File:\nEnter filename: ");
            string source = Console.ReadLine();

            Console.Write("Enter new filename: ");
            string dest = Console.ReadLine();

            File.Copy(source, dest, true);
            File.Delete(source);

            Console.WriteLine("Successfully renamed! Press any key...");
            Console.ReadKey();
        }

        private static int GetIntNumber(int min, int max)
        {
            Vector2 cursor = new Vector2(Console.CursorLeft, Console.CursorTop);
            int number;

            while (true)
            {
                Console.SetCursorPosition(((int)cursor.X), (int)cursor.Y);
                Console.Write(" ");
                Console.SetCursorPosition(((int)cursor.X), (int)cursor.Y);

                int.TryParse(Console.ReadLine(), out number);

                if (number <= min || number >= max)
                {
                    Console.WriteLine($"\nIncorrect number!");
                }
                else
                {
                    break;
                }
            }

            return number;
        }
    }
}
