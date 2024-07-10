using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfiguracionManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Toggle fullscreenToggle;
    // A�ade referencias a otros controles seg�n sea necesario

    void Start()
    {
        // Inicializa los controles con los valores actuales de la configuraci�n
        volumeSlider.value = PlayerPrefs.GetFloat("volume", 1f);
        fullscreenToggle.isOn = Screen.fullScreen;
        // A�ade m�s inicializaci�n seg�n sea necesario
    }

    public void ApplySettings()
    {
        // Guarda las configuraciones aplicadas
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        Screen.fullScreen = fullscreenToggle.isOn;
        // A�ade m�s l�gica de aplicaci�n seg�n sea necesario

        // Puedes aplicar cambios adicionales como ajustar la resoluci�n
        // Resolution[] resolutions = Screen.resolutions;
        // Screen.SetResolution(resolutions[resolutionDropdown.value].width, resolutions[resolutionDropdown.value].height, Screen.fullScreen);
    }

    public void CancelSettings()
    {
        // Revertir los cambios si es necesario
        // O simplemente cierra la pantalla de configuraci�n
    }
}

