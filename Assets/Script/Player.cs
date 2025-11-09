using UnityEngine;

public class Player : MonoBehaviour
{
    // Jugafor Vida

    [SerializeField] private int maxHealth = 100;
    private int currentHealth;
    public bool key;

    void Awake()
    {
        currentHealth = maxHealth;
        key = false;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Jugador recibió " + amount + " daño. Salud: " + currentHealth);

        if (currentHealth <= 0)
        {
            Death();
        }
        maxHealth= currentHealth;
    }

    public void Death()
    {
        // Instantiate(deathEffect, transform.position, Quaternion.identity); //Agregar la animacion cuando este creada
        Destroy(gameObject);

        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex);

        Debug.Log("Ingresa a Nuerte de player");
    }
    public void ObtainKey()
    {
        key = true;
        Debug.Log("Llave obtenida");
    }
}
