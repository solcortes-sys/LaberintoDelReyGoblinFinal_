using UnityEngine;

public class Player : MonoBehaviour
{
    // Jugafor Vida

    [SerializeField] private int maxHealth = 100;
    private int currentHealth;

    void Awake()
    {
        currentHealth = maxHealth;
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

        Debug.Log("Ingresa a Nuerte de player");
    }
}
