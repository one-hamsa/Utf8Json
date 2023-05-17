using UnityEngine;

namespace Utf8Json
{
    public static class UnityPlayTimeHelper
    {
        public static bool suppressEditorDynamicSerializationErrors = false;
        public static bool isEditModeOrBuild => suppressEditorDynamicSerializationErrors || _isEditModeOrBuild;
        private static bool _isEditModeOrBuild;
        #if UNITY_EDITOR
        
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        static void Initialize()
        {
            _isEditModeOrBuild = false;

            Application.quitting += () => _isEditModeOrBuild = true;
        }
        #endif
    }
}