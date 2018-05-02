using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median
{
    class FileList
    {
        string[] filePaths;
        List<string> extensions;
        public FileList(string[] paths) {
            this.filePaths = paths;
            setExtensions();
        }

        private void setExtensions() {
            for (int i = 0; i < this.filePaths.Length; i++)
            {
                for (int j = this.filePaths[i].Length; j >= 0; j--)
                {
                    string extension = "";
                    if (filePaths[i][j] == '.')
                    {
                        if (extensions.Count() == 0)
                        {
                            extensions.Add(extension);
                            extension = "";
                            break;
                        }
                        else
                        {
                            Boolean exists = false;
                            for (int k = 0; k < extensions.Count; k++)
                            {
                                if (extension == extensions[k])
                                {
                                    exists = true;
                                    break;
                                }
                            }
                            if (!exists)
                            {
                                extensions.Add(extension);
                                extension = "";
                            }

                        }
                        
                    }
                    else
                    {
                        extension = filePaths[i][j].ToString() + extension;
                    }
                }
            }
        }
        public List<string> getExtensions() {
            return this.extensions;
        }
        public string[] getPaths() {
            return this.filePaths;
        }
    }
}
