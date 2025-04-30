using UnityEngine;

public class IgaguriClickMover : MonoBehaviour
{
    public float forceAmount = 5f;
    Rigidbody rb;
    Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 左クリック
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 direction = (hit.point - transform.position).normalized;
                direction.y = 0.2f;
                rb.AddForce(direction * forceAmount, ForceMode.Impulse);
            }
        }
    }
}
