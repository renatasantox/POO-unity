using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();
    Caminhão caminhao = new Caminhão();
    Personagem joao = new Personagem();
    Inimigo ork = new Inimigo();
    
    //======================

    void Start()
    {
        fusca.setNome("Fusca de pai");
        fusca.setCor("Azul");
        fusca.setNumero_de_rodas(4);
        fusca.setPreco(2050.90f);
        Debug.Log(" 0 " + fusca.getNome() + " é " + fusca.getCor() + " tem " + fusca.getNumero_de_rodas() + " e custa R$ " + fusca.getPreco());


        gol.setNome("Gol de Pópó");
        gol.setCor("Azul");
        gol.setNumero_de_rodas(4);
        gol.setPreco(2999.99f);
        Debug.Log(" 0 " + gol.getNome());

        if (fusca.ComparePreco(gol))
        {
            Debug.Log(" O carro " + fusca.getNome() + " é mais caro do que o carro " + gol.getNome());
        }
        else
        {
            Debug.Log("O carro " + fusca.getNome() + " é mais barato do que o carro " + gol.getNome());
        }
        
        caminhao.AtribuirTipoDeCarroceria("Larga");
        caminhao.setNumero_de_rodas(8);
        caminhao.setPreco(8999.99f);
        caminhao.setCor("Preto");
        caminhao.setNome(" Caminhão de Roberto ");

        if (fusca.ComparePreco(caminhao))
        {
            Debug.Log(" O carro " + fusca.getNome() + " é mais barato do que o " + caminhao.getNome());
        }
        else
        {
            Debug.Log(" O Carro " + fusca.getNome() + " é mais barato do que o " + caminhao.getNome());
        }
        
        joao.AtribuirNome("João Roberto II");
        joao.AtribuirEnergia (10);
        joao.AtribuirForca_Ataque (12); 
        joao.AtribuirForca_Do_pulo (6);
        joao.AtribuirVelocidade(8);
        joao.AtribuirNumero_de_pes (2);
        joao.AtribuitNumero_de_maos (2);
        
        
        ork.AtribuirNome("Ork Gob");
        ork.AtribuirEnergia (23);
        ork.AtribuirForca_Ataque (15); 
        ork.AtribuirForca_Do_pulo(8);
        ork.AtribuirVelocidade(6);
        ork.AtribuirNumero_de_pes(2);
        ork.AtribuitNumero_de_maos (4);
        ork.AtribuirArma(Inimigo.ArmaDoInimigo.MACHADO);
        ork.AtribuirArmadura(Inimigo.ArmaduraDoInimigo.COURO);

        if (ork.DanoDoInimigo() >= joao.Energia())
        {
            Debug.Log("0" + joao.Nome() + " ficou sem energia");
        }
        else
        {
            Debug.Log("0" + joao.Nome() + " aonda tem " + joao.Energia() + " ficou sem energia");
        }
    }
}