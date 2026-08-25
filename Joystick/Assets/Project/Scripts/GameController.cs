using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject[] _hint;

    int _hintID;

    void Start()
    {
        _hintID = 0;
        _hint[0].SetActive(true);
    }

    public void OpenHint()
    {
        _hintID += 1;

        if (_hintID >= _hint.Count()) return;
        _hint[_hintID-1].SetActive(false);
        _hint[_hintID].SetActive(true);
    }
}
