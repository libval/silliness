using System.IO;
using System.Reflection;
using UnityEngine;

namespace silliness.Utilities
{
    public class AssetUtils
    {
        public static AssetBundle LoadBundle(string path)
        {
            Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
            return AssetBundle.LoadFromStream(stream);
        }
    }
}
