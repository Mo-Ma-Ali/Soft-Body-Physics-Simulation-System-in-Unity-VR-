using UnityEngine;

[RequireComponent(typeof(Collider))]
public class DragAndDrop : MonoBehaviour
{
    private Camera cam;
    private bool isDragging = false;
    private Vector3 offset;
    private float zDepth;

    void Start()
    {
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        if (GetComponent<MeshObject1>().isSimulating) return;
        zDepth = cam.WorldToScreenPoint(transform.position).z;

        // موضع الجسم في العالم
        Vector3 worldPos = transform.position;
        // موضع الماوس في الشاشة
        Vector3 screenMouse = Input.mousePosition;
        screenMouse.z = zDepth;

        // تحويله إلى نقطة في العالم
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(screenMouse);
        offset = worldPos - mouseWorldPos;

        isDragging = true;
    }

    void OnMouseDrag()
    {
        if (!isDragging) return;

        Vector3 screenMouse = Input.mousePosition;
        screenMouse.z = zDepth;

        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(screenMouse);
        transform.position = mouseWorldPos + offset;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}

