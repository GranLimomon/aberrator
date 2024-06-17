using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Personaje : MonoBehaviour
{
    public Personaje objetivo;
    public Combate combate;
    internal readonly object Nombre;
    public string nombre;
    public int salud;
    public Ataque[] ataques;
    public Button[] atauqeUI;

    public void Start()
    {
        for (int i = 0; i < atauqeUI.Length; i++)
        {
            if(atauqeUI[i] != null)
            {
                if(ataques.Length > i)
                {
                    // Debug.Log(i + " "  + ataques.Length + " " +atauqeUI.Length);
                    atauqeUI[i].gameObject.SetActive(true);
                    atauqeUI[i].GetComponentInChildren<TextMeshProUGUI>().text = ataques[i].nombre;
                    Ataque atk = ataques[i];
                    atauqeUI[i].onClick.AddListener(() => { OnClickAtack(atk);});
                }
                else
                {
                    atauqeUI[i].gameObject.SetActive(false);
                }
            }
        }
    }

    public void OnClickAtack(Ataque atk)
    {
        Atacar(objetivo, atk);
        combate.PlayerAction();
    }

    public Personaje(string nombre, int salud, Ataque[] ataques)
    {
        this.nombre = nombre;
        this.salud = salud;
        this.ataques = ataques;
    }

    public int Atacar(Personaje objetivo, Ataque ataque)
    {
        objetivo.salud -= ataque.danio;
        return ataque.danio;
    }

    public bool EstaVivo()
    {
        if (salud < 0)
        { 
            salud = 0; 
        }

        return salud > 0;
    }
}
