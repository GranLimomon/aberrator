
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UICombate : MonoBehaviour
{
    public TextMeshProUGUI textoSaludHeroe;
    public TextMeshProUGUI textoSaludEnemigo;
    public TextMeshProUGUI textoAccion;

    public void ActualizarSalud(Personaje heroe, Personaje enemigo)
    {
        textoSaludHeroe.text = $"Salud Héroe: {heroe.salud}";
        textoSaludEnemigo.text = $"Salud Enemigo: {enemigo.salud}";
    }

    public void MostrarAccion(string accion)
    {
        textoAccion.text = accion;
    }
}
