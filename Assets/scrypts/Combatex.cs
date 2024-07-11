using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Combate : MonoBehaviour
{
    public Personaje heroe;
    public Personaje enemigo;
    public UICombate uiCombate;
    [SerializeField] bool waitingAction;

    private void Start()
    {
        // Inicializa los ataques
        Ataque ataque1 = new Ataque("Ataque Rápido", 10);
        Ataque ataque2 = new Ataque("Golpe Fuerte", 15);
        // Ataque ataque3 = new Ataque("Agarre Firme", 35);

        // Inicializa los personajes con los ataques
        // heroe = new Personaje("Héroe", 100, new Ataque[] { ataque1, ataque2 });
        // enemigo = new Personaje("Enemigo", 80, new Ataque[] { ataque1, ataque2 });

        // Inicializa la UI
        uiCombate.ActualizarSalud(heroe, enemigo);

        // Iniciar combate
        // IniciarCombate();
        StartCoroutine(IniciarCombate());
    }


    public IEnumerator IniciarCombate()
    {
        int turno = 0;
        while (heroe.EstaVivo() && enemigo.EstaVivo())
        {
            turno++;
            string accion = "";
            waitingAction = false;
            if (turno % 2 != 0)
            {
                waitingAction = true;
                // Turno del héroe
                // Ataque ataque = heroe.ataques[UnityEngine.Random.Range(0, heroe.ataques.Length)];
                // int danio = heroe.Atacar(enemigo, ataque);
                // accion = $"{heroe.Nombre} usa {ataque.nombre} y causa {danio} de daño a {enemigo.Nombre}.";
                while(waitingAction == true) 
                { 
                    yield return 0;
                }
            }
            else
            {
                // Turno del enemigo
                Ataque ataque = enemigo.ataques[UnityEngine.Random.Range(0, enemigo.ataques.Length)];
                int danio = enemigo.Atacar(heroe, ataque);
                accion = $"{enemigo.nombre} usa {ataque.nombre} y causa {danio} de daño a {heroe.nombre}.";
            }

            Debug.Log(accion);
            uiCombate.MostrarAccion(accion);
            uiCombate.ActualizarSalud(heroe, enemigo);

            yield return new WaitForSeconds(1.1f);
        }

        if (heroe.EstaVivo())
        {
            uiCombate.MostrarAccion($"{heroe.Nombre} ha ganado el combate!");
        }
        else
        {
            uiCombate.MostrarAccion($"{enemigo.Nombre} ha ganado el combate!");
        }
    }

    public void PlayerAction()
    {
        waitingAction = false;
    }

    
}
