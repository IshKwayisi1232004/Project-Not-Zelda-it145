using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float initialSpeed = 10f;
    public float angle = 45f;
    private Rigidbody rb;
    private Vector3 initialVelocity;
    public GameObject projectileItem;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        CalculateInitialVelocity();
        LaunchProjectile();
    }

    void CalculateInitialVelocity()
    {
        float radianAngle = angle * Mathf.Deg2Rad;
        float xVelocity = initialSpeed * Mathf.Cos(radianAngle);
        float yVelocity = initialSpeed * Mathf.Sin(radianAngle);
        initialVelocity = new Vector3(xVelocity, yVelocity, 0f);
    }

    void LaunchProjectile()
    {
        rb.velocity = initialVelocity;
    }
}