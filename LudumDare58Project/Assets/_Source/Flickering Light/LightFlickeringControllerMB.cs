using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Light2D))]
public class LightFlickeringControllerMB : MonoBehaviour
{
    [SerializeField] private AnimationCurve intensityCurve;

    [Header("Spot and Freeform")]
    [SerializeField] private AnimationCurve falloffIntensityCurve;

    [Header("Spot")]
    [SerializeField] private AnimationCurve innerRadiusCurve;
    [SerializeField] private AnimationCurve outerRadiusCurve;
    [SerializeField] private AnimationCurve innerAngleCurve;
    [SerializeField] private AnimationCurve outerAngleCurve;

    private Light2D _light;

    private void Awake()
    {
        _light = GetComponent<Light2D>();
    }

    private void Update()
    {
        float time = Time.time;
        _light.intensity = intensityCurve.Evaluate(time);
        _light.falloffIntensity = falloffIntensityCurve.Evaluate(time);
        _light.pointLightInnerRadius = innerRadiusCurve.Evaluate(time);
        _light.pointLightOuterRadius = outerRadiusCurve.Evaluate(time);
        _light.pointLightInnerAngle = innerAngleCurve.Evaluate(time);
        _light.pointLightOuterAngle = outerAngleCurve.Evaluate(time);
    }
}
