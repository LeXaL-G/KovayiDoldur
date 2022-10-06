using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenuManager : MonoBehaviour
{
    [Header("Ana Menu Panel Header")]
    public GameObject _MainMenuPanel;
    [Header("Market Panel Header")]
    public GameObject _ShopPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shopMenu()
    {
        _MainMenuPanel.SetActive(false);
        _ShopPanel.SetActive(true);
    }

    public void mainMenu()
    {
        _ShopPanel.SetActive(false);
        _MainMenuPanel.SetActive(true);
    }
    
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void quitGame()
    {
        Application.Quit();
    }


}
