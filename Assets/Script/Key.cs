using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject doorFalse;
    [SerializeField] GameObject doorTrue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Aquí puedes agregar la lógica para recoger la llave
            Debug.Log("Llave recogida");
            Destroy(gameObject); // Destruye la llave al recogerla
            collision.GetComponent<Player>().ObtainKey(); // Llama al método ObtainKey en vez de asi1
                                                          // gnar

        }
    }
}
