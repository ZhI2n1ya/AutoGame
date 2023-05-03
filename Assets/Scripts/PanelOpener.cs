using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelOpener : MonoBehaviour
{
    public GameObject PanelOne;
    public GameObject PanelTwo;
    public GameObject PanelThee;

    public void OpenPanel()
    {
        if (PanelOne != null)
        {
            bool isActive = PanelOne.activeSelf;
            PanelOne.SetActive(!isActive);
        }

        if (PanelTwo != null)
        {
            bool isActive = PanelTwo.activeSelf;
            PanelTwo.SetActive(!isActive);
        }

        if (PanelThee != null)
        {
            bool isActive = PanelThee.activeSelf;
            PanelThee.SetActive(!isActive);
        }
    }
}
