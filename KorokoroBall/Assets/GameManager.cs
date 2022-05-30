using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int coinCount;

    public Text textComponent;

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }

    public void AddCoinCount()
    {
        coinCount = coinCount + 1;
        Debug.Log("CoinCount:" + coinCount);
        textComponent.text = "CoinCount : " + coinCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
