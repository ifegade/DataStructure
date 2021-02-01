using System;
using System.Collections.Generic;

namespace data
{
    public class MinimumFolder
    {
        public MinimumFolder()
        {
            Console.WriteLine(minFolders(1, 1, 0, 1));

            Console.WriteLine(renameFile("aba", "ababa"));
        }
        static HashSet<int> data = new HashSet<int>();
        static int folderCount = 0;
        public static int minFolders(int cssFiles, int jsFiles, int readMeFiles, int capacity)
        {



            return 0;
        }

        public static int renameFile(string newName, string oldName)
        {
            int start = 0;
            int end = oldName.Length;

            while (start < end)
            {

            }

            return 0;
        }
    }
}
