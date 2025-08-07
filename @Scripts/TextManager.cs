using UnityEngine;
using TMPro;
using DG.Tweening;

public class TextManager : MonoBehaviour
{
    public float moveAmount = 30f;   // ���Ʒ� �̵� �Ÿ�
    public float duration = 0.5f;    // �� �� �����̴� �� �ɸ��� �ð�

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.localPosition;

        // �Ʒ��� ���ٰ� ���� ���� ���� �ݺ� �ִϸ��̼�
        transform.DOLocalMoveY(originalPosition.y - moveAmount, duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
