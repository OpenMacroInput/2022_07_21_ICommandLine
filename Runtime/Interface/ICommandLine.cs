using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Command Line definition is a line of text without -->return line<-- that represent an action to do if understood by an interpreter. 
/// </summary>
public interface ICommandLine : ICommandLineGet, ICommandLineSet
{ }


public interface ICommandLineGet
{
    public void GetLineInRefContainer(ref string container);
    public void GetLine(out string text);
    public string GetLine();
}

public interface ICommandLineSet
{
    public void SetLine(in string textWithNoSpace);
}
