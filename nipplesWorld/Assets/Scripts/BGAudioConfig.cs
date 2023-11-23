using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "AllBGAudio", menuName = "Game/BGAudio Config")]
public class BGAudioConfig : ScriptableObject
{
    [SerializeField] private GameObject wasteland = null;
    [SerializeField] private GameObject village = null;
    [SerializeField] private GameObject tower = null;
    [SerializeField] private GameObject forest = null;

    public GameObject Wasteland => wasteland;
    public GameObject Village => village;
    public GameObject Tower => tower;
    public GameObject Forest => forest;

}
