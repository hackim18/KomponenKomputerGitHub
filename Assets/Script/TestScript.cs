using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScript : MonoBehaviour
{
    public GameObject listKomponenKomputer, halamanKomponenKomputer;
    public int listNomor;
    public bool a;
    void Awake()
    {


    }
    void Start()
    {
        a = false;
    }
    void Update()
    {
        if (a == true)
        {
            print(listNomor);
            a = false;
            listKomponenKomputer.SetActive(false);
            halamanKomponenKomputer.SetActive(true);
        }
    }
    public void testClik()
    {
        a = true;
    }
}
