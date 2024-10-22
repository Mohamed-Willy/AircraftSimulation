using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Serializable]
public enum Energy
{
    Potential,
    Kinetic,
    Weight
}

public class UIManger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textPE;
    [SerializeField] TextMeshProUGUI textKE;
    [SerializeField] TextMeshProUGUI textW;
    [SerializeField] Transform pointerPE;
    [SerializeField] Transform pointerKE;
    [SerializeField] Transform pointerW;


    public void SetForce(Energy energy, float value)
    {
        float angle = value * 115 / 100 - 25;

        if (energy == Energy.Potential)
        {
            textPE.text = value.ToString();
            pointerPE.localRotation = Quaternion.Euler(angle, 90, -90);
        }
        if (energy == Energy.Kinetic)
        {
            textKE.text = value.ToString();
            pointerKE.localRotation = Quaternion.Euler(angle, 90, -90);
        }
        if (energy == Energy.Weight)
        {
            textW.text = value.ToString();
            pointerW.localRotation = Quaternion.Euler(angle, 90, -90);
        }
    }
}
