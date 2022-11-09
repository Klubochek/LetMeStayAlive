using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject menuBox;
    [SerializeField] AudioSource buttonClick;

    public void MenuBox()
    {
        ButtonClick();
        if (menuBox.activeInHierarchy == false)
            menuBox.SetActive(true);

        else menuBox.SetActive(false);
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ButtonClick()
    {
        buttonClick.Play();
    }

}
