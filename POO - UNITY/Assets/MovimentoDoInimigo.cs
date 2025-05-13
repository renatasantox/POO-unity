using UnityEngine;

public class Movimentodoinimigo : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidbody;
    private float velocidade;

    public float raioDeVisao = 3;
    private bool naVisão = false;

    private SphereCollider _sphereCollider;
    void Start()
    {
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _sphereCollider = gameObject.GetComponent<SphereCollider>();
        
        _player = GameObject.FindWithTag("Player");
    }
    
    void Update()
    {
        _sphereCollider.radius = raioDeVisao;

        if (naVisão == true)
        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position,
                _player.transform.position,
                velocidade * Time.deltaTime);
        }
    }

    void OnTriggerStay(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisão = true;
        }
    }

    private void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisão = false;
        }
    }
}
