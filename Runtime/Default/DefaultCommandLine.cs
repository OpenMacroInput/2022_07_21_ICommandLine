using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DefaultCommandLine :  ICommandLine
{
    [SerializeField] string m_line;
        
    public void GetLine(out string text)
    {
        text = m_line;
    }

    public string GetLine()
    {
        return m_line;
    }

    public void GetLineInRefContainer(ref string container)
    {
        container = m_line;
    }

   
    public void GetNameRefInContainer(ref string name)
    {
        name = m_line;
    }

    public void SetLine(in string textWithNoSpace)
    {
        m_line= textWithNoSpace;
    }

    public void SetName(in string name)
    {
        m_line = name;
    }
  

}
