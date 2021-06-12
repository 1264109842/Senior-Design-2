using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{   
    public Slider slider;
    public AudioMixer AudioMixer;

    public Dropdown resolutionDropdown;
    public Dropdown QualityDropdown;

    Resolution[] resolutions;

    void Start()
    {
        resolutions=Screen.resolutions;   

        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for (int i=0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " X " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
            resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

    }
    void Update()
    {   
        float volume;
        bool result = AudioMixer.GetFloat("Volume", out volume);
        if(result)
        {
            slider.value = volume;
        }

        int level = QualitySettings.GetQualityLevel();
        QualityDropdown.value = level;
        QualityDropdown.RefreshShownValue();
    }

    public void SetVolume (float volume)
    {   
        AudioMixer.SetFloat("Volume", volume);
    }

    public void SetQuality (int Level){
        QualitySettings.SetQualityLevel(Level);
    }

    public void SetFullScreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}