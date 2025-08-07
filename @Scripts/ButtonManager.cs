using DG.Tweening;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public float scaleFactor = 0.9f; // 얼마나 작아질지
    public float duration = 0.3f;    // 한 사이클 시간

    void Start()
    {
        transform.DOScale(scaleFactor, duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
