using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;
using System;

namespace Model.Services
{
    /// <summary>
    /// Представляет реализацию по сериализации данных.
    /// </summary>
    public static class ContactSerializer
    {
        
        
        /// <summary>
        /// Возвращает и задает путь сохранения файла.
        /// </summary>
        public static string Path
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                + @"\contacts.json";
            }
        }
          
        /// <summary>
        /// Сохраняет список объектов в файл.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public static void Save(ObservableCollection<Contact> contacts)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }

            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        public static ObservableCollection<Contact> Load()
        {
            var contacts = new ObservableCollection<Contact>();

            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contacts
                        = JsonConvert.
                        DeserializeObject<ObservableCollection<Contact>>
                        (sr.ReadToEnd());
                }
                if (File.Exists(Path)) ;
            }
            catch (FileNotFoundException e)
            {
                return contacts;
            }

            return contacts;
        }
    }
}
