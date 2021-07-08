using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public Transform playerbody;
    public Transform Target;

    public void Resetlevel()
    {
        playerbody.position = Target.position;
        playerbody.eulerAngles = new Vector3 (0,180,0);
        
        
    }

}
