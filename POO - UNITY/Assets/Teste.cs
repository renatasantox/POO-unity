using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();


    void Start()
    {
        fusca.setNome("Fusca de pai");
        fusca.setCor("Azul");
        fusca.setNumero_de_rodas(4);
        fusca.setPreco(2050.90f);
        Debug.Log("0" + fusca.getNome() + " é " + fusca.getCor() + "tem" + fusca.getNumero_de_rodas() + "e custa R$" +
                  fusca.getPreco());


        gol.setNome("Gol de Pópó");
        gol.setCor("Azul");
        gol.setNumero_de_rodas(4);
        gol.setPreco(2999.99f);
        Debug.Log("0" + gol.getNome());

        if (fusca.ComparePreco(gol))
        {
            Debug.Log("O carro" + fusca.getNome() + "é mais caro do que o carro" + gol.getNome());
        }
        else
        {
            Debug.Log("O carro" + fusca.getNome() + "é mais barato do que o carro" + gol.getNome());
        }
    }
}