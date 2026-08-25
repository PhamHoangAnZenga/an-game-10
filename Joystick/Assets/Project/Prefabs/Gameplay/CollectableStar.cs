using UnityEngine;
using UnityEngine.Events;

public class CollectableStar : MonoBehaviour
{
    [SerializeField] UnityEvent _onActive;

    void OnTriggerEnter(Collider other)
    {
        _onActive?.Invoke();        
        gameObject.SetActive(false);
    }
}
