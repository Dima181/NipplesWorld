using UnityEngine;
using UnityEngine.Events;

public class CharacterInputController
{
    public UnityEvent fireEvent;

    public int InputButtonCheckGun()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            return 1;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            return 2;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            fireEvent?.Invoke();
            return 0;
        }
        else return 0;
    }

    public int InputButtonCheckMelee()
    {
        if(Input.GetMouseButtonDown(0))
            return 1;
        if (Input.GetMouseButtonDown(1))
            return 2; 
        else return 0;
    }
}
