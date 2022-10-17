using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void goMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void goCharacterSelection()
    {
        SceneManager.LoadScene(1);
    }

    public void goResult()
    {
        SceneManager.LoadScene(3);
    }

    public void startGame()
    {
        SceneManager.LoadScene(2);
    }


}
