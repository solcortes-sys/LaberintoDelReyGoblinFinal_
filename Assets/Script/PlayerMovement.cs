using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    [SerializeField] private float speed = 3f;
    private Vector2 moveInput;
    private bool lookRight;
    // Variable para almacenar la �ltima direcci�n v�lida (LastX, LastY)
    public Vector2 lastDirection;
    private float moveX;
    private float moveY;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        playerRB = GetComponent<Rigidbody2D>();
        Debug.Log("sInicia el juego");

    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
       

        if (moveX != 0 || moveY != 0)
        {
            
            lastDirection = new Vector2(moveX, moveY).normalized;
            Debug.Log("Movex" + moveX);
            Debug.Log("MoveY" + moveY);
        }

        moveInput = new Vector2(moveX, moveY).normalized;

    }
    private void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + moveInput * speed * Time.fixedDeltaTime);

    }

    private void Spin() //Girar
    {
        lookRight = !lookRight; //MirarDerecha
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
    }
}
