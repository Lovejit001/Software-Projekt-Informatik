using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingBackground : MonoBehaviour
{
    public GameObject Settings;
    public GameObject Street1;
    public GameObject Dialogue1;
    public GameObject Dialogue2;
    public GameObject Dialogue3;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OptionSetting1()
    {
        Settings.SetActive(true);
    }
    public void OptionSetting2()
    {
        Settings.SetActive(false);
    }
    public void Background()
    {
        Street1.SetActive(true);
    }

    public void DialogueChange1()
    {
        Dialogue1.SetActive(true);
    }

    public void DialogueChange2()
    {
        Dialogue2.SetActive(true);
    }

    public void DialogueChange3()
    {
        Dialogue3.SetActive(true);
    }
}
