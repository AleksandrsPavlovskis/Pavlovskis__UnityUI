using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame() => SceneManager.LoadScene("CharacterDress");

    public void BackToMenu() => SceneManager.LoadScene("MainMenu");

    public void QuitGame()
    {
#if UNITY_EDITOR
        Debug.Log("Quit pressed (works in Build, not in Editor).");
#else
        Application.Quit();
#endif
    }
}