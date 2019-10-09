using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YouWinMenu : MonoBehaviour
{
    public static YouWinMenu Instance;
    public GameObject container;
    public Button nextlevelButton;
    public Button dismissButton;
    private void OnEnable()
    {
        nextlevelButton.onClick.AddListener(HandleNextLevelPressed);
        dismissButton.onClick.AddListener(Hide);
    }

    private void OnDisable()
    {
        nextlevelButton.onClick.RemoveListener(HandleNextLevelPressed);
    }

    private void HandleNextLevelPressed()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);

        if (Application.CanStreamedLevelBeLoaded(nextSceneIndex))
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        
        else
        {
            Debug.LogWarning("NO MORE LEVELS");
        }
    }
    private void Awake()
    {
        Instance = this;
    }

    public void Show()
    {
        container.SetActive(true);
    }

    public void Hide()
    {
        container.SetActive(false);
    }
}
