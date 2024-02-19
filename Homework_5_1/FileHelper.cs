using System.IO;
using System.Xml.Serialization;

namespace Homework_5_1
{
    public class FileHelper<T> where T : new()
    {
        private string _filePath;
        public FileHelper(string FilePath)
        {
            _filePath = FilePath;
        }

        public void SerializeToFile(T students)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, students);
                streamWriter.Close();
            }
        }
        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new T();
            }

            var serializer = new XmlSerializer(typeof(T));
            using (StreamReader streamReader = new StreamReader(_filePath))
            {
                var students = (T)serializer.Deserialize(streamReader);
                streamReader.Close();

                return students;
            }
        }

    }
}
