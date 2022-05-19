using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionInfo : MonoBehaviour
{
    [SerializeField]
    Slider volume;

    [SerializeField]
    Toggle mute, fullscreen;

    public static float volumeVal { get; set; }
    public static bool muteVal { get; set; }
    public static bool fullscreenVal { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        volume.value = volumeVal;
        mute.isOn = muteVal;
        fullscreen.isOn = fullscreenVal;
    }

    // Update is called once per frame
    void Update()
    {
        volumeVal = volume.value;
        muteVal = mute.isOn;
        fullscreenVal = fullscreen.isOn;
    }
}
