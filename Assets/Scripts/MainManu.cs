using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Settings.fromSave = false;
        SceneManager.LoadScene("Loading");
    }
    public void LoadGame()
    {
        Settings.fromSave = true;
        SceneManager.LoadScene("Loading");
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}