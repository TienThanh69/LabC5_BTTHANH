using UnityEngine;

public partial class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Lấy dữ liệu di chuyển từ phím mũi tên hoặc WASD
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * moveVertical + transform.right * moveHorizontal;

        // Sử dụng SimpleMove: Tự động xử lý trọng lực, đơn vị là m/s
        controller.SimpleMove(move * speed);
    }
}