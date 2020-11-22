
public class Rootobject
{
    public Result[] result { get; set; }
}

public class Result
{
    public int sn { get; set; }
    public Sar sar { get; set; }
    public Jammer[] jammer { get; set; }
}

public class Sar
{
    public float rfbm { get; set; }
    public float londeg { get; set; }
    public float latdeg { get; set; }
    public float altm { get; set; }
    public float psdBW { get; set; }
    public float pjdBW { get; set; }
    public float kjdB { get; set; }
    public float jsrdB { get; set; }
    public float yn { get; set; }
}

public class Jammer
{
    public float rstm { get; set; }
    public float rsjm { get; set; }
    public float thetadeg { get; set; }
    public float phideg { get; set; }
    public float GrdB { get; set; }
    public float varphideg { get; set; }
    public float GjdB { get; set; }
    public float semibeamtdeg { get; set; }
    public float semibeampdeg { get; set; }
    public int inbeam { get; set; }
    public float prW { get; set; }
}



public class StaticData
{
    public int npts { get; set; }
    public int njams { get; set; }
    public int mode { get; set; }
    public float[] workmodeinfo { get; set; }
    public float[] begposition { get; set; }
    public float[] endposition { get; set; }
    public float[] curposition { get; set; }
    public int heading { get; set; }
    public int velocity { get; set; }
    public int sardirection { get; set; }
    public int sarsweepangle { get; set; }
    public int sarpt { get; set; }
    public int sargt { get; set; }
    public float wavelength { get; set; }
    public int bandwidth { get; set; }
    public float pulsewidth { get; set; }
    public int repetitionfreq { get; set; }
    public float sarsysloss { get; set; }
    public float sartransloss { get; set; }
    public int synthetictime { get; set; }
    public float beamwidthA { get; set; }
    public float beamwidthR { get; set; }
    public float reflectance { get; set; }
    public int elementsA { get; set; }
    public int elementsR { get; set; }
    public float elementdisA { get; set; }
    public float elementdisR { get; set; }
    public StaticJammer[] jammer { get; set; }
}

public class StaticJammer
{
    public int serialNO { get; set; }
    public int flagtrack { get; set; }
    public int jamtype { get; set; }
    public float lon { get; set; }
    public float lat { get; set; }
    public float alt { get; set; }
    public int pj { get; set; }
    public int gj { get; set; }
    public float bwj { get; set; }
    public float recvloss { get; set; }
    public int beamheading { get; set; }
    public int beampitch { get; set; }
    public int beamwidth { get; set; }
}
