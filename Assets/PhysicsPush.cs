using UnityEngine;

public class PhysicsPush : MonoBehaviour
{
    [Header("Cài đặt Vật lý")]
    public float forceAmount = 500f; // Độ lớn của lực đẩy

    private Rigidbody rb;

    void Start()
    {
        // Lấy thành phần Rigidbody được gắn trên đối tượng này
        rb = GetComponent<Rigidbody>();

        // Kiểm tra an toàn đề phòng bạn quên chưa gắn Rigidbody trong Inspector
        if (rb == null)
        {
            Debug.LogError("Lỗi: Đối tượng " + gameObject.name + " thiếu thành phần Rigidbody!");
        }
    }

    void Update()
    {
        // --- LAB 5: SỬ DỤNG ADDFORCE ---
        // Khi nhấn phím Space, đẩy vật thể về phía trước (Trục Z)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb != null)
            {
                rb.AddForce(Vector3.forward * forceAmount);
                Debug.Log("Đã tác động một lực: " + forceAmount);
            }
        }
    }

    // --- LAB 6: COLLISION (VA CHẠM VẬT LÝ) ---
    // Hàm này chạy khi hai vật thể có Collider đụng vào nhau và gây ra lực phản lại
    private void OnCollisionEnter(Collision collision)
    {
        // In ra tên vật thể vừa va chạm vào Console
        Debug.Log("COLLISION: Bạn vừa tông vào " + collision.gameObject.name);
    }

    // --- LAB 6: TRIGGER (VÙNG CẢM BIẾN) ---
    // Hàm này chạy khi bạn đi xuyên qua một vật thể có tích ô 'Is Trigger'
    private void OnTriggerEnter(Collider other)
    {
        // Kiểm tra nếu đi vào vùng đích (Goal_Zone)
        if (other.gameObject.name == "Goal_Zone")
        {
            Debug.Log("<color=green>TRIGGER: Tuyệt vời! Bạn đã chạm vạch đích!</color>");
        }
        else
        {
            Debug.Log("TRIGGER: Đã đi xuyên qua vùng: " + other.gameObject.name);
        }
    }
}