using UnityEngine.SceneManagement;
using UnityEngine;

public class ManagingScenes : MonoBehaviour
{
    public string sceneName;
    public bool active;

    private void Start()
    {
        active = MiniSingleton.msInst.active;

        sceneName = SceneManager.GetActiveScene().name;

        if (active)
            InvokeRepeating("ReloadCurrentScene", 1f, 3f);
    }

    void ReloadCurrentScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadPlayScene()
    {
        SceneManager.LoadScene("Play");
    }

    public void StopRepeiteing()
    {
        MiniSingleton.msInst.active = false;
    }

    public void SettRepeiteing()
    {
        MiniSingleton.msInst.active = true;
        ReloadCurrentScene();
    }

    public void ExitScene()
    {
        Application.Quit();
    }


}
