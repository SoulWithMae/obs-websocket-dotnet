﻿using Newtonsoft.Json;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Response from <see cref="OBSWebsocket.GetSceneList"/>
    /// </summary>
    public class SceneBasicInfo
    {
        /// <summary>
        /// Name of scene
        /// </summary>
        [JsonProperty(PropertyName = "sceneName")]
        public string Name { set; get; }

        /// <summary>
        /// Index of scene
        /// </summary>
        [JsonProperty(PropertyName = "sceneIndex")]
        public string Index { set; get; }
    }
}
