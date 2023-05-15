using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITransitionManager : MonoBehaviour
{
    
    [Tooltip("Keep this in order: 0 - NewGameCamera; 1 - Options; 2 - Quit")]
    [SerializeField] private GameObject[] cinemachineCameras;
   
    [SerializeField] private Button newGameButton, optionsButton, quitButton;

    private int cameraCount;
    // Start is called before the first frame update
    void Start()
    {
        setCamera(3);
        Debug.Log("Menu Started");
        newGameButton.onClick.AddListener(OnClickNewGame);
        optionsButton.onClick.AddListener(OnClickOptions);
        quitButton.onClick.AddListener(OnClickQuit);
    }



    private void setCamera(int cameraIndex)
    {
        for(int i = 0; i <= cinemachineCameras.Length - 1; i++)
        {
            cinemachineCameras[i].SetActive(i == cameraIndex);
        }
    }

    public void OnClickNewGame()
    {
        setCamera(0);
        Debug.Log("New Game Button Clicked");
    }

    public void OnClickOptions()
    {
        setCamera(1);
        Debug.Log("Options Button Clicked");
    }

    public void OnClickQuit()
    {
        setCamera(2);
        Debug.Log("Quit Button Clicked");
    }

      public void OnClickMain()
    {
        setCamera(3);
        Debug.Log("Main Menu Button Clicked");
    }

    public void OnClickConfirmQuit()
    {
        Application.Quit();
        Debug.Log("You quit the game!");
    }

}