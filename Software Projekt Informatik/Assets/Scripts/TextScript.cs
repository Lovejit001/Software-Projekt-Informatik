using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    Text textField;
    public int text = 0;
    void Start()
    {
        textField = GameObject.Find("Main Text").GetComponent<Text>();
    }
    public void Text1()
    {
        text +=1;
        if(text==2)
        {
            textField.text = "Ohh..";
        }
        if(text==3)
        {
            textField.text = "So you are finally awake now.";
        }
        if(text==4)
        {
            textField.text = "Where did you get yourself in?";
        }
        if(text==5)
        {
            textField.text = "bla bla bla ";
        }
        if(text==6)
        {
            textField.text = "bla bla wrtzuwrzbla";
        }
        if(text==7)
        {
            textField.text = "gzigzv yrtzorwzw";
        }
    }
}
