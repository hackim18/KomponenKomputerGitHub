using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizScript : MonoBehaviour
{
    public Text gambarKe, textBenar, textSalah, hasilScore;
    public InputField InputNama;
    public GameObject CanvasBermain, CanvasSelesai, CanvasHasilScore, ceklis, silang, Bintang1, Bintang2, Bintang3, txtBenar, txtSalah, BestScore, inputHolder;
    public GameObject[] ObjectSoal;
    public bool[] sudahTerjawab;
    public int soalNomor, benar, salah, soalRandom;
    public float jumlahScore, waktuDetik, waktuMenit;
    public bool onCek, canvasScore, looping, bestScore;
    public int a = 1;
    void Start()
    {
        onCek = false;
        canvasScore = false;
        soalRandom = Random.Range(1,26);
        ObjectSoal[soalRandom].SetActive(true);
        sudahTerjawab[soalRandom] = true;
        soalNomor = 1;
        bestScore = false;
        looping = true;
    }
    void Update()
    {
        //soalNomor = benar + salah + 1;
        gambarKe.text = "Soal no " + soalNomor.ToString() + " dari 25";
        textBenar.text = benar.ToString();
        textSalah.text = salah.ToString();
        if (onCek == true)
        {
            ObjectSoal[soalRandom].SetActive(false);
            soalRandom = Random.Range(1, 26);
            if (sudahTerjawab[soalRandom] == false)
            {
                ObjectSoal[soalRandom].SetActive(true);
                sudahTerjawab[soalRandom] = true;
                onCek = false;
            }
            else if (sudahTerjawab[soalRandom] == true)
            {
                onCek = true;
            }
        }
        if (soalNomor >= 26 && onCek == true)
        {
            CanvasBermain.SetActive(false);
            CanvasSelesai.SetActive(true);
        }
        waktuDetik += a * Time.deltaTime;
        if (waktuDetik >= 60)
        {
            waktuMenit += 1;
            waktuDetik = 0;
        }
        if (jumlahScore <= benar * 4 && canvasScore == true)
        {
            jumlahScore += 15 * Time.deltaTime;
            int detik = (int)waktuDetik;
            int scoreAkhir = (int)jumlahScore;
            hasilScore.text = "Nama : " + InputNama.text + "\n"
                 + "Mode : Quiz \n Hasil Score : " + scoreAkhir + " Dari 100" + "\n"
                 + "Waktu : " + waktuMenit.ToString() + " Menit " + detik.ToString() + " Detik";
        }

        else if (jumlahScore >= benar * 4 && canvasScore == true)
        {
            jumlahScore = (int)jumlahScore;
            if (jumlahScore <= PlayerPrefs.GetInt("QuizScorePrefs") && looping == true)
            {
                bestScore = false;
            }
            if (jumlahScore > PlayerPrefs.GetInt("QuizScorePrefs") && looping == true)
            {
                bestScore = true;
                PlayerPrefs.SetInt("QuizScorePrefs", (int)jumlahScore);
                PlayerPrefs.SetString("NamaQuizPrefs", InputNama.text);
                BestScore.gameObject.GetComponent<Animation>().Play("Best Score Animation");
            }
            looping = false;
        }

        if (jumlahScore >= 33 && jumlahScore <= 34)
        {
            Bintang1.gameObject.GetComponent<Animation>().Play("Bintang Animation");
        }
        if (jumlahScore >= 66 && jumlahScore < 67)
        {
            Bintang2.gameObject.GetComponent<Animation>().Play("Bintang Animation");
        }
        if (jumlahScore >= 99 && jumlahScore <= 100)
        {
            Bintang3.gameObject.GetComponent<Animation>().Play("Bintang Animation");
        }
    }
    public void ButtonClikBenar()
    {
        benar += 1;
        onCek = true;
        ceklis.GetComponent<Animation>().Play("Ceklis Animation");
        txtBenar.GetComponent<Animation>().Play("Benar Animation");
        soalNomor += 1;
    }
    public void ButtonClikSalah()
    {
        salah += 1;
        onCek = true;
        silang.GetComponent<Animation>().Play("Silang Animation");
        txtSalah.GetComponent<Animation>().Play("Benar Animation");
        soalNomor += 1;
    }
    public void ButtonLihatHasil()
    {
        a = 0;
        if (InputNama.text == "")
        {
            inputHolder.GetComponent<Animation>().Play("Input Name");
        }
        else
        {
            CanvasSelesai.SetActive(false);
            CanvasHasilScore.SetActive(true);
            canvasScore = true;
        }
        onCek = false;
    }
    public void ButtonUlangi()
    {
        SceneManager.LoadScene("QuizScene");
    }
    public void ButtonMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
