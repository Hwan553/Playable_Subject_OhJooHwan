using UnityEngine;
using TMPro;
using DG.Tweening;

public class TextManager : MonoBehaviour
{
    public float moveAmount = 30f;   // 위아래 이동 거리
    public float duration = 0.5f;    // 한 번 움직이는 데 걸리는 시간

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.localPosition;

        // 아래로 갔다가 위로 오는 무한 반복 애니메이션
        transform.DOLocalMoveY(originalPosition.y - moveAmount, duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
