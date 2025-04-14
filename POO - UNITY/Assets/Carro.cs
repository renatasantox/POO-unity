using UnityEngine;

public class Carro
{
    private string nome;
    private int numero_de_rodas;
    private string cor;
    private float preco;

    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getCor()
    {
        return this.cor;
    }

    public void setCor(string cor)
    {
        this.cor = cor;
    }

    public int getNumero_de_rodas()
    {
        return this.numero_de_rodas;
    }

    public void setNumero_de_rodas(int numero_de_rodas)
    {
        this.numero_de_rodas = numero_de_rodas;
    }

    public float getPreco()
    {
        return this.preco;
    }

    public void setPreco(float preco)
    {
        this.preco = preco;
    }

    public bool ComparePreco(Carro Carro)
    {
        if (this.preco > Carro.getPreco())
        {
            return true;
        }
        return false;
    }
}