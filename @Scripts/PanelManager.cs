using System.Collections;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject targetPanel;   // ��Ȱ��ȭ�� �г�
    public float delay = 60f;        // ��ٸ� �ð� (��)

    void Start()
    {
        if (targetPanel != null)
        {
            targetPanel.SetActive(false); // ���� �� Ȯ���� ���α�
            StartCoroutine(ActivateAfterDelay());
        }
    }

    IEnumerator ActivateAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        targetPanel.SetActive(true); // 1�� �� �г� �ѱ�
    }
}
