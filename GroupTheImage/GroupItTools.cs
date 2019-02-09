using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTheImage
{

    public static class GroupItTools
    {
        private static bool allFiletypes = true;

        public enum GroupOption
        {
            Move,
            Copy
        }

        public static List<string> GetContent(string path)
        {
            List<string> content = new List<string>();
            var images = Directory.GetFiles(path);
            if(images.Length > 0)
            {
                content = images.ToList();
            }
            return content;
        }

        // Main method that do the job
        public async static void GroupImages(string sourcePath, string destinPath, List<string> extensions, GroupOption option)
        {
            // Condition checks
            if (!Directory.Exists(sourcePath))
                throw new System.IO.DirectoryNotFoundException();

            if (!Directory.Exists(destinPath))
                throw new System.IO.DirectoryNotFoundException();

            if (option == null)
                throw new Exception("Group option not selected");

            if (extensions.Count > 0)
                allFiletypes = false;

            List<string> filesOnSource = Directory.GetFiles(sourcePath).ToList();
            List<string> filteredFiles = allFiletypes ? filesOnSource : filesOnSource.Where(f => extensions.Contains(Path.GetExtension(f))).ToList();

            // Copy or Move files
            foreach (string fileName in filteredFiles)
            {
                using (FileStream fs = File.Open(fileName, FileMode.Open))
                {
                    var newFullName = Path.Combine(new string[] { destinPath, File.GetCreationTime(fileName).ToLongDateString(), Path.GetFileName(fileName) });

                    var directory = Path.GetDirectoryName(newFullName);
                    if (!Directory.Exists(directory))
                    {
                        var dir = Directory.CreateDirectory(Path.GetDirectoryName(newFullName));
                    }

                    using (FileStream destination = File.Create(newFullName))
                    {
                        await fs.CopyToAsync(destination);

                    }
                }

            }
        }

    }
}
