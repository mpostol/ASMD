//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Class that is responsible for generating unique names this list contains the list of names, no name can be the same.
  /// This class can generate unique names based on the template. Client can add names to the list and class engine is responsible that no names are the same
  /// </summary>
  internal class UniqueNameGenerator
  {
    #region private

    private List<string> m_MList = new List<string>();
    private readonly string m_Prefix;
    private int m_Counter = 0;

    #endregion private

    #region public API

    /// <summary>
    /// the exception thrown by UniqueNameGenerator
    /// </summary>
    [Serializable]
    internal class UniqueNameGeneratorException : Exception
    {
      internal UniqueNameGeneratorException(string message)
        : base(message)
      { }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UniqueNameGenerator"/> class.
    /// </summary>
    /// <param name="prefix">The prefix.</param>
    internal UniqueNameGenerator(string prefix)
    {
      m_Prefix = prefix;
    }

    /// <summary>
    /// Checks if name exists.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>true if name exists in generator</returns>
    internal bool CheckIfNameExists(string name)
    {
      return m_MList.Contains(name);
    }

    /// <summary>
    /// Checks the name and if name exists it returns suggested name.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>the suggested name</returns>
    internal string CheckIfNameExistsAndReturnSuggestedName(string name)
    {
      int counter = 0;
      if (!m_MList.Contains(name))
        return name;
      else
      {
        string newname = "";
        do { newname = name + "_" + (++counter).ToString(); }
        while (m_MList.Contains(newname));
        return newname;
      }
    }

    /// <summary>
    /// Adds a name to the collection of unique names.
    /// </summary>
    /// <param name="newName">The new name.</param>
    /// <param name="throwExceptionIfNameExistOnTheListOfPreviousNames">if set to <c>true</c> the method throws exception if name exist on the list of previous names.</param>
    internal void AddName(string newName, bool throwExceptionIfNameExistOnTheListOfPreviousNames)
    {
      lock (this)
      {
        if (m_MList.Contains(newName))
        {
          if (throwExceptionIfNameExistOnTheListOfPreviousNames)
            throw new UniqueNameGeneratorException("This generator already contains such name");
          else
            return;
        }
        m_MList.Add(newName);
      }
    }

    /// <summary>
    /// Adds the name.
    /// </summary>
    /// <param name="newName">The new name.</param>
    public void AddName(string newName)
    {
      AddName(newName, true);
    }

    /// <summary>
    /// Removes the name.
    /// </summary>
    /// <param name="nameToBeRemoved">The name to be removed.</param>
    public void RemoveName(string nameToBeRemoved)
    {
      m_MList.Remove(nameToBeRemoved);
    }

    /// <summary>
    /// Generates the new name.
    /// </summary>
    /// <returns>new name</returns>
    public string GenerateNewName()
    {
      string _nameToBeReturned;
      lock (this)
      {
        do
        {
          _nameToBeReturned = string.Format(m_Prefix + "{0}", m_Counter++);
        } while (m_MList.Contains(_nameToBeReturned));
        m_MList.Add(_nameToBeReturned);
      }
      return _nameToBeReturned;
    }

    #endregion public API
  }
}