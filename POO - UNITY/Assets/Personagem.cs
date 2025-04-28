using UnityEngine;

public class Personagem : MonoBehaviour
{
    [ SerializeField ]
    private string nome;
    [ SerializeField ]
    private int energia;
    [ SerializeField ]
    private int forca_ataque;
    [ SerializeField ]
    private float velocidasde;
    [ SerializeField ]
    private int mumero_de_pes;
    [ SerializeField ]
    private int numero_de_maos;
    
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }
    
    public string Nome()
    {
        return this.nome;
    }
    
    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }
    
    public int Energia()
    {
        return this.energia;
    }
    
    public void AtribuirForca_Ataque (int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }
    
    public int AtribuirForca_Ataque()
    {
        return this.forca_ataque;
    }
    
    public void AtribuirForca_Do_pulo(float pulo)
    {
        this.Forca_do_pulo = pulo;
    }

    public float NForca_Do_pulo()
    {
        return this.Forca_do_pulo;
    }

    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

    public void AtribuirNumero_de_pes(int numero_de_pes)
    {
        this.Numero_de_pes = numero_de_pes;
    }

    public int Numero_de_pes()
    {
        return this.Numero_de_pes;
    }

    public void AtribuitNumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }

    public int Numero_de_maos()
    {
        return this.numero_de_maos;
    }
}
