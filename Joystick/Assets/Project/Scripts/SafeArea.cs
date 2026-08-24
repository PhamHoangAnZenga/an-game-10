using UnityEngine;

public class SafeArea : MonoBehaviour
{
    [SerializeField] RectTransform _rectTransform;

    void Start()
    {
        FixSafeArea();
    }

    void FixSafeArea()
    {
        float width = Screen.width;
        float height = Screen.height;

        float safeLeft = Screen.safeArea.x;
        float safeBottom = Screen.safeArea.y;
        float safeRight = safeLeft + Screen.safeArea.width;
        float safeTop = safeBottom + Screen.safeArea.height;

        float leftRatio = safeLeft / width;
        float bottomRatio = safeBottom / height;
        float rightRatio = (width - safeRight) / width;
        float topRatio = (height - safeTop) / height;

        _rectTransform.anchorMin = new Vector2(leftRatio, bottomRatio);
        _rectTransform.anchorMax = new Vector2(1 - rightRatio, 1 - topRatio);

    }
}
