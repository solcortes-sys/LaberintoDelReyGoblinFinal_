using UnityEngine;

public class SkeletorController : MonoBehaviour

{

    public Transform player;
    public float speed = 2.0f;
    public float detectionRadius= 5.0f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float moveX;
    private float moveY;
    private bool isMoveing = false; 
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer <= detectionRadius)
        {
            isMoveing = true;
            Vector2 direction = (player.position - transform.position).normalized;
            moveX = direction.x;
            moveY = direction.y;
            animator.SetFloat("MoveX", moveX);
            animator.SetFloat("MoveY", moveY);

            //movement = new Vector2( direction.x,direction.y);
            if (moveX != 0 || moveY != 0)
            {
                animator.SetFloat("LastX", moveX);
                animator.SetFloat("LastY", moveY);
                // lastDirection = new Vector2(moveX, moveY).normalized;
                Debug.Log("Movex" + moveX);
                Debug.Log("MoveY" + moveY);
            }
            else
            {
                animator.SetFloat("LastX", 0);
                animator.SetFloat("LastY", -1);
                Debug.Log("Se queda quieto");
            }
            movement = new Vector2(direction.x, direction.y);
            Debug.Log("Direccion X " + direction.x);
            Debug.Log("Direccion y " + direction.y);
        }
        else
        {
            movement = Vector2.zero;
            isMoveing = false;
            animator.SetFloat("MoveX", 0);
            animator.SetFloat("MoveY", 0);
            Debug.Log("Se para el Personake");
            Debug.Log("Direccion X " + moveX);
        }
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
       // animator.SetBool("InMove", isMoveing);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }

}

