using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler2D : MonoBehaviour
{
    public string targetTag = "Enemy";  // Etiqueta del objeto con el que queremos detectar colisión
    public string sceneToLoad = "ActionScene";  // Nombre de la escena a cargar

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Cambiar a la escena de acción
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}


