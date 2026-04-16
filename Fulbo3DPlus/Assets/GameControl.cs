using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public Rigidbody BalonRigidBody;
    public float Fuerza = 10f;
    public Transform BalonTransform;
    public Transform DestinoTransform;
    public Animator DireccionAnimator;
    public Animator ElevacionAnimator;

    private void Start()
    {
        DireccionAnimator.speed = 1;
        ElevacionAnimator.speed = 0;
    }

    public void PatearPelota()
    {
        Vector3 direccion = (DestinoTransform.position - BalonTransform.position).normalized;

        //print("Pelota pateada");
        BalonRigidBody.AddForce(direccion * Fuerza, ForceMode.Impulse);
    }

public void PosicionarBalon()
    {
        BalonRigidBody.velocity = Vector3.zero;
        BalonRigidBody.angularVelocity = Vector3.zero;
        BalonRigidBody.Sleep();
        BalonTransform.position = new Vector3(0f, 0.5f, 0f);
        BalonTransform.rotation = Quaternion.identity;
    }
}