using System.Data;
/*************************************************
  * 名稱：RotationSelf
  * 作者：RyanHsu
  * 功能說明：
  * ***********************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class RotationSelf : MonoBehaviour
{
    new Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }

    float getRandom { get => Random.Range(-2, 2); }

    void Update()
    {
        Vector3 torque = new Vector3(getRandom, getRandom, getRandom);

        rigidbody.AddTorque(torque);
    }

}
