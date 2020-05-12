using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[RequireComponent(typeof(PostProcessVolume))]
public class PostProcessingChange : MonoBehaviour
{
    private PostProcessVolume _volume;
    
    private void Awake()
    {
        _volume = GetComponent<PostProcessVolume>();
    }

    public void ChangeVignetteIntensity(float changeBy)
    {
        _volume.profile.GetSetting<Vignette>().intensity.value += changeBy;
    }
}

