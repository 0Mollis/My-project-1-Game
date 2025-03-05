using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnClick : MonoBehaviour
{
    [SerializeField] private string sceneName = "Game";

    public void btnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
