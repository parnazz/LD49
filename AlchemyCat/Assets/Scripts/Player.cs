using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private float _interactionRadius = 5f;

    private InputController _inputConatroller;

    // Start is called before the first frame update
    void Start()
    {
        _inputConatroller = new InputController();
        _inputConatroller.TryToInteract += Interact;
    }

    // Update is called once per frame
    void Update()
    {
        _inputConatroller.Update();

        Vector3 dir = new Vector3(_inputConatroller.Horizontal, _inputConatroller.Vertical, 0);
        dir = dir.normalized;
        transform.position += dir * _movementSpeed * Time.deltaTime;
    }

    private void Interact()
    {
        var colliders = Physics.OverlapSphere(transform.position, _interactionRadius);
        if (colliders.Length > 0)
            Debug.Log(colliders[0]?.name);
    }

    private void OnDisable()
    {
        _inputConatroller.TryToInteract -= Interact;
    }
}
