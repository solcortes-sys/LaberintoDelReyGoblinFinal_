using UnityEngine;

public class ataqueConFlecha : MonoBehaviour
{
    private Rigidbody2D _rb;
    public GameObject flechaEnemiga; // prefab de la flecha 
    private float _tiempo;//variable para medir el tiempo
    private float _random;//variable para el numero aleatoreo
    private bool _asoma=false;//se fija si se asoma el arquero




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _rb=GetComponent<Rigidbody2D>();//obtiene el componente RB
        _random = Random.Range(5, 10);     
        
    }

    // Update is called once per frame
    void Update()
    {
        _tiempo = _tiempo + Time.deltaTime;
        if (_tiempo > _random)
        {
            Debug.Log(_tiempo);
            _tiempo=0;//empieza desde cero
            _random = Random.Range(6, 10);
            if (_asoma == false)
            {
                _rb.MovePosition(new Vector3(transform.position.x, transform.position.y + 50 * Time.fixedDeltaTime, transform.position.z));
                _asoma = true;
                _tiempo = _tiempo + 5f;

            }
            else if (_asoma == true)
            {
                _rb.MovePosition(new Vector3(transform.position.x, transform.position.y - 50 * Time.fixedDeltaTime, transform.position.z));
                Instantiate(flechaEnemiga, new Vector3(_rb.position.x, _rb.position.y - 1, 0), Quaternion.identity);

                _asoma = false;
            }
        }

    }
}
