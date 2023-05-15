using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListKomponenKomputer : MonoBehaviour
{
    public int listNomor;
    public bool buttonOnClick;
    void Start()
    {
        buttonOnClick = false;
        PlayerPrefs.SetInt("nomorButton", 0);
    }
    void Update()
    {
        
    }
    public void ButtonKomponenKomputer()
    {
        buttonOnClick = true;
        PlayerPrefs.SetInt("nomorButton", listNomor);
    }
}
