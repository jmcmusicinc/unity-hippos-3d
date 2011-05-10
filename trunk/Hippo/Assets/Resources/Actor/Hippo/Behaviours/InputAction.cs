using UnityEngine;
using System.Collections;

public class InputAction : MonoBehaviour
{
    public float fireRate = 0.5F;
    public string buttonKeyBinding = "Hippo 1";
	private float _nextFire = 0.0F;
    private AnimationState _hippoAnimState;
    public AnimationClip munchAnimation;

    public void Start()
    {
        _hippoAnimState = animation[munchAnimation.name];
    }


    public void Update()
	{
        if (Input.GetButton(buttonKeyBinding) && _hippoAnimState.HasAnimationStopped())
        {
            this.animation.Play(munchAnimation.name, AnimationPlayMode.Stop);
            animation.Rewind(munchAnimation.name);
        }

        /*
        if (Input.GetButton(buttonKeyBinding) && Time.time > _nextFire)
		{
            _nextFire = Time.time + fireRate;
			Debug.Log("Fired");
            animation.Play("Default Take");
        }*/
    }
}
