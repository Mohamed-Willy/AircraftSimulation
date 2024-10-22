using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class AircraftManger : MonoBehaviour
{
    [SerializeField] XRSlider sliderPE; // Controls the Pitch
    [SerializeField] XRSlider sliderKE; // Kinetic energy
    [SerializeField] XRKnob Wheel; // Controls the roll and yaw
    [SerializeField] float speed = 10;
    [SerializeField] float pitchSensitivity = 45;  
    [SerializeField] float rollSensitivity = 45;   
    [SerializeField] float yawSensitivity = 30;

    UIManger manger;
    Rigidbody rb;
    float PE, KE, roll;

    private void Awake()
    {
        PE = 0;
        KE = 0;
        manger = GetComponent<UIManger>();
        rb = GetComponent<Rigidbody>();  
        manger.SetForce(Energy.Weight, 0);
        manger.SetForce(Energy.Kinetic, 0);
        manger.SetForce(Energy.Potential, 0);
    }

    private void Update()
    {
        // Update Potential Energy (PE) for head angle control
        if (PE != sliderPE.value)
        {
            PE = sliderPE.value;
            manger.SetForce(Energy.Potential, (1-PE) * 100);
        }

        // Update Kinetic Energy (KE) for forward motion control
        if (KE != sliderKE.value)
        {
            KE = sliderKE.value;
            manger.SetForce(Energy.Kinetic, KE * 100);
        }

        // Update Wheel for roll and yaw control
        if (roll != Wheel.value)
        {
            roll = Wheel.value;
        }
    }

    private void FixedUpdate()
    {
        // Apply Kinetic Energy (KE) to move the plane forward
        Vector3 forwardMovement = speed * KE * transform.forward;  // Scale the KE for motion
        rb.AddForce(forwardMovement, ForceMode.Impulse);

        // Control pitch based on Potential Energy (PE)
        float pitchAngle = (PE * 2 - 1) * pitchSensitivity;  // Convert slider value from [0,1] to [-1,1]

        // Apply roll and yaw control based on the Wheel knob
        float rollAngle = (roll * 2 - 1) * rollSensitivity;  // Convert knob value from [0,1] to [-1,1] for roll
        float yawAngle = (roll * 2 - 1) * yawSensitivity;    // Same value used for yaw

        // Combine pitch, roll, and yaw for the final rotation
        Quaternion targetRotation = Quaternion.Euler(pitchAngle, yawAngle, -rollAngle);  // Negate roll for natural feel

        // Apply the calculated rotation to the Rigidbody
        rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, Time.fixedDeltaTime));
    }

    public void ChangeMass(int val)
    {
        rb.mass += val;
        manger.SetForce(Energy.Weight, (rb.mass - 100) / 100);
    }
}
