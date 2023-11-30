using UnityEngine;
using UnityEngine.UI;

public class MakeCharacterMove : MonoBehaviour
{
    int movementSpeed = Animator.StringToHash("Speed");
    public Slider slider;
    public Text sliderValue;

    Animator CharacterAnimator => GetComponent<Animator>();

    private void Update()
    {
        CharacterAnimator.Play(movementSpeed);

        sliderValue.text = $"{slider.value:00}m/s";
    }

    public void MoveSpeed(float speed)
    {
        CharacterAnimator.SetFloat(movementSpeed, speed);
    }


}
