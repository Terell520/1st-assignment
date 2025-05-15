using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private float moveSpeed = 7f;
    private float speedX, speedY;
    public InputAction PlayControls;

    Vector2 moveDirection = Vector2.zero;

    private void OnEnable()
    {
        PlayControls.Enable();
    }

    private void OnDisable()
    {
        PlayControls.Disable();
    }

    [SerializeField] Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   void Update()
    {
        //speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        //speedY = Input.GetAxisRaw("veritical") * moveSpeed;
        //rb.linearVelocity = new Vector2(speedX, speedY);
        moveDirection = PlayControls.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
