
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel()
    {
        
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene("scene1");
        }

        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}


