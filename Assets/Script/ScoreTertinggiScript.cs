using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTertinggiScript : MonoBehaviour
{
    public Text quizScoreText, tebakGambarScoreText;
    public int quizScore, tebakGambarScore;
    public string namaQuizScore, namaTebakGambarScore;
    void Start()
    {
        //
        //PlayerPrefs.SetInt("QuizScorePrefs", 0);
        //PlayerPrefs.SetInt("TebakGambarScorePrefs", 0);
        //
        if (PlayerPrefs.GetInt("QuizScorePrefs") == 0)
        {
            namaQuizScore = "Empty";
        }
        else
        {
            namaQuizScore = PlayerPrefs.GetString("NamaQuizPrefs");
            quizScore = PlayerPrefs.GetInt("QuizScorePrefs");
        }
        if (PlayerPrefs.GetInt("TebakGambarScorePrefs") == 0)
        {
            namaTebakGambarScore = "Empty";
        }
        else
        {
            namaTebakGambarScore = PlayerPrefs.GetString("NamaTebakGambarPrefs");
            tebakGambarScore = PlayerPrefs.GetInt("TebakGambarScorePrefs");
        }
    }
    void Update()
    {
        //namaQuizScore = PlayerPrefs.GetString("NamaQuizPrefs");
        //namaTebakGambarScore = PlayerPrefs.GetString("NamaTebakGambarPrefs");

        //quizScore = PlayerPrefs.GetInt("QuizScorePrefs");
        //tebakGambarScore = PlayerPrefs.GetInt("TebakGambarScorePrefs");

        quizScoreText.text = "Quiz\n" + namaQuizScore + " " + quizScore.ToString() + "/100";
        tebakGambarScoreText.text = "Tebak Gambar\n" + namaTebakGambarScore + " " + tebakGambarScore.ToString() + "/100";
    }
}
