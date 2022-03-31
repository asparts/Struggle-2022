using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    [SerializeField] private Transform dailyRotation;
    [SerializeField] private float timeOfDay; //TODO: Ohjevideolla t‰‰ oli 0-1float rangella, eli pit‰‰ adjustaa 24h systeemi t‰h‰n niin ett jaa 24/1 tai tai.. onkohan yks unitti 0.24 nii saa prosentteina nuo koska 0.24*100 = 24

    [SerializeField] private Light sun;
    private float intensity;
    [SerializeField] private float sunBaseIntensity = 1f; //minimum intensity..
    [SerializeField] private float sunVariation = 1.5f; //changing brightness between noon, sunrise, sunset
    [SerializeField] Gradient sunColor;


    private void Awake()
    {
        UpdateTime(12f, 0f);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        AdjustSunRotation();
        SunIntensity();
        AdjustSunColor();
    }
    public void UpdateTime(float hours, float minutes)
    {
        float timeInMinutes = minutes + hours * 60;

        timeOfDay = timeInMinutes * 0.00069f; // Since 1/24 == 0.416666... and 24h = 1440 minutes ..
    }

    //rotates the sun daily

    private void AdjustSunRotation()
    {
        float sunAngle = timeOfDay * 360f;
        dailyRotation.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, sunAngle));
    }
    private void SunIntensity()
    {
        intensity = Vector3.Dot(sun.transform.forward, Vector3.down);
        intensity = Mathf.Clamp01(intensity);

        sun.intensity = intensity * sunVariation * sunBaseIntensity;
    }
    private void AdjustSunColor()
    {
        sun.color = sunColor.Evaluate(intensity);
    }
}
