using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unitychan : MonoBehaviour {
    public float moveSpead = 5f;//歩くスピード
    public float rotationSpeed = 360f;//振り向くスピード
    CharacterController characterController;
    Animator animator;

    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update(){
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (direction.sqrMagnitude > 0.01f){
            Vector3 forward = Vector3.Slerp(
            transform.forward,
            direction,
            rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction)
            );
            transform.LookAt(transform.position + forward);
          }

        characterController.Move(direction * moveSpead * Time.deltaTime);
        animator.SetFloat("Speed", characterController.velocity.magnitude);
    }
}
