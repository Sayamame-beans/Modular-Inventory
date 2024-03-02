using System;
using UnityEditor;
using UnityEngine;

namespace Sayabeans.ModularInventory
{
    [CustomEditor(typeof(InventoryData))]
    internal class InventoryDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.LabelField("まだ何もありません。");
        }
    }
}
