using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using Ifly_PublicRes;
using System;
using TMPro;

public class DataSource : MonoBehaviour
{
    public SARParams UAVSar = null;
    public SARParams sateliteSar = null;
    public JammerParams jammer = null;
    public PlatformParams platformParams = null;

    public Rootobject root = new Rootobject();
    public StaticData staticData = new StaticData();
    private MyTimer myTimer = new MyTimer();
    public int curIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        root = JsonConvert.DeserializeObject<Rootobject>(ReadJsonData("result"));
        staticData = JsonConvert.DeserializeObject<StaticData>(ReadJsonData("input"));
        RefreshStaticData();
        RefreshDynamicData();
        myTimer.duration = 0.5f;
        myTimer.Go();
    }

    private void RefreshStaticData()
    {
        //机载sar
        UAVSar.sarsweepangle.text = staticData.sarsweepangle.ToString();
        UAVSar.workModeInfo.text = staticData.workmodeinfo[0].ToString();
        UAVSar.sarpt.text = staticData.sarpt.ToString();
        UAVSar.sargt.text = staticData.sargt.ToString();
        UAVSar.wavelength.text = staticData.wavelength.ToString();
        UAVSar.bandwidth.text = staticData.bandwidth.ToString();
        UAVSar.pulsewidth.text = staticData.pulsewidth.ToString();
        UAVSar.repetitionfreq.text = staticData.repetitionfreq.ToString();
        UAVSar.sarsysloss.text = staticData.sarsysloss.ToString();
        UAVSar.sartransloss.text = staticData.sartransloss.ToString();
        UAVSar.synthetictime.text = staticData.synthetictime.ToString();
        UAVSar.beamwidthA.text = staticData.beamwidthA.ToString();
        UAVSar.beamwidthR.text = staticData.beamwidthR.ToString();
        //星载sar
        sateliteSar.sarsweepangle.text = staticData.sarsweepangle.ToString();
        sateliteSar.workModeInfo.text = staticData.workmodeinfo[0].ToString();
        sateliteSar.sarpt.text = staticData.sarpt.ToString();
        sateliteSar.sargt.text = staticData.sargt.ToString();
        sateliteSar.wavelength.text = staticData.wavelength.ToString();
        sateliteSar.bandwidth.text = staticData.bandwidth.ToString();
        sateliteSar.pulsewidth.text = staticData.pulsewidth.ToString();
        sateliteSar.repetitionfreq.text = staticData.repetitionfreq.ToString();
        sateliteSar.sarsysloss.text = staticData.sarsysloss.ToString();
        sateliteSar.sartransloss.text = staticData.sartransloss.ToString();
        sateliteSar.synthetictime.text = staticData.synthetictime.ToString();
        sateliteSar.beamwidthA.text = staticData.beamwidthA.ToString();
        sateliteSar.beamwidthR.text = staticData.beamwidthR.ToString();

        //jammer
        jammer.serialNO.text = staticData.jammer[0].serialNO.ToString();
        jammer.lon.text = staticData.jammer[0].lon.ToString();
        jammer.lat.text = staticData.jammer[0].lat.ToString();
        jammer.alt.text = staticData.jammer[0].alt.ToString();
        jammer.pj.text = staticData.jammer[0].pj.ToString();
        jammer.gj.text = staticData.jammer[0].gj.ToString();
        jammer.bwj.text = staticData.jammer[0].bwj.ToString();
        jammer.recvloss.text = staticData.jammer[0].recvloss.ToString();
        jammer.beamheading.text = staticData.jammer[0].beamheading.ToString();
        jammer.beampitch.text = staticData.jammer[0].beampitch.ToString();
        jammer.beamwidth.text = staticData.jammer[0].beamwidth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        myTimer.Tick();
        if (myTimer.state == MyTimer.STATE.FINISHED)
        {
            curIndex++;
            if (curIndex >= root.result.Length)
            {
                curIndex = 0;
            }
            RefreshDynamicData();
            myTimer.Go();
        }
    }

    private void RefreshDynamicData()
    {
        UAVSar.lon.text = root.result[curIndex].sar.lon.ToString();
        UAVSar.lat.text = root.result[curIndex].sar.lat.ToString();
        UAVSar.alt.text = root.result[curIndex].sar.alt.ToString();
        UAVSar.ps.text = root.result[curIndex].sar.ps.ToString();
        UAVSar.pj.text = root.result[curIndex].sar.pj.ToString();
        UAVSar.kj.text = root.result[curIndex].sar.kj.ToString();
        UAVSar.jsr.text = root.result[curIndex].sar.jsr.ToString();
        UAVSar.yn.text = root.result[curIndex].sar.jsr.ToString("0")=="0"?"失败":"成功";

        sateliteSar.lon.text = root.result[curIndex].sar.lon.ToString();
        sateliteSar.lat.text = root.result[curIndex].sar.lat.ToString();
        sateliteSar.alt.text = root.result[curIndex].sar.alt.ToString();
        sateliteSar.ps.text = root.result[curIndex].sar.ps.ToString();
        sateliteSar.pj.text = root.result[curIndex].sar.pj.ToString();
        sateliteSar.kj.text = root.result[curIndex].sar.kj.ToString();
        sateliteSar.jsr.text = root.result[curIndex].sar.jsr.ToString();
        sateliteSar.yn.text = root.result[curIndex].sar.jsr.ToString("0") == "0" ? "失败" : "成功";
    }

    private string ReadJsonData(string fileName)
    {
        string filePath = Application.streamingAssetsPath + "/" + fileName + ".json";
        StreamReader streamReader = new StreamReader(filePath);
        string sr = streamReader.ReadToEnd();
        streamReader.Close();
        streamReader.Dispose();
        return sr;
    }
}
