using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float gravity = 9.8f;
    public float jumpForce;
    public float speed;
    public GameObject comp;
    public GameObject can;
    public Image load;
    public GameObject Trigger;

    private Vector3 _moveVector;
    private float _fallVelocity = 0;

    private CharacterController _characterController;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        load.fillAmount = 0;
    }

    void Update()
    {
        _moveVector = Vector3.zero;
        Uprav();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _characterController.Move(_moveVector * speed * Time.fixedDeltaTime);
        _fallVelocity += gravity * Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);
        if (_characterController.isGrounded)
        {
            _fallVelocity = 0;
        }
    }

    void Uprav()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
            _fallVelocity = -jumpForce;
        if (Input.GetKey(KeyCode.W))
            _moveVector += transform.forward;
        if (Input.GetKey(KeyCode.D))
            _moveVector += transform.right;
        if (Input.GetKey(KeyCode.S))
            _moveVector -= transform.forward;
        if (Input.GetKey(KeyCode.A))
            _moveVector -= transform.right;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Comp"))
        {
            can.active = false;
            comp.active = true;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }

    public void ButtonComp()
    {
        can.active = true;
        comp.active = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    public void ButtonLoad()
    {
        load.fillAmount = load.fillAmount + 0.1f;
        Destroy(Trigger);

    }

}
