using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public Rigidbody BalonRigidBody;
    public float Fuerza = 10f;
    public Transform BalonTransform;
    public Transform DestinoTransform;
    public Animator DireccionAnimator;
    public Animator ElevacionAnimator;
    public Animator IndicadorAnimator;
    public Transform TransformIndicador;
    public float NivelDeFuerza1;
    public float NivelDeFuerza2;

    private void Start()
    {
        DireccionAnimator.speed = 1;
        ElevacionAnimator.speed = 0;
    }

    public void PatearPelota()
    {
        Vector3 direccion = (DestinoTransform.position - BalonTransform.position).normalized;

        //print("Pelota pateada");
        BalonRigidBody.AddForce(direccion * NivelDeFuerza2, ForceMode.Impulse);
    }
    public void DetenerBarraFuerza()
    {
        IndicadorAnimator.speed = 0;
        IndicadorAnimator.Update(0);

        NivelDeFuerza1 = TransformIndicador.localPosition.y;
        NivelDeFuerza2 = Mathf.InverseLerp(0f, 35.76f, NivelDeFuerza1);
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