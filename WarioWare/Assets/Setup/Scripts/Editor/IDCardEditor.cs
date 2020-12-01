﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.SceneManagement;
using Trisibo;
using UnityEngine;

[CustomEditor(typeof(IDCard))]
public class IDCardEditor : Editor {

	private IDCard idCard;
	private TrioAurelien trioAurel;
	private TrioTheodore trioTheo;
	private TrioThibault trioThibault;
	private void OnEnable() {
		idCard = target as IDCard;
	}

	public override void OnInspectorGUI()
	{
		
		idCard.cluster = (Cluster)EditorGUILayout.EnumPopup("Cluster ",idCard.cluster);
        switch (idCard.cluster)
        {
            case Cluster.Theodore:
				trioTheo = (TrioTheodore) idCard.indexEnum;
				trioTheo = (TrioTheodore)EditorGUILayout.EnumPopup("Trio ", trioTheo);
				idCard.indexEnum =(int) trioTheo;
				idCard.trio = trioTheo.ToString();
				break;
            case Cluster.Aurelien:
				trioAurel = (TrioAurelien)idCard.indexEnum;
				trioAurel = (TrioAurelien)EditorGUILayout.EnumPopup("Trio ", trioAurel);
				idCard.indexEnum = (int)trioAurel;
				idCard.trio = trioAurel.ToString();
				break;
            case Cluster.Thibault:
				trioThibault = (TrioThibault)idCard.indexEnum;
				trioThibault = (TrioThibault)EditorGUILayout.EnumPopup("Trio ", trioThibault);
				idCard.indexEnum = (int)trioThibault;
				idCard.trio = trioThibault.ToString();
				break;
            default:
                break;
        }

		idCard.haptiqueChal = (ChallengeHaptique)EditorGUILayout.EnumPopup("Challenge Haptique ", idCard.haptiqueChal);
		idCard.inputChal = (ChallengeInput)EditorGUILayout.EnumPopup("Challenge Input ", idCard.inputChal);
		
		EditorGUILayout.PropertyField(serializedObject.FindProperty(nameof(idCard.microGameScene)));

		GUILayout.Space(830);

		if (GUILayout.Button("Add To Build")) { AddScene(idCard.microGameScene.EditorSceneAsset); }

		EditorUtility.SetDirty(idCard);
		Repaint();
		serializedObject.ApplyModifiedProperties();
    }
	private void AddScene(SceneAsset scene)
	{
		List<EditorBuildSettingsScene> m_SceneAssets = new List<EditorBuildSettingsScene>();
        for (int i = 0; i < EditorBuildSettings.scenes.Length; i++)
        {
			var _path = EditorBuildSettings.scenes[i].path;
			m_SceneAssets.Add(new EditorBuildSettingsScene (_path,true));
        }
		string scenePath = AssetDatabase.GetAssetPath(scene);
		m_SceneAssets.Add(new EditorBuildSettingsScene(scenePath, true));

		EditorBuildSettings.scenes = m_SceneAssets.ToArray();

	}
}
