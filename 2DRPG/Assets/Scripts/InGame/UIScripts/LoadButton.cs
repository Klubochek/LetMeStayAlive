using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadButton : MonoBehaviour
{
    public void LoadButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
