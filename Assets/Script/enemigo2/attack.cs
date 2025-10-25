using UnityEngine;

public class attack : MonoBehaviour
{
    private Rigidbody2D _rb; // referencia al componente Rigidbody2D de la flecha
    private float _speed = 20f; // velocidad de la flecha



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); // obtener el componente Rigidbody2D del objeto
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 2f); // destruir la flecha después de 2 segundos para evitar que permanezca en la escena
        _rb.position += Vector2.right * _speed * Time.deltaTime; // mover la flecha a una velocidad constante
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // si la flecha colisiona con un objeto que tiene la etiqueta "player"
        {
            Destroy(collision.gameObject); // destruir el objeto player que colisiona con el misil
        }
    }
}
