using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.IO;
using System.Collections;

namespace FormFileStore
{
    public class DataStoreFile : IDataStore
    {
      
        private const string PATH = @"c:\temp\database.txt";
        private Dictionary<long, long> position = new Dictionary<long, long>();

        public DataStoreFile()
        {
           
            if (!File.Exists(PATH))
            {
                FileStream file = File.Create(PATH);
                file.Close();
                
            }
            
        }

        public void AddPerson(Person person)
        {
                    
            using (BinaryWriter bw = new BinaryWriter(new FileStream(PATH, FileMode.Append, FileAccess.Write)))
            {
                long index = bw.BaseStream.Length;
                bw.Write(false);
                bw.Write(person.Id);
                bw.Write(person.FirstName);
                bw.Write(person.LastName);
                position.Add(person.Id, index);
                index = bw.BaseStream.Length;               
            }

        }

      

        public Person SearchPerson(long id)
        {
            Person tempPerson = null;
           
            using (BinaryReader br = new BinaryReader(new FileStream(PATH, FileMode.Open, FileAccess.Read)))
            {
                br.BaseStream.Seek(position[id], SeekOrigin.Begin);
                
                if (br.ReadBoolean() == false)
                {
                    tempPerson = new Person(br.ReadInt64(), br.ReadString(), br.ReadString());
                }         
            }
            return tempPerson;      
        }

        public void DeletePerson(long id)
        {
            using(BinaryReader br = new BinaryReader(new FileStream(PATH, FileMode.Open, FileAccess.ReadWrite)))
            {                
                using(BinaryWriter bw = new BinaryWriter(br.BaseStream))
                {
                    br.BaseStream.Seek(position[id], SeekOrigin.Begin);
                    bw.Write(true);
                }
            }

            }
    }
}
