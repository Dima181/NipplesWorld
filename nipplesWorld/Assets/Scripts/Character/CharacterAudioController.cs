using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CharacterAudioController : MonoBehaviour
{
    [SerializeField] private BGAudioConfig bgAudioConfig;

    [SerializeField] private bool wastelandbool = true;
    [SerializeField] private bool villagebool;

    [SerializeField] private string audioTag = null;

    public GameObject SpawnAudioGameObject(int spawned)
    {
        var spawnedGun = spawned switch
        {
            0 => SpawnAudioEnterWasteland(),
            1 => SpawnAudioEnterVillage(),
            2 => SpawnAudioEnterTower(),
            3 => SpawnAudioEnterForest(),
            _ => null,
        };
        return spawnedGun;
    }

    private GameObject SpawnAudioEnterVillage()
    {
        var audio = SpawnAudio(bgAudioConfig.Village);
        return audio;
    }

    private GameObject SpawnAudioEnterWasteland()
    {
        var audio = SpawnAudio(bgAudioConfig.Wasteland);
        return audio;
    }

    private GameObject SpawnAudioEnterTower()
    {
        var audio = SpawnAudio(bgAudioConfig.Tower);
        return audio;
    }

    private GameObject SpawnAudioEnterForest()
    {
        var audio = SpawnAudio(bgAudioConfig.Forest);
        return audio;
    }

    private GameObject SpawnAudio(GameObject spawnObjectPrefab) 
    {
        GameObject obj = GameObject.FindGameObjectWithTag(this.audioTag);
        if(obj != null)
        {
            GameObject.Destroy(obj);
        }

        var currentGunObject = GameObject.Instantiate(spawnObjectPrefab, gameObject.transform.position, gameObject.transform.rotation);
        //currentGunObject.transform.SetParent(parentPoint.transform);
        return currentGunObject;

    }
}
