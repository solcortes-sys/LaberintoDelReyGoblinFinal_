using UnityEngine;

public class ataqueConFlecha : MonoBehaviour
{
    private Rigidbody2D _rb;
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
            _random = Random.Range(2, 5);
            if (_asoma == false)
            {
                _rb.MovePosition(new Vector3(transform.position.x, transform.position.y + 80 * Time.fixedDeltaTime, transform.position.z));
                _asoma = true;
            }
            else if (_asoma == true)
            {
                _rb.MovePosition(new Vector3(transform.position.x, transform.position.y - 80 * Time.fixedDeltaTime, transform.position.z));
                _asoma = false;
            }
        }

    }
}
