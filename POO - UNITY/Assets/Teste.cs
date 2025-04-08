using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();
    private Carro gol = new Carro();
    
    
    void Start()
    {
        fusca.setNome("Fusca de pai");
        fusca.setCor("Azul");

        Debug.Log("0" + fusca.getNome() + " é " + fusca.getCor());
    }
}
