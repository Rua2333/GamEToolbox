using System.Collections.Generic;
using System.IO;
using Valve.Newtonsoft.Json;

namespace Toolkit
{
    public static class ObjectIO
    {
        public static void write<T>(T obj,
             FileInfo fileInfo,
            FileMode fileMode = FileMode.Create)
        {
            using (var streamWriter = new StreamWriter(fileInfo.Open(fileMode)))
                writeJson(obj, streamWriter);
        }

        public static void writeList<T>( List<T> objs,
             FileInfo fileInfo,
            FileMode fileMode = FileMode.Create) =>
            write(objs, fileInfo, fileMode);


        public static T read<T>(FileInfo fileInfo)
        {
            using (var jsonTextReader = new JsonTextReader(
                new StreamReader(fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite))))
            {
                return JsonSerializer.Create().Deserialize<T>(jsonTextReader);
            }
        }

        public static List<T> readList<T>( FileInfo fileInfo)
        {
            return ObjectIO.read<List<T>>(fileInfo);
        }

        public static string getJsonStr<T>(T obj)
        {
            var stringWriter = new StringWriter();
            writeJson(obj, stringWriter);
            return stringWriter.ToString();
        }

        public static void writeJson<T>(T obj, TextWriter textWriter)
        {
            var jsonSerializer = new JsonSerializer();
            jsonSerializer.Serialize(textWriter, obj);
        }
    }
}