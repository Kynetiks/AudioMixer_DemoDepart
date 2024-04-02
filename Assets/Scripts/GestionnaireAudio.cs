using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GestionnaireAudio : MonoBehaviour
{

    [SerializeField] private AudioMixer am;
    [SerializeField] private Slider sliderVolumeMusique;
    [SerializeField] private Slider sliderVolumeFX;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // am.GetFloat("MyExposedParam", );
        // am.SetFloat("VolumeMusique", -20F);
    }

    public void AjusteVolumeMusique(float volume){
    
        am.SetFloat("VolumeMusique", ConvertToLog(volume));

    }

     public void AjusteVolumeFX(float volume){
    
        am.SetFloat("VolumeFX", ConvertToLog(volume));
        audioSource.Play();

    }

    private float ConvertToLog(float volume){
        return Mathf.Log10(volume)*20;

    }

    
}
