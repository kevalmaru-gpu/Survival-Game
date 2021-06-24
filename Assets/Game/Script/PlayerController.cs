using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    CharacterController characterController;

    [Range(0.1f,4f)]
    public float movementSpeed;

    private void Update() {
        // Move the player based upon user input
        Move(GetInput());
    }

    public Vector2 GetInput(){
        
        float x = Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime;

        return (new Vector2(x,y));
    }

    public void Move(Vector2 input){
        characterController.Move(transform.forward * input.y + transform.right * input.x);
    }
}
