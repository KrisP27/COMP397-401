using UnityEngine;

public class JsonSerializer : ISerializer
{
    string ISerializer.Serialize<T>(T obj)
    {
        return JsonUtility.ToJson(obj, true);
    }

    T ISerializer.Deserialize<T>(string json)
    {
        throw new System.NotImplementedException();
    }
}
