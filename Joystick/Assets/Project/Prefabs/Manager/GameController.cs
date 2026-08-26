using System.Linq;
using SS.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject[] _hint;

    int _hintID;

    int _starCollect;

    void Start()
    {
        Core.Init();

        _hintID = 0;
        _hint[0].SetActive(true);

        _starCollect = 0;
    }

    public void OpenHint()
    {
        _hintID += 1;
        
        _starCollect += 1;

        if (_hintID >= _hint.Count()) return;
        _hint[_hintID - 1].SetActive(false);
        _hint[_hintID].SetActive(true);
    }
    
    public void FinishLevel()
    {
        Debug.Log("hello");
        Core.Add<FinishLevelController>(
            screenName: "FinishLevel",
            onScreenLoad: (screen) => screen.SetResult(_starCollect, Time.time)
        );
        Time.timeScale = 0f;
    }
}
