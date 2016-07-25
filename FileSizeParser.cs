using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum FileSizeFormats //AllAvailableValues still not implemented
{
  AllAvailableValues,
  MostAppropriate
}

public static class FileSizeParser
{
    /// <summary>
    /// Parses a Long and the Format and returns a formatted string according to the FileSizeFormat input
    /// </summary>
    /// <param name="l">File Length in bytes as a long</param>
    /// <returns>Returns a formatted string containing size of the file input</returns>
    public static string ParseLong (long l, FileSizeFormats format = FileSizeFormats.MostAppropriate)
    {
        string return_string = "";
        switch (format)
        {
            case FileSizeFormats.MostAppropriate:
                if (l >= 1073741824)
                {
                    //Gigabytes
                    double numberOfGBS = (double)(l / 1073741824);
                    return_string = numberOfGBS.ToString() + " GB";
                }
                else if (l >= 1048576)
                {
                    //Megabytes
                    double numberOfMBS = (double)(l / 1048576);
                    return_string = numberOfMBS.ToString() + " MB";
                }
                else if (l >= 1024)
                {
                    //Kilobytes
                    double numberOfKBS = (double)(l / 1024);
                    return_string = numberOfKBS.ToString() + " KB";
                }
                else
                {
                    //Bytes
                    double numberOfBS = (double)(l);
                    return_string = numberOfBS.ToString() + " Bytes";
                }
                break;
        }

      return return_string;
      }
}
