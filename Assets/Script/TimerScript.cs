using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public GameObject CanvasTebakGambar, CanvasSelesai;
    public TebakGambarScript TebakGambarScript;
    public Text textWaktu;
    public float sisaWaktu, detik;
    void Start()
    {
        detik = 61;
    }

    void Update()
    {
        detik -= 1 * Time.deltaTime;
        if (detik <= 0)
        {
            sisaWaktu -= 1;
            detik = 60;
        }
        int detikInt = (int)detik;
        textWaktu.text = sisaWaktu.ToString() + ":" + detikInt.ToString();

        if (sisaWaktu == 0 && detikInt <= 1)
        {
            TebakGambarScript.a = 0;
            CanvasTebakGambar.SetActive(false);
            CanvasSelesai.SetActive(true);
        }
    }
}
