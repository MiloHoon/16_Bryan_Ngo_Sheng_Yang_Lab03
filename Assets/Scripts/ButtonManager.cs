using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("GamePlay_Level 1");
    }
}