using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BelajarScript : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }
    void Update()
    {
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(1.4f);
            anim.enabled = false;
        }
    }
    public void ButtonKembali()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void ButtonDefinisiKomputer()
    {
        SceneManager.LoadScene("DefinisiKomputerScene");
    }
    public void ButtonFungsiKomputer()
    {
        SceneManager.LoadScene("FungsiKomputerScene");
    }
    public void ButtonHardwareKomputer3D()
    {
        SceneManager.LoadScene("KomponenKomputer3DScene");
    }
    public void ButtonKomponenKomputer()
    {
        SceneManager.LoadScene("KomponenKomputerScene");
    }
    public void ButtonJenisKomputer()
    {
        SceneManager.LoadScene("JenisKomputerScene");
    }
}
