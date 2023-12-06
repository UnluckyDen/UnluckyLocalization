using System;
using UnityEngine;

namespace UnluckyLocalization.Editor
{
    [Serializable]
    public class LocalizationSettings : ScriptableObject
    {
        public const string FileName = "LocalizationSettings.asset";

        public string TableId;
        public string SheetId;
        public bool IsSplitInternalAndExternal;
        public string InternalFolder;
        public string ExternalFolder;

        public override string ToString() =>
            $"[LocalizationSettings] TableId: {TableId}, SheetId: {SheetId}, IsSplitInternalAndExternal: {IsSplitInternalAndExternal}, " +
            $"InternalFolder: {InternalFolder}, ExternalFolder: {ExternalFolder}";
    }
}