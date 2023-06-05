using Newtonsoft.Json;
using System.IO;
using System.Collections.ObjectModel;
using View.ViewModel;
using System;

namespace View.Model.Services
{
    /// <summary>
    /// Представляет реализацию по сериализации данных.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="ContactSerializer"/>.
        /// </summary>
        public ContactSerializer()
        {

        }

        /// <summary>
        /// Возвращает и задает путь сохранения файла.
        /// </summary>
        public string Path { get; set; }
            = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\contacts.json";


        /// <summary>
        /// Сохраняет список объектов в файл.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public void Save(ObservableCollection<ContactVM> contacts)
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

        public ObservableCollection<ContactVM> Load()
        {
            var contacts = new ObservableCollection<ContactVM>();

            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contacts
                        = JsonConvert.
                        DeserializeObject<ObservableCollection<ContactVM>>
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
