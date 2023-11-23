using UnityEngine;

public class CharacterEnterController : MonoBehaviour
{
    [SerializeField] private int audioCountPlay = 0;
    [SerializeField] private CharacterAudioController characterAudioController;

    private void Start()
    {
        characterAudioController.SpawnAudioGameObject(audioCountPlay);
    }

    private void OnTriggerExit(Collider other)
    {
        audioCountPlay = 0;
        
        if (other.gameObject.tag == "ExitVillage") { audioCountPlay = 0;  }
        if (other.gameObject.tag == "ExitTower") { audioCountPlay = 0;  }
        if (other.gameObject.tag == "ExitForest") { audioCountPlay = 0;  }
        if (other.gameObject.tag == "EnterVillage") { audioCountPlay = 1; }
        if (other.gameObject.tag == "EnterTower") { audioCountPlay = 2; }
        if (other.gameObject.tag == "EnterForest") { audioCountPlay = 3; }

        characterAudioController.SpawnAudioGameObject(audioCountPlay);
    }

}
