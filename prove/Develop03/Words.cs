using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Words
{
    // Declares attributes
    private string _word;
    private bool _hide;
    
    // Set up Cosntructors
    public Words(string word)
    {
        _word = word;
        _hide = false;
    }
  
    public void SetHide()
    {
        _hide = true;
    }

    public bool GetHide()
    {
        bool hide = _hide;
        return hide;
    }
    
    public string HideWord()
    {
        string hidden = "";
        foreach (char letter in _word)
        {
            hidden = hidden + "_";
        }
        hidden = hidden + " ";
        return hidden;

    }

    public string ShowWord()
    {
        string word = _word + " ";
        return word;
    }

}