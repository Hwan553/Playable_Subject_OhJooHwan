using System.Collections;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [Header("UI 요소")]
    public GameObject uiTextAndImage; // 숨기고 다시 보일 UI 오브젝트 (텍스트 + 이미지)
    public float showDelay = 5f;      // 다시 보이기까지의 지연 시간

    private bool isMousePressed = false;

    void Update()
    {
        // 마우스 클릭 시 UI 숨기기
        if (Input.GetMouseButtonDown(0))
        {
            isMousePressed = true;

            if (uiTextAndImage != null)
                uiTextAndImage.SetActive(false);
        }

        // 마우스 뗐을 때 몇 초 후 다시 보이기
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
