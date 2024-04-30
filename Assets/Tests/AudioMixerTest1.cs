using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.TestTools;

public class AudioMixerTest1
{
    private AudioMixer audioMixer;
    
    [SetUp]
    public void Setup()
    {
        audioMixer = Resources.Load<AudioMixer>("MainMixer");
    }
    // A Test behaves as an ordinary method
    [Test]
    public void SetVolume_SetsAudioMixerVolume()
    {
        float testVolume = 0.5f; 

        // Set the float
        audioMixer.SetFloat("Volume",testVolume);

        // Assert the values
        float actualVolume;
        audioMixer.GetFloat("Volume", out actualVolume);
        Assert.AreEqual(testVolume, actualVolume, 0.001f, "Volume not set correctly.");
    }
    public void AudioMixerTest1SimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator AudioMixerTest1WithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
