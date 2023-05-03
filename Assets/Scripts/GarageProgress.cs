using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarageProgress : MonoBehaviour
{
    private Text textToEdit;
    private int totalClick;

    void Start()
    {
        //if (PlayerPrefs.HasKey("totalClick"))
        //    totalClick = PlayerPrefs.GetInt("totalClick");

        textToEdit = GetComponentInChildren<Text>();
    }

    public void ChangeText()
    {
        if (totalClick < 14)
        {
            totalClick += 1;
            textToEdit.text = totalClick.ToString();
        }
        //PlayerPrefs.SetInt("totalClick", totalClick);
        //PlayerPrefs.Save();
    }
}
