using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject CanvasMainMenu, CanvasBermain, CanvasPilihBelajar, CanvasSkor, CanvasInfo, CanvasKeluar;
    public GameObject buttonBelajar, buttonBermain, buttonScore, buttonInfo, buttonKeluar, 
        
        buttonKembali, 
        buttonQuiz, buttonTebakGambar,
        buttonYa, buttonTidak;
    public GameObject GridBackground;
    void Start()
    {

    }
    
    void Update()
    {
        
    }

    public void ButtonBelajar()
    {
        buttonBelajar.GetComponent<Animation>().Play("Button Animation");
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(0.5f);
            //CanvasMainMenu.SetActive(false);
            //CanvasPilihBelajar.SetActive(true);
            SceneManager.LoadScene("BelajarScene");
        }
    }
    public void ButtonBermain()
    {
        buttonBermain.GetComponent<Animation>().Play("Button Animation");
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(0.5f);
            CanvasMainMenu.SetActive(false);
            CanvasBermain.SetActive(true);
        }
        
    }
    public void ButtonSkorTertinggi()
    {
        buttonScore.GetComponent<Animation>().Play("Button Animation");
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(0.5f);
            CanvasMainMenu.SetActive(false);
            CanvasSkor.SetActive(true);
        }
    }
    public void ButtonInfo()
    {
        buttonInfo.GetComponent<Animation>().Play("Button Animation");
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(0.5f);
            CanvasMainMenu.SetActive(false);
            CanvasInfo.SetActive(true);
            StartCoroutine(Waktu2());
            IEnumerator Waktu2()
            {
                yield return new WaitForSeconds(19f);
                SceneManager.LoadScene("MenuScene");
            }
        }
    }

    public void ButtonKeluar()
    {
        buttonKeluar.GetComponent<Animation>().Play("Button Animation");
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(0.5f);
            CanvasMainMenu.SetActive(false);
            CanvasKeluar.SetActive(true);
        }
    }

    public void ButtonTidak()
    {
        CanvasKeluar.SetActive(false);
        CanvasMainMenu.SetActive(true);
    }
    public void ButtonYa()
    {
        Application.Quit();
    }

    public void ButtonKembali()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void ButtonQuiz()
    {
        buttonQuiz.GetComponent<Animation>().Play("Button Animation2");
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("QuizScene");
        }
    }
    public void ButtonTebakGambar()
    {
        buttonTebakGambar.GetComponent<Animation>().Play("Button Animation2");
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(0.3f);
            SceneManager.LoadScene("TebakGambarScene");
        }
    }
    public void ButtonDefinisiKomputer()
    {
        SceneManager.LoadScene("DefinisiKomputerScene");
    }
}
