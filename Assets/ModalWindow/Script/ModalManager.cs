using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModalManager : MonoBehaviour
{
    public GameObject modalWindow;
    public TextMeshProUGUI Header;
    public TextMeshProUGUI Body;
    public Image display;

//Making the Modal Window a Singleton

    public static ModalManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ShowModal(string Header, string Body, Sprite displayImage = null)
    {
        this.Header.text = Header;
        this.Body.text = Body;
        

        if (displayImage != null)
        {
            display.sprite = displayImage;
        }
        else
        {
            // Set a default image or clear the existing image
            display.sprite = null;
        }

        modalWindow.SetActive(true);
    }


    public void HideModal()
    {
        modalWindow.SetActive(false);
    }
}
