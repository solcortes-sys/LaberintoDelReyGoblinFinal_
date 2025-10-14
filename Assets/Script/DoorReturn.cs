using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorReturn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex);
        Debug.Log("entro para cargar la nueva escena");

        GameObject oEntrante = collision.gameObject;
        Debug.Log("Este es un mensaje de la colision en la misma Puerta ");
        Debug.Log(oEntrante.name);
    }
}
