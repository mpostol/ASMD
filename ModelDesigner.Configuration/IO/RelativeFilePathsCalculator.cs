//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.IO;
using System.Text;

namespace CAS.CommServer.UA.ModelDesigner.Configuration.IO
{
  /// <summary>
  /// This class is responsible for operation on path, relative path, absolute path etc...
  /// </summary>
  public static class RelativeFilePathsCalculator
  {
    /// <summary>
    /// Tests if path is absolute.
    /// </summary>
    /// <param name="pathToBeTested">The path to be tested.</param>
    /// <returns>true if path is rooted and not relative</returns>
    /// <exception cref="ArgumentOutOfRangeException">pathToBeTested - The path is rooted but not absolute</exception>
    public static bool TestIfPathIsAbsolute( string pathToBeTested )
    {
      bool _ret = Path.IsPathRooted(pathToBeTested);
      if (_ret && (pathToBeTested != Path.GetFullPath(pathToBeTested)))
        throw new ArgumentOutOfRangeException(nameof(pathToBeTested), "The path is rooted but not absolute");
      return _ret;
    }
    /// Tries the compute relative path.
    /// </summary>
    /// <param name="BaseAbsolutePath">The base absolute path.</param>
    /// <param name="RelativeToBeComputed">The relative to be computed.</param>
    /// <returns>relative path if it was possible</returns>
    public static string TryComputeRelativePath(string BaseAbsolutePath, string RelativeToBeComputed)
    {
      if (string.IsNullOrEmpty(RelativeToBeComputed))
        return RelativeToBeComputed;
      string[] absoluteDirectories = BaseAbsolutePath.Split('\\');
      string[] relativeDirectories = RelativeToBeComputed.Split('\\');
      if (!Path.IsPathRooted(RelativeToBeComputed))
        return RelativeToBeComputed;
      if (!Path.IsPathRooted(BaseAbsolutePath) || (BaseAbsolutePath!= Path.GetFullPath(BaseAbsolutePath)))
        throw new ArgumentException($"{nameof(BaseAbsolutePath)} must be absolute and routed path");
      //Get the shortest of the two paths
      int length = absoluteDirectories.Length < relativeDirectories.Length ? absoluteDirectories.Length : relativeDirectories.Length;

      //Use to determine where in the loop we exited
      int lastCommonRoot = -1;
      int index;

      //Find common root
      for (index = 0; index < length; index++)
        if (absoluteDirectories[index] == relativeDirectories[index])
          lastCommonRoot = index;
        else
          break;

      //If we didn't find a common prefix then throw
      if (lastCommonRoot == -1)
        return RelativeToBeComputed;

      //Build up the relative path
      StringBuilder relativePath = new StringBuilder();

      //Add on the ..
      for (index = lastCommonRoot + 1; index < absoluteDirectories.Length; index++)
        if (absoluteDirectories[index].Length > 0)
          relativePath.Append("..\\");

      //Add on the folders
      for (index = lastCommonRoot + 1; index < relativeDirectories.Length - 1; index++)
        relativePath.Append(relativeDirectories[index] + "\\");
      relativePath.Append(relativeDirectories[relativeDirectories.Length - 1]);

      return relativePath.ToString();
    }

    ///// <summary>
    ///// Gets the absolute path to file in application data folder.
    ///// </summary>
    ///// <param name="filePath">The file path.</param>
    ///// <returns></returns>
    //public static FileInfo GetAbsolutePathToFileInApplicationDataFolder( string filePath )
    //{
    //  bool isAbsolute = TestIfPathIsAbsolute( filePath );
    //  if ( isAbsolute )
    //    return new FileInfo( filePath );
    //  else
    //    return new FileInfo( Path.Combine( InstallContextNames.ApplicationDataPath, filePath ) );
    //}
  }
}