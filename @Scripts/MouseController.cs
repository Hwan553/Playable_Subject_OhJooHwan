using UnityEngine;

public class MouseController : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 offset;
    private Vector3 originalPosition;
    private Transform selectedObject;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // 1. ���콺 Ŭ������ ��
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                selectedObject = hit.transform;
                originalPosition = selectedObject.position;

                Vector3 worldPoint = mainCamera.ScreenToWorldPoint(new Vector3(
                    Input.mousePosition.x,
                    Input.mousePosition.y,
                    mainCamera.WorldToScreenPoint(selectedObject.position).z
                ));

                offset = selectedObject.position - worldPoint;
            }
        }

        // 2. �巡�� ��
        if (Input.GetMouseButton(0) && selectedObject != null)
        {
            Vector3 worldPoint = mainCamera.ScreenToWorldPoint(new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                mainCamera.WorldToScreenPoint(selectedObject.position).z
            ));

            selectedObject.position = worldPoint + offset;
        }

        // 3. ���콺 ���� �� - ����
        if (Input.GetMouseButtonUp(0) && selectedObject != null)
        {
            selectedObject.position = originalPosition;
            selectedObject = null;
        }
    }
}
