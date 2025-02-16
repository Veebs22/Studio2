using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();
        if (triggeredBody.CompareTag("Ball"))
        {
            float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;
            ballRigidBody.linearVelocity = Vector3.zero;
            ballRigidBody.AddForce(transform.up * velocityMagnitude, ForceMode.VelocityChange);

        }



    }


}
