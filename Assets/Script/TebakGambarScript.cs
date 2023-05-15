using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TebakGambarScript : MonoBehaviour
{
    public GameObject CanvasTebakGambar, CanvasSelesai, CanvasHasilScore, inputHolder;
    public GameObject Bintang1, Bintang2, Bintang3, BestScore;
    public InputField InputNama;
    public Text hasilScore;
    public ButtonCek ButtonCekScript;
    public float waktuDetik, waktuMenit;
    public float jumlahScore;
    public bool buttonCek = false;
    public int a = 1;
    public bool test = false;
    public bool bestScore = false;
    public bool looping = true;

    void Start()
    {

    }
    void Update()
    {
        waktuDetik += a * Time.deltaTime;
        if (waktuDetik >= 60)
        {
            waktuMenit += 1;
            waktuDetik = 0;
        }
        if (ButtonCekScript.soalKejawab == 26)
        {
            a = 0;
            CanvasTebakGambar.SetActive(false);
            CanvasSelesai.SetActive(true);
        }

        if (jumlahScore <= ButtonCekScript.benar * 4 && buttonCek == true)
        {
            jumlahScore += 15 * Time.deltaTime;
            int detik = (int)waktuDetik;
            int scoreAkhir = (int)jumlahScore;
            hasilScore.text = "Nama : " + InputNama.text + "\n"
                 + "Mode : Tebak Gambar \n Hasil Score : " + scoreAkhir + " Dari 100" + "\n"
                 + "Waktu : " + waktuMenit.ToString() + " Menit " + detik.ToString() + " Detik";
        }
        else if(jumlahScore >= ButtonCekScript.benar * 4 && buttonCek == true)
        {

            jumlahScore = (int)jumlahScore;
            if (jumlahScore <= PlayerPrefs.GetInt("TebakGambarScorePrefs") && looping == true)
            {
                bestScore = false;
            }
            if (jumlahScore > PlayerPrefs.GetInt("TebakGambarScorePrefs") && looping == true)
            {
                bestScore = true;
                PlayerPrefs.SetInt("TebakGambarScorePrefs", (int)jumlahScore);
                PlayerPrefs.SetString("NamaTebakGambarPrefs", InputNama.text);
                BestScore.gameObject.GetComponent<Animation>().Play("Best Score Animation");
            }
            looping = false;

            test = true;
        }
        if (jumlahScore >= 33 && jumlahScore <= 34)
        {
            Bintang1.gameObject.GetComponent<Animation>().Play("Bintang Animation");
        }
        if (jumlahScore >= 66 && jumlahScore <67)
        {
            Bintang2.gameObject.GetComponent<Animation>().Play("Bintang Animation");
        }
        if (jumlahScore >= 99 && jumlahScore <=100)
        {
            Bintang3.gameObject.GetComponent<Animation>().Play("Bintang Animation");
        }
    }
    public void ButtonLihatHasil()
    {
        ButtonCekScript.soalKejawab = 0;
        if (InputNama.text == "")
        {
            inputHolder.GetComponent<Animation>().Play("Input Name");
        }
        else
        {
            CanvasSelesai.SetActive(false);
            CanvasHasilScore.SetActive(true);
            buttonCek = true;
        }
    }
    public void ButtonUlangi()
    {
        SceneManager.LoadScene("TebakGambarScene");
    }
    public void ButtonMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
