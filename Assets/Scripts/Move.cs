using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _acceleration;
    [SerializeField]
    private float _deceleration;

    private Rigidbody2D _myRigidBody;

    private void Awake()
    {
        _myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
