using UnityEngine;
using System.Collections;

public class EffectManager : SingletonMonoBehaviour<EffectManager> {

	public ParticleSystem[] particles;

	public void PlayEffect(int num){
		particles [num].Play (true);
	}
}
