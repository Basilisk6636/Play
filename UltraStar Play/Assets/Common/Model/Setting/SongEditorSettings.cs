﻿using System;
using System.Collections.Generic;

[Serializable]
public class SongEditorSettings
{
    public bool AutoSave { get; set; } = true;

    public float MusicVolume { get; set; } = 1;
    public float MusicPlaybackSpeed { get; set; } = 1;
    public bool GoToLastPlaybackPosition { get; set; } = true;

    // Recording in SongEditorScene
    public ESongEditorRecordingSource RecordingSource { get; set; }
    public MicProfile MicProfile { get; set; }
    public int MicOctaveOffset { get; set; }
    public int MicDelayInMillis { get; set; } = 450;
    public int MidiNoteForButtonRecording { get; set; } = MidiUtils.MidiNoteConcertPitch;
    public string ButtonDisplayNameForButtonRecording { get; set; } = "N";

    public bool AdjustFollowingNotes { get; set; }

    // Velocity should be between 0 and 127
    public int MidiVelocity { get; set; } = 100;
    // Gain is similar to volume and should be between 0 and 1 to make it more silent and above 1 to make it louder.
    public float MidiGain { get; set; } = 1;
    public bool MidiSoundPlayAlongEnabled { get; set; } = true;
    public int MidiPlaybackOffsetInMillis { get; set; }
    public string LastMidiFilePath { get; set; } = "";

    public bool ShowLyricsArea { get; set; } = true;
    public bool ShowVideoArea { get; set; } = true;
    public bool ShowStatusBar { get; set; } = true;
    public bool ShowVirtualPianoArea { get; set; } = true;
    public bool SmallLeftSideBar { get; set; }
    public bool ShowControlHints { get; set; } = true;
    public bool ShowNotePitchLabel { get; set; } = true;

    public float GridSizeInPx { get; set; } = 1;
    public float SentenceLineSizeInPx { get; set; } = 2;
}
