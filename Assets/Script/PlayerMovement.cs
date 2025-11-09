using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    [SerializeField] private float speed = 3f;
    private Vector2 moveInput;
    private bool lookRight;
    // Variable para almacenar la �ltima direcci�n v�lida (LastX, LastY)
    public Vector2 lastDirection;
    public Vector2 direction;
    private float moveX;
    private float moveY;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        animator = GetComponent<Animator>();
        playerRB = GetComponent<Rigidbody2D>();
        Debug.Log("sInicia el juego");

    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        
        animator.SetFloat("MoveX", moveX);
        animator.SetFloat("MoveY", moveY);
        moveInput = new Vector2(moveX, moveY).normalized;
        if (moveX != 0 || moveY != 0)
        {
            animator.SetFloat("LastX", moveX);
            animator.SetFloat("LastY", moveY);

           
            Debug.Log("MoveX" + moveX);
            Debug.Log("MoveY" + moveY);
        
        }
        lastDirection = new Vector2(moveX, moveY).normalized;

        
    }
    private void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + moveInput * speed * Time.fixedDeltaTime);

    }

}
