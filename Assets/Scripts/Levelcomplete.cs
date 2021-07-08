using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelcomplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



    public void Quit()
    {
        Debug.Log("Game Has Ended");
        Application.Quit();
    }

}
