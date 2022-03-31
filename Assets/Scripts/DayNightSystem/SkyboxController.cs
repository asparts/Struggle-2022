using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{


    [SerializeField] private Gradient skyColor;
    [SerializeField] private Gradient horizonColor;

    private void UpdateSkybox(float intensity)
    {
        RenderSettings.skybox.SetColor("_Skyint", skyColor.Evaluate(intensity));
        RenderSettings.skybox.SetColor("_GroundColor", horizonColor.Evaluate(intensity));
    }

    public void SetSkyboxMorning()
    {

    }
    public void SetSkyboxDay()
    {

    }
    public void SetSkyboxEvening()
    {

    }
    public void SetSkyboxNight()
    {

    }

}
