using UnityEngine;

public class TutorialController : MonoBehaviour
{
    [SerializeField] GameObject _guide1;
    [SerializeField] GameObject _guide2;
    [SerializeField] GameObject _guide3;

    void Start()
    {
        OpenGuide1();
    }

    public void OpenGuide1()
    {
        _guide1.SetActive(true);
    }
    public void OpenGuide2()
    {
        _guide1.SetActive(false);
        _guide2.SetActive(true);
    }
    public void OpenGuide3()
    {
        _guide2.SetActive(false);
        _guide3.SetActive(true);
    }
}
