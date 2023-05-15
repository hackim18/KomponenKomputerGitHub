using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hardware3dScript : MonoBehaviour
{
    public GameObject object3D;
    public Text nomorText, namaKomponen;
    public bool prevClick, nextClick;

    public GameObject[] komponenKomputer3D;
    public int nomor;
    public int nomorMax;
    public string namaHardware;
    void Start()
    {
        object3D.SetActive(false);
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(0.4f);
            object3D.SetActive(true);
        }

        nomor = 1;
        nextClick = false;
        prevClick = false;
        komponenKomputer3D[nomor].SetActive(true);
    }
    void Update()
    {
        nomorMax = komponenKomputer3D.Length;
        if (nextClick == true)
        {
            komponenKomputer3D[nomor].SetActive(false);
            nomor += 1;
            if (nomor >= nomorMax)
            {
                nomor = 1;
            }
            komponenKomputer3D[nomor].SetActive(true);
            nextClick = false;
        }
        if (prevClick == true)
        {
            komponenKomputer3D[nomor].SetActive(false);
            nomor -= 1;
            if (nomor <= 0)
            {
                nomor = nomorMax-1;
            }
            komponenKomputer3D[nomor].SetActive(true);
            prevClick = false;
        }
        int nomorMaxText = nomorMax - 1;
        nomorText.text = nomor.ToString() + "/" +nomorMaxText.ToString();
        namaKomponen.text = komponenKomputer3D[nomor].GetComponent<DoubleTapScript>().namaHardware;
        PlayerPrefs.SetInt("nomorPrefs", nomor);
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
