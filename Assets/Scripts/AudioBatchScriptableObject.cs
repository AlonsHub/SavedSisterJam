using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

[CreateAssetMenu(menuName="Audio Events/Audio Batch")]
public class AudioBatchScriptableObject : ScriptableObject
{
	public Action AudioEnded;

    [SerializeField]
    private AudioSource _source;
    public AudioSource Source => _source;

	public AudioClip[] clips;

    //public RangedFloat volume;

    //[MinMaxRange(0, 2)]
    //public RangedFloat pitch;

	/// <summary>
    /// Plays a random audio clip and returns clip length.
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public float Play()
	{
		if (clips.Length == 0) return 0;

		_source.clip = clips[Random.Range(0, clips.Length)];
		_source.Play();
		return _source.clip.length;
	}

	public double getTheLegnthOfLongestClip()
    {
        if (clips.Length == 0) return 0f;

        double longestValue = 0;

        foreach( AudioClip clip in clips)
        {
            double currentClipLength = (double)(clip.samples / clip.frequency);
            longestValue = currentClipLength > longestValue ? currentClipLength : longestValue;
        }

        return longestValue;
    }
}