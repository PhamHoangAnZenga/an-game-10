using SS.UI;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    void Awake()
    {
        Core.Init();
        Core.Set(sceneLoadingName: "LoadingScreen");
    }
    public void NewGame()
    {
        Core.Load<GameController>(sceneName: "TutorialScene");
    }

    public void ChooseLevel()
    {

    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
