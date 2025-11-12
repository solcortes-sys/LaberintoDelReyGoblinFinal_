using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorReturn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            if (collision.gameObject.GetComponent<Player>().key == false)
            {
                Debug.Log("No tienes la llave para abrir la puerta");
                return;
            }
            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentIndex);
            Debug.Log("entro para cargar la nueva escena");

            GameObject oEntrante = collision.gameObject;
            Debug.Log("Este es un mensaje de la colision en la misma Puerta ");
            Debug.Log(oEntrante.name);
        }
    }
}
