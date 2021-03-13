using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;



namespace PizzaBox.Storing{
  public class FileStorage{
    private readonly string _path = @"store.xml";
    private readonly string PizzaPath = @"pizza.xml";
    private readonly string OrderPath = @"order.xml";

    public void WriteToXml<T>(List<T> data) where T : class{
      using (var writer = new StreamWriter(_path)){
        var serializer = new XmlSerializer(typeof(List<T>));

        serializer.Serialize(writer, data);
      }
    }

    public IEnumerable<T> ReadFromXml<T>() where T : class{
      using (var reader = new StreamReader(_path))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        return serializer.Deserialize(reader) as IEnumerable<T>;
      }
    }
      public void WriteToPizzaXml<T>(List<T> data) where T : class{
      using (var writer = new StreamWriter(PizzaPath))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        serializer.Serialize(writer, data);
      }
    }
    public IEnumerable<T> ReadPizzaFromXml<T>() where T : class{

      using (var reader = new StreamReader(PizzaPath))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        return serializer.Deserialize(reader) as IEnumerable<T>;
      }
    }
      public void WriteToOrderXml<T>(List<T> data) where T : class{
      using (var writer = new StreamWriter(OrderPath))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        serializer.Serialize(writer, data);
      }
    }
    public IEnumerable<T> ReadOrderFromXml<T>() where T : class{

      using (var reader = new StreamReader(OrderPath))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        return serializer.Deserialize(reader) as IEnumerable<T>;
      }
    }
  }
}
