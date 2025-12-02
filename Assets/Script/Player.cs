using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public bool IsInvuInerable = false;
    private float jumpForce = 10f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetMoveSpeed(float speed)
    {
        speed = Mathf.Clamp01(speed);
    }

    public void SetInvulnerabillity(bool isEnabled)
    {
        Debug.Log("isEnabled Check"); //ค่าเปลี่ยน
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        rb = collision.GetComponent<Rigidbody>();
    }

    public void Move()
    {
        Mathf.Clamp01(moveSpeed);
    }

    public void Jump()
    {
        jumpForce = Mathf.Clamp01(jumpForce);
    }



    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2 (moveInput * moveSpeed, rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}
