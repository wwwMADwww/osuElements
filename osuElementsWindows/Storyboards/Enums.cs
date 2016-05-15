﻿namespace osuElements.Storyboards
{
    public enum EventTypes //print as string in osb, as int in osu
    {
        Background = 0,
        Video = 1,
        Break = 2,
        Backgroundcolor = 3,
        Sprite = 4,
        Sample = 5,
        Animation = 6,
    }
    public enum EventLayer//print as string
    {
        Undefined = -1,
        Background = 0,
        Fail = 1,
        Pass = 2,
        Foreground = 3,
    }
    public enum Origin//print as string
    {
        TopLeft,
        TopCentre,
        TopRight,
        CentreLeft,
        Centre,
        CentreRight,
        BottomLeft,
        BottomCentre,
        BottomRight,
    }
    public enum Easing //print as int
    {
        None = 0,
        In = 1,
        Out = 2,
    }
    public enum Looptypes : byte //print as string
    {
        LoopForever,
        LoopOnce,
    }
    public enum TransformTypes
    {
        F, //fade
        M, //move
        MX, //move x
        MY, //move y
        S, //scale
        V, //vector scale
        R, //rotate
        C, //color
        P, //parameter
        //last ones are special because they ignore all previous while active
        L, //loop
        T, //trigger
    }
    public enum ParameterTypes : byte
    {
        A, //Additive color blending
        H, //Horizontal flip
        V, //Vertical flip
    }
    public enum TriggerTypes : byte
    {
        HitSound,
        Passing,
        Failing,
        HitObjectHit,
    }
}