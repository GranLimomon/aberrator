using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Ataque
{
    public string nombre;
    public int danio;

    public Ataque(string nombre, int danio)
    {
        this.nombre = nombre;
        this.danio = danio;
    }
}

