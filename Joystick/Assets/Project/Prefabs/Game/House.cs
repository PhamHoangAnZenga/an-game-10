using UnityEngine;
using UnityEngine.Events;

public class House : MonoBehaviour
{
    [SerializeField] UnityEvent _finishLevel;

    void OnTriggerEnter(Collider other)
    {
        _finishLevel?.Invoke();
    }
}
