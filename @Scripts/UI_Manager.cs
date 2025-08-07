using System.Collections;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [Header("UI ���")]
    public GameObject uiTextAndImage; // ����� �ٽ� ���� UI ������Ʈ (�ؽ�Ʈ + �̹���)
    public float showDelay = 5f;      // �ٽ� ���̱������ ���� �ð�

    private bool isMousePressed = false;

    void Update()
    {
        // ���콺 Ŭ�� �� UI �����
        if (Input.GetMouseButtonDown(0))
        {
            isMousePressed = true;

            if (uiTextAndImage != null)
                uiTextAndImage.SetActive(false);
        }

        // ���콺 ���� �� �� �� �� �ٽ� ���̱�
        if (Input.GetMouseButtonUp(0) && isMousePressed)
        {
            isMousePressed = false;

            if (uiTextAndImage != null)
                StartCoroutine(ShowUIAfterDelay(showDelay));
        }
    }

    private IEnumerator ShowUIAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (uiTextAndImage != null)
            uiTextAndImage.SetActive(true);
    }
}
