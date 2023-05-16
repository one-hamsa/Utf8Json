using UnityEngine;

namespace Utf8Json
{
    internal static class UnityPlayTimeHelper
    {
        public static bool isEditModeOrBuild = true;
        #if UNITY_EDITOR
        
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        static void Initialize()
        {
            isEditModeOrBuild = false;
            
            Application.quitting += () => isEditModeOrBuild = true;
        }
        #endif
    }
}