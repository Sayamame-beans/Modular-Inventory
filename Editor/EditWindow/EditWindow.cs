using UnityEditor;
using UnityEngine;
using VRC.SDK3.Avatars.Components;

namespace Sayabeans.ModularInventory.EditWindow
{
    internal class EditWindow : EditorWindow
    {
        [MenuItem("Tools/Modular Inventory")]
        private static void ShowWindow()
        {
            var window = EditorWindow.GetWindow(typeof(EditWindow), false, "Modular Inventory");
            window.Show();
        }

        private void OnGUI()
        {

        }
    }
}
