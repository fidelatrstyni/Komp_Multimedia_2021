using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayChangedTextContent : MonoBehaviour
{
    // Start is called before the first frame update
    private InputField InputField;
    void Start()
    {
        InputField = GetComponent<InputField>();
    }

    // Update is called once per frame
    public void PrintNewValue()
    {
        string msg = "new content = '" + InputField.text + "'";
        print(msg);
    }
}
