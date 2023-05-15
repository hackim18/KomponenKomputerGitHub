using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KomponenKomputerScript : MonoBehaviour
{
    public GameObject listKomponenKomputer, halamanKomponenKomputer;
    public Animator animator;
    public GameObject[] objectHalaman;
    public Text textHalaman;
    public int nomorHalaman;
    public bool prevClick, nextClick;

    void Start()
    {
        nomorHalaman = 0;
        prevClick = false;
        nextClick = false;

        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(2f);
            animator.enabled = false;
        }
    }
    void Update()
    {
        int a = nomorHalaman;
        textHalaman.text = a.ToString() + "/20";
        objectHalaman[nomorHalaman].SetActive(true);

        if (PlayerPrefs.GetInt("nomorButton") == 0)
        {

        }
        else
        {
            objectHalaman[nomorHalaman].SetActive(false);
            nomorHalaman = PlayerPrefs.GetInt("nomorButton");
            PlayerPrefs.SetInt("nomorButton", 0);
            listKomponenKomputer.SetActive(false);
            halamanKomponenKomputer.SetActive(true);
        }
        if (prevClick == true)
        {
            objectHalaman[nomorHalaman].SetActive(false);
            nomorHalaman -= 1;
            if (nomorHalaman < 1)
            {
                nomorHalaman = 20;
            }
            prevClick = false;
        }
        if (nextClick == true)
        {
            objectHalaman[nomorHalaman].SetActive(false);
            nomorHalaman += 1;
            if (nomorHalaman > 20)
            {
                nomorHalaman = 1;
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
        if (listKomponenKomputer.active == true)
        {
            SceneManager.LoadScene("BelajarScene");
        }
        else
        {
            listKomponenKomputer.SetActive(true);
            halamanKomponenKomputer.SetActive(false);
        }
    }
}

