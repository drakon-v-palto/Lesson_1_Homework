using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BelieveOrNotBelieve
{
	// Класс для вопроса
	[Serializable]
	public class Question
	{
		public string text;     // Текст вопроса
		public bool trueFalse;  // Правда или нет

		// Для сериализации должен быть пустой конструктор
		public Question()
		{
		}

		public Question(string text, bool trueFalse)
		{
			this.text = text;
			this.trueFalse = trueFalse;
		}
	}

	// Класс для хранения списка вопросов, а также для сериализации и десериализации XML
	class TrueFalse
	{
		string fileName;
		List<Question> list;

		public string FileName
		{
			set { fileName = value; }
		}

		// путь к файлу и новый список
		public TrueFalse(string fileName)
		{
			this.fileName = fileName;
			list = new List<Question>();
		}

		// добавление вопроса
		public void Add(string text, bool trueFalse)
		{
			list.Add(new Question(text, trueFalse));
		}

		// удаление вопроса
		public void Remove(int index)
		{
			if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
		}

		// Индексатор - свойство для доступа к закрытому объекту
		public Question this[int index]
		{
			get { return list[index]; }
		}

		// сериализация списка вопросов
		public void Save()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			xmlFormat.Serialize(fStream, list);
			fStream.Close();
		}

		// десериализация списка
		public void Load()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			list = (List<Question>)xmlFormat.Deserialize(fStream);
			fStream.Close();
		}

		// размер списка
		public int Count
		{
			get { return list.Count; }
		}
	}
}
