using UnityEngine;
using System.Collections;

namespace Assets.Scripts.UI
{
public class CUIManager {

		public static void PrintLog(string log,int pos)
		{
			string msg = string.Format ("CUIManager::{0},{1}", pos, log);
			Debug.Log (msg);
		}

		public static void DumpCompnents(GameObject go)
		{
			if (go == null) {
				return;
			}
			Component[] coms = go.GetComponents(typeof(Component));
			foreach (Component  com in coms) {
				if (com == null) continue;
				System.Type type = com.GetType();
				string typeName = "Empty";
				string comName = com.name??"Empty";
				if (type != null) typeName = type.Name??"Empty";
	
				Debug.Log ("Component <name>:" + comName + " <class name>:" + typeName);
				


			}
		}
		
		public void OpenForm(string formPath,
		                     bool useFormPool,
		                     bool useCameraRenderMode=true,
		                     string explicitAssetBundlePath=null,
		                     bool IsAssetBundleUnCompress=true)
		{
			PrintLog (formPath, 1);
		}

		private GameObject CreateForm(string formPrefabPath,
		                              bool useFormPool,
		                              string explicitAssetBundlePath=null,
		                              bool IsAssetBundleUnCompress=true)
		{
			GameObject go = null;
			if (go == null) {
			
			}

			if (go != null) {
				DumpCompnents(go);
			}

			return go;
		}
}
}
