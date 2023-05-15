using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTapScript : MonoBehaviour
{
    private float firstClickTime;
    public float timeBetweenClicks;
    private bool coroutineAllowed;
    private int clickCounter;
    public string namaHardware;
    public bool doubleTap;
    void OnEnable()
    {
        gameObject.GetComponent<Animator>().enabled = true;
    }
    void Start()
    {
        // Disable jika diperlukan!
        timeBetweenClicks = 0.2f;
        //
        firstClickTime = 0f;
        clickCounter = 0;
        coroutineAllowed = true;
        doubleTap = false;
        gameObject.GetComponent<Animator>().enabled = true;
    }
    void Update()
    {
        StartCoroutine(Waktu());
        IEnumerator Waktu()
        {
            yield return new WaitForSeconds(1);
            gameObject.GetComponent<Animator>().enabled = false;
        }
        if (Input.GetMouseButtonUp(0))
        {
            clickCounter += 1;
        }
        if (clickCounter == 1 && coroutineAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DoubleClickDetection());
        }
        if (doubleTap == true)
        {
            transform.rotation = Quaternion.identity;
            doubleTap = false;
        }
    }
    private IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;
        while (Time.time < firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {
                doubleTap = true;
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }
}
