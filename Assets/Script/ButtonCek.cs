using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCek : MonoBehaviour
{
    public InputField inputText;
    public Text scoreBenar, scoreSalah, gambarKe;
    public GameObject silang, ceklis, textBenar, textSalah;
    public GameObject[] ObjectGambar;
    public bool[] sudahTerjawab;
    public string jawabanAnda;
    public int soalRandom, soalKejawab, benar, salah;
    public bool cek, jawabBenar, jawabSalah;
    void Start()
    {
        cek = false;
        soalKejawab = 1;
        soalRandom = Random.Range(1, 26);
        ObjectGambar[soalRandom].SetActive(true);
        sudahTerjawab[soalRandom] = true;
        jawabBenar = false;
        jawabSalah = false;
    }
    void Update()
    {
        gambarKe.text = "Gambar no " + soalKejawab.ToString() + " dari 25";
        scoreBenar.text = benar.ToString();
        scoreSalah.text = salah.ToString();
        if (cek == true)
        {
            ObjectGambar[soalRandom].SetActive(false);
            soalRandom = Random.Range(1, 26);
            if (sudahTerjawab[soalRandom] == false)
            {
                ObjectGambar[soalRandom].SetActive(true);
                sudahTerjawab[soalRandom] = true;
                cek = false;
            }
            else if (sudahTerjawab[soalRandom] == true)
            {
                cek = true;
            }
        }
        if (jawabBenar == true)
        {
            benar += 1;
            ceklis.GetComponent<Animation>().Play("Ceklis Animation");
            textBenar.GetComponent<Animation>().Play("Benar Animation");
            jawabBenar = false;
        }
        if (jawabSalah == true)
        {
            salah += 1;
            silang.GetComponent<Animation>().Play("Silang Animation");
            textSalah.GetComponent<Animation>().Play("Benar Animation");
            jawabSalah = false;
        }
    }
    public void buttonCek()
    {
        string text = inputText.text;
        if (text != inputText.text.ToUpper())
        {
            inputText.text = inputText.text.ToUpper();
        }
        jawabanAnda = inputText.text;
        GetComponent<Animation>().Play("Button Cek");
        soalKejawab += 1;
        cek = true;
        if (soalRandom == 1)
        {
            if (jawabanAnda == "MOUSE")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 2)
        {
            if (jawabanAnda == "KEYBOARD")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 3)
        {
            if (jawabanAnda == "FLASHDISK")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 4)
        {
            if (jawabanAnda == "MONITOR" || jawabanAnda == "MONITOR KOMPUTER")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 5)
        {
            if (jawabanAnda == "SPEAKER")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 6)
        {
            if (jawabanAnda == "HARDISK" || jawabanAnda == "HARDISK DRIVE" || jawabanAnda == "HDD")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 7)
        {
            if (jawabanAnda == "PROCESSOR" || jawabanAnda == "CPU" ||
                jawabanAnda == "CENTRAL PROCESSING UNIT")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 8)
        {
            if (jawabanAnda == "SHOCKET PROCESSOR")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 9)
        {
            if (jawabanAnda == "SSD" || jawabanAnda == "SOLID DISK DRIVE")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 10)
        {
            if (jawabanAnda == "VGA" || jawabanAnda == "GRAPHICS CARD" ||
                jawabanAnda == "GPU" || jawabanAnda == "KARTU GRAFIS" || 
                jawabanAnda == "DISPLAY CARD" || jawabanAnda == "VIDEO GRAPHIC ARRAY")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 11)
        {
            if (jawabanAnda == "MOTHERBOARD" || jawabanAnda == "MAINBOARD")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 12)
        {
            if (jawabanAnda == "FLOPPY DISK DRIVE" || jawabanAnda == "FLOPPY DISK" ||
                jawabanAnda == "FLOPPY DRIVE" || jawabanAnda == "DISKET" || jawabanAnda == "DISKETTE")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 13)
        {
            if (jawabanAnda == "PROJECTOR" || jawabanAnda == "PROYEKTOR")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 14)
        {
            if (jawabanAnda == "RAM" || jawabanAnda == "RANDOM ACCESS MEMORY")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 15)
        {
            if (jawabanAnda == "WIRELESS ADAPTER" || jawabanAnda == "WIRELESS CARD" || jawabanAnda == "WLAN CARD" || jawabanAnda == "Wireless LAN Card")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 16)
        {
            if (jawabanAnda == "OPTICAL DRIVE" || jawabanAnda == "OPTICAL DISK DRIVE" || jawabanAnda == "CD ROM" ||
                jawabanAnda == "CD-ROM")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 17)
        {
            if (jawabanAnda == "POWER SUPPLY" || jawabanAnda == "PSU")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 18)
        {
            if (jawabanAnda == "LAN CARD")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 19)
        {
            if (jawabanAnda == "JOYSTICK")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 20)
        {
            if (jawabanAnda == "SOUND CARD")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 21)
        {
            if (jawabanAnda == "SCANNER")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 22)
        {
            if (jawabanAnda == "KABEL LAN" || jawabanAnda == "LAN KABEL" ||
                jawabanAnda == "CABLE LAN" || jawabanAnda == "LAN CABLE")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 23)
        {
            if (jawabanAnda == "CMOS" || jawabanAnda == "BATERAI CMOS" ||
                jawabanAnda == "CMOS BATTERY" || jawabanAnda == "BATTERY CMOS")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 24)
        {
            if (jawabanAnda == "BILL GATES")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        else if (soalRandom == 25)
        {
            if (jawabanAnda == "CHARLES BABBAGE")
            {
                jawabBenar = true;
            }
            else
            {
                jawabSalah = true;
            }
        }
        inputText.text = "";
    }
}
