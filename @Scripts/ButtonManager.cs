using DG.Tweening;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public float scaleFactor = 0.9f; // �󸶳� �۾�����
    public float duration = 0.3f;    // �� ����Ŭ �ð�

    void Start()
    {
        transform.DOScale(scaleFactor, duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
