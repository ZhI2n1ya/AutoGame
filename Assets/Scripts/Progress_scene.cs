using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress_scene : MonoBehaviour
{
    public GameObject PanelKat1;
    public GameObject PanelKat2;
    public GameObject PanelKat3;
    public void ClickKat1(){
        PanelKat1.SetActive(true);
        PanelKat2.SetActive(false);
        PanelKat3.SetActive(false);

    }

    public void ClickKat2(){
        PanelKat1.SetActive(false);
        PanelKat2.SetActive(true);
        PanelKat3.SetActive(false);

    }

    public void ClickKat3(){
        PanelKat1.SetActive(false);
        PanelKat2.SetActive(false);
        PanelKat3.SetActive(true);

    }
}
