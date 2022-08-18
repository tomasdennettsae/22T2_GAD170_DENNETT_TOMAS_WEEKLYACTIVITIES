using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject creditsPanel;

    private void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
    }
    private void HideMainMenu()
    {
        mainMenuPanel.SetActive(false);
    }
    public void LoadScene(int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }

}
