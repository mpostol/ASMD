//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.CommServer.UA.Common;
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
    public static bool TestIfPathIsAbsolute(string pathToBeTested)
    {
      bool _ret = Path.IsPathRooted(pathToBeTested);
      if (_ret && (pathToBeTested != Path.GetFullPath(pathToBeTested)))
        throw new ArgumentOutOfRangeException(nameof(pathToBeTested), "The path is rooted but not absolute");
      return _ret;
    }

    /// <summary>
    /// Tries the compute relative path.
    /// </summary>
    /// <param name="baseAbsolutePath">The base absolute path.</param>
    /// <param name="filePath">The relative to be computed.</param>
    /// <returns>relative path if it was possible</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// baseAbsolutePath - The parameter must be absolute path
    /// or
    /// or
    /// </exception>
    public static string TryComputeRelativePath(string baseAbsolutePath, string filePath)
    {
      if (!TestIfPathIsAbsolute(baseAbsolutePath))
        throw new ArgumentOutOfRangeException(nameof(baseAbsolutePath), "The parameter must be absolute path");
      if (string.IsNullOrEmpty(Path.GetFileName(filePath)))
        throw new ArgumentOutOfRangeException(nameof(filePath), " This parameter has to encapsulate file path");
      if (!Path.IsPathRooted(filePath))
        return filePath;
      if (!TestIfPathIsAbsolute(filePath))
        throw new ArgumentOutOfRangeException(nameof(filePath), "The path is rooted, but must be relative or absolute");
      string[] absoluteDirectories = baseAbsolutePath.Split('\\');
      string[] relativeDirectories = filePath.Split('\\');
      //Get the shortest of the two paths
      int _length = Math.Min(absoluteDirectories.Length, relativeDirectories.Length);
      //Use to determine where in the loop we exited
      int lastCommonRoot = -1;
      //Find common root
      for (int _index = 0; _index < _length; _index++)
        if (absoluteDirectories[_index] == relativeDirectories[_index])
          lastCommonRoot = _index;
        else
          break;
      //If we didn't find a common prefix then return filePath
      if (lastCommonRoot == -1)
        return filePath;
      //Build up the relative path
      StringBuilder relativePath = new StringBuilder();
      //Add on the ..
      for (int _index = lastCommonRoot + 1; _index < absoluteDirectories.Length; _index++)
        if (absoluteDirectories[_index].Length > 0)
          relativePath.Append("..\\");
      //Add on the folders
      for (int _index = lastCommonRoot + 1; _index < relativeDirectories.Length - 1; _index++)
        relativePath.Append(relativeDirectories[_index] + "\\");
      relativePath.Append(relativeDirectories[relativeDirectories.Length - 1]);
      return relativePath.ToString();
    }

    /// <summary>
    /// Calculates the name of the absolute file name, If the <paramref name="name"/> is relative it prefixes it with the <paramref name="solutionDirectory"/>.
    /// </summary>
    /// <param name="name">The name to be converted to absolute name.</param>
    /// <param name="solutionDirectory">The solution directory.</param>
    /// <returns>Absolute file name prefixed by the <paramref name="solutionDirectory"/> if needed.</returns>
    public static string CalculateAbsoluteFileName(string name, string solutionDirectory)
    {
      if (!RelativeFilePathsCalculator.TestIfPathIsAbsolute(name))
        name = Path.Combine(solutionDirectory, name);
      return name;
    }
  }
}