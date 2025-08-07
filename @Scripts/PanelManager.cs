using System.Collections;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject targetPanel;   // 비활성화된 패널
    public float delay = 60f;        // 기다릴 시간 (초)

    void Start()
    {
        if (targetPanel != null)
        {
            targetPanel.SetActive(false); // 시작 시 확실히 꺼두기
            StartCoroutine(ActivateAfterDelay());
        }
    }

    IEnumerator ActivateAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        targetPanel.SetActive(true); // 1분 후 패널 켜기
    }
}
