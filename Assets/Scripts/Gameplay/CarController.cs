using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarController : MonoBehaviour
{
    [Header("Car Stats")]
    public float enginePower = 1800f;
    public float brakeForce = 2400f;
    public float steeringSensitivity = 1.25f;
    public float maxSpeed = 55f;
    public float nitroBoostPower = 14f;
    public float nitroMax = 100f;

    [Header("References")]
    public Rigidbody rb;

    private float throttle;
    private float steering;
    private bool isBraking;
    private float currentNitro;
    public bool IsRaceActive { get; private set; }

    private void Awake()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();

        currentNitro = nitroMax;
    }

    private void Update()
    {
        if (!IsRaceActive)
            return;

        ReadInput();
    }

    private void FixedUpdate()
    {
        if (!IsRaceActive)
            return;

        ApplyMovement();
    }

    public void SetRaceActive(bool active)
    {
        IsRaceActive = active;
    }

    private void ReadInput()
    {
        throttle = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
        isBraking = Input.GetKey(KeyCode.Space);

        if (Input.GetKeyDown(KeyCode.LeftShift) && currentNitro > 0f)
        {
            UseNitro();
        }
    }

    private void ApplyMovement()
    {
        float effectiveMaxSpeed = maxSpeed;

        if (Input.GetKey(KeyCode.LeftShift) && currentNitro > 0f)
        {
            effectiveMaxSpeed += nitroBoostPower;
        }

        Vector3 forward = transform.forward;
        float currentForwardSpeed = Vector3.Dot(rb.velocity, forward);

        if (currentForwardSpeed < effectiveMaxSpeed)
        {
            rb.AddForce(forward * enginePower * throttle, ForceMode.Acceleration);
        }

        if (isBraking)
        {
            rb.AddForce(-forward * brakeForce, ForceMode.Acceleration);
        }

        float steeringInput = steering * steeringSensitivity;
        Quaternion turnRotation = Quaternion.Euler(0f, steeringInput * 18f * Time.fixedDeltaTime * 60f, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);

        Vector3 lateral = transform.right * Vector3.Dot(rb.velocity, transform.right);
        rb.velocity = Vector3.Lerp(rb.velocity, forward * rb.velocity.magnitude + lateral * 0.2f, 0.05f);
    }

    private void UseNitro()
    {
        if (currentNitro <= 0f)
            return;

        currentNitro -= 20f;
        rb.AddForce(transform.forward * 1200f, ForceMode.Acceleration);
    }

    public void RechargeNitro(float amount)
    {
        currentNitro = Mathf.Clamp(currentNitro + amount, 0f, nitroMax);
    }

    public float GetNitroPercent()
    {
        return currentNitro / nitroMax;
    }
}
