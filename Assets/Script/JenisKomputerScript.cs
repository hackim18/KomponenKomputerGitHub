using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JenisKomputerScript : MonoBehaviour
{
    public GameObject[] objectHalaman;
    public Text textHalaman;
    public int nomorHalaman;
    public bool prevClick, nextClick;

    void Start()
    {
        nomorHalaman = 0;
        prevClick = false;
        nextClick = false;
    }
    void Update()
    {
        int a = nomorHalaman + 1;
        textHalaman.text = a.ToString() + "/3";
        objectHalaman[nomorHalaman].SetActive(true);
        if (prevClick == true)
        {
            objectHalaman[nomorHalaman].SetActive(false);
            nomorHalaman -= 1;
            if (nomorHalaman < 0)
            {
                nomorHalaman = 2;
            }
            prevClick = false;
        }
        if (nextClick == true)
        {
            objectHalaman[nomorHalaman].SetActive(false);
            nomorHalaman += 1;
            if (nomorHalaman >= 3)
            {
                nomorHalaman = 0;
            }
            nextClick = false;
        }
    }
    public void ButtonPrev()
    {
        prevClick = true;
    }
    public void ButtonNext()
    {
        nextClick = true;
    }
    public void ButtonKembali()
    {
        SceneManager.LoadScene("BelajarScene");
    }
}
