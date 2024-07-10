using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfiguracionManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Toggle fullscreenToggle;
    // Añade referencias a otros controles según sea necesario

    void Start()
    {
        // Inicializa los controles con los valores actuales de la configuración
        volumeSlider.value = PlayerPrefs.GetFloat("volume", 1f);
        fullscreenToggle.isOn = Screen.fullScreen;
        // Añade más inicialización según sea necesario
    }

    public void ApplySettings()
    {
        // Guarda las configuraciones aplicadas
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        Screen.fullScreen = fullscreenToggle.isOn;
        // Añade más lógica de aplicación según sea necesario

        // Puedes aplicar cambios adicionales como ajustar la resolución
        // Resolution[] resolutions = Screen.resolutions;
        // Screen.SetResolution(resolutions[resolutionDropdown.value].width, resolutions[resolutionDropdown.value].height, Screen.fullScreen);
    }

    public void CancelSettings()
    {
        // Revertir los cambios si es necesario
        // O simplemente cierra la pantalla de configuración
    }
}

