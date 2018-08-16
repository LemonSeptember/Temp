namespace Temp
{
    /// <summary>
    /// Act 码
    /// </summary>
    public enum xfActCode : short
    {
        /// <summary>
        /// STEP_PLUSE
        /// </summary>
        Encoder_Step = -10000,
        B1 = -10001,
        B2 = -10002,

        /// <summary>
        /// MISS1
        /// </summary>
        Miss1_Rail_Base = -10003,

        /// <summary>
        /// MISS2
        /// </summary>
        Miss2_Rail_Base = -10004,

        MacType = -10005,
        MacNum = -10006,
        Date = -10007,
        Time = -10008,

        /// <summary>
        /// TRIP
        /// </summary>
        Location = -10009,
        Speed = -10010,
        Coupling = -10011,
        GPS = -10012,

        /// <summary>
        /// BATTERY
        /// </summary>
        BattPercent = -10013,

        User = -10014,

        /// <summary>
        /// 班组
        /// </summary>
        Team = -10015,

        /// <summary>
        /// 工区
        /// </summary>
        Area = -10016,

        /// <summary>
        /// 单位
        /// </summary>
        Unit = -10017,

        LinkType = -10018,
        SideType = -10019,
        Count = -10020,
        LineType = -10021,
        LineNum = -10022,
        SiteNum = -10023,
        TrackNum = -10024,
        RailNum = -10025,
        Trolley = -10026,
        WorkMode = -10027,
        RailType = -10028,
        RailClass = -10029,
        RailHgt = -10030,
        RailHeadHgt = -10031,
        RailBoltHgt = -10032,
        Gain = -10033,
        ProbeDir = -10034,
        ProbeAng = -10035,
        TestRange = -10036,
        ZeroDelay = -10037,
        Gate0Head = -10038,
        Gate0Tail = -10039,
        Gate1Head = -10040,
        Gate1Tail = -10041,
        Gate2Head = -10042,
        Gate2Tail = -10043,

        /// <summary>
        /// PROBE_POS
        /// </summary>
        ProbePosition = -10044,
        Suppress = -10045,
        BackAlarm = -10046,

        /// <summary>
        /// MISS_ALARM
        /// </summary>
        PassAlart = -10047,
        SpeedAlart = -10048,
        CoupleAlart = -10049,
        Note = -10050,
        Photo = -10051,
        PowerOn = -10052,
        PowerOff = -10053,
        BackStart = -10054,
        BackEnd = -10055,
        KMRound = -10056,

        /// <summary>
        /// Obsolute
        /// </summary>
        OldMark = -10057,
        NewMark = -10058,

        /// <summary>
        /// PulseLen
        /// </summary>
        StepLength = -10059,

        /// <summary>
        /// SpBRI
        /// </summary>
        Brightness = -10060,
        Measurement = -10061,

        /// <summary>
        /// STEP_PULSE_length
        /// </summary>
        StepNum = -10062,

        /// <summary>
        /// B_1_a
        /// </summary>
        B1_Chan1 = -10063,

        /// <summary>
        /// B_1_b
        /// </summary>
        B1_Chan2 = -10064,

        /// <summary>
        /// B_1_c
        /// </summary>
        B1_Chan3 = -10065,

        /// <summary>
        /// B_1_d
        /// </summary>
        B1_Chan4 = -10066,

        /// <summary>
        /// B_1_e
        /// </summary>
        B1_Chan5 = -10067,

        /// <summary>
        /// B_1_f
        /// </summary>
        B1_Chan6 = -10068,

        /// <summary>
        /// B_1_g
        /// </summary>
        B1_Chan7 = -10069,

        /// <summary>
        /// B_1_h
        /// </summary>
        B1_Chan8 = -10070,

        /// <summary>
        /// B_1_i
        /// </summary>
        B1_Chan9 = -10071,

        /// <summary>
        /// B_2_a
        /// </summary>
        B2_Chan1 = -10073,

        /// <summary>
        /// B_2_b
        /// </summary>
        B2_Chan2 = -10074,

        /// <summary>
        /// B_2_c
        /// </summary>
        B2_Chan3 = -10075,

        /// <summary>
        /// B_2_d
        /// </summary>
        B2_Chan4 = -10076,

        /// <summary>
        /// B_2_e
        /// </summary>
        B2_Chan5 = -10077,

        /// <summary>
        /// B_2_f
        /// </summary>
        B2_Chan6 = -10078,

        /// <summary>
        /// B_2_g
        /// </summary>
        B2_Chan7 = -10079,

        /// <summary>
        /// B_2_h
        /// </summary>
        B2_Chan8 = -10080,

        /// <summary>
        /// B_2_i
        /// </summary>
        B2_Chan9 = -10081,

        #region Sperry

        SpOPER = -10200,
        SpROT = -10201,
        SpSECT1 = -10202,
        SpELR1 = -10203,
        SpELR2 = -10204,
        SpTID = -10205,
        SpLR = -10206,
        SpRID = -10207,
        SpRWT = -10208,
        SpTRF = -10209,
        SpUIC = -10210,
        SpPROC = -10211,
        SpSECT2 = -10212,
        SpMARK = -10213,
        SpCUST = -10214,
        SpWave = -10215,
        SpPROBE = -10216,
        SpDIVI = -10217,
        SpUD = -10218,
        SpROLL = -10219,
        SpFLAW = -10220,
        SpCLASSNEW = -10221,
        SpCLASSOLD = -10222,

        #endregion

        SpROT_CUST = -10223,
        SpSECT1_CUST = -10224,
        SpELR1_CUST = -10225,
        SpELR2_CUST = -10226,
        SpTID_CUST = -10227,
        SpRID_CUST = -10228,
        SpRWT_CUST = -10229,
        SpTRF_CUST = -10230,
        SpUIC_CUST = -10231,
        SpSECT2_CUST = -10232,
        SpCLASS_CUST = -10233,
        SpLCS_CUST = -10234,
        B1_RWUT_a = -10300,
        B1_RWUT_b = -10301,
        B1_RWUT_c = -10302,
        B1_RWUT_d = -10303,
        B1_RWUT_e = -10304,
        B1_RWUT_f = -10305,
        B1_RWUT_g = -10306,
        B1_RWUT_h = -10307,
        B1_RWUT_i = -10308,
        B1_RWUT_j = -10309,
        B1_RWUT_k = -10310,
        B2_RWUT_a = -10311,
        B2_RWUT_b = -10312,
        B2_RWUT_c = -10313,
        B2_RWUT_d = -10314,
        B2_RWUT_e = -10315,
        B2_RWUT_f = -10316,
        B2_RWUT_g = -10317,
        B2_RWUT_h = -10318,
        B2_RWUT_i = -10319,
        B2_RWUT_j = -10320,
        B2_RWUT_k = -10321,

        #region ForPC

        Search = -11000,
        Replay = -11001,
        Report = -11002,

        #endregion

        // STEP_BLANK_start = -11003, 

        /// <summary>
        /// TODO::无对照？？
        /// </summary>
        STEP_BLANK_end = -11004,
        F9_NOTE = -11005,
        PLAY_BACK = -11006
    }
}
