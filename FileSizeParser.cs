using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        if(format == FileSizeFormats.MostAppropriate)
        {
    	    if (l >= 1073741824)
                return string.Format("{0} GB",(long)(l / 1073741824))
            else f i(l >= 1048576)
                 return string.Format("{0} MB",(long)(l / 1048576))
            else if (l >= 1024)
                return string.Format("{0} KB",(long)(l / 1024))
            else
                return string.Format("{0} Bytes",(long)(l / 1024))
        }
    }
    
    /// <summary>
    /// Extension for FileInfo
    /// </summary>
    public static string SizeToString(this FileInfo fi,FileSizeFormats format = FileSizeFormats.MostAppropriate)
    {
    	if(fi.Exists)
    		return ParseLong(fi.Length,format);
    }
}
