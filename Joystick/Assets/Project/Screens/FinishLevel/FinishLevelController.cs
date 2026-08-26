using UnityEngine;
using SS.UI;
using TMPro;

public class FinishLevelController : MonoBehaviour, IKeyBack
{
    public const string NAME = "FinishLevel";

    [SerializeField] GameObject[] _stars;
    [SerializeField] TextMeshProUGUI _timeResutl;

    public void OnKeyBack()
    {
        Core.Close();
    }

    public void SetResult(int star, float time)
    {
        for (int i = 0; i < 3; ++i)
        {
            if (i < star) _stars[i].SetActive(true);
            else _stars[i].SetActive(false);
        }

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        _timeResutl.text = string.Format("Play time: {0:00}:{1:00}", minutes, seconds);
    }

    public void Restart()
    {
    }

    public void Menu()
    {
        Core.Load<MenuController>(sceneName: "HomeMenu");
    }

    public void NextLevel()
    {
    }
}