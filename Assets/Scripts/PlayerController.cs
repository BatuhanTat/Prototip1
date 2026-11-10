using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public bool geriGitÇarpanıAktif = true;
    public Vector2 inputVektörü;

    public float speed = 10f;
    public float dönüşHızı;

    public InputAction MoveAction;

    int geriGitÇarpanı = 1;

    private void Start()
    {
        MoveAction.Enable();
    }

    void Update()
    {
        geriGitÇarpanı = 1;
        inputVektörü = MoveAction.ReadValue<Vector2>();

        if(inputVektörü.y < 0 && geriGitÇarpanıAktif)
        {
            geriGitÇarpanı = -1;
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime * inputVektörü.y);
        transform.Rotate(Vector3.up * dönüşHızı * Time.deltaTime * inputVektörü.x * geriGitÇarpanı);
    }
}
