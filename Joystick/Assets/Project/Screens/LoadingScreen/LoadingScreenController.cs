using UnityEngine;
using SS.UI;

public class LoadingScreenController : MonoBehaviour, IKeyBack
{
    public const string NAME = "LoadingScreen";

    [SerializeField] RectTransform _progress;

    public void OnKeyBack()
    {
        Core.Close();
    }

    void Update()
    {
        Debug.Log($"Loading {Core.asyncOperationProgress + 0.1f}");
        _progress.anchorMax = new Vector2(Mathf.Clamp(Core.asyncOperationProgress + 0.1f, 0 ,1), 1);
    }
}