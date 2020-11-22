using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SARParams : MonoBehaviour
{
    [Header("Static")]
    public TextMeshProUGUI sarsweepangle;
    public TextMeshProUGUI workModeInfo;
    public TextMeshProUGUI sarpt;
    public TextMeshProUGUI sargt;
    public TextMeshProUGUI wavelength;
    public TextMeshProUGUI bandwidth;
    public TextMeshProUGUI pulsewidth;
    public TextMeshProUGUI repetitionfreq;
    public TextMeshProUGUI sarsysloss;
    public TextMeshProUGUI sartransloss;
    public TextMeshProUGUI synthetictime;
    public TextMeshProUGUI beamwidthA;
    public TextMeshProUGUI beamwidthR;
    [Header("Dynamic")]
    public TextMeshProUGUI lon;
    public TextMeshProUGUI lat;
    public TextMeshProUGUI alt;
    public TextMeshProUGUI ps;
    public TextMeshProUGUI pj;
    public TextMeshProUGUI kj;
    public TextMeshProUGUI jsr;
    public TextMeshProUGUI yn;
}
