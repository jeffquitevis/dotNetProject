using System;
using System.Collections.Generic;
using System.IO;
using FormFileStore.Model;


namespace FormFileStore
{
    public class DataStoreFile : IDataStore
    {
      
        private const string Path = @"c:\temp\database.txt";
        private Dictionary<long, long> position = new Dictionary<long, long>();
    
        public DataStoreFile()
        {

            if (!File.Exists(Path))
            {
                FileStream file = File.Create(Path);
                file.Close();

            }
            else
            {
                Initialize();
            }
            
        }

        
        public void AddPerson(Person person)
        {
                    
            using (BinaryWriter bw = new BinaryWriter(new FileStream(Path, FileMode.Append, FileAccess.Write)))
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
           
            using (BinaryReader br = new BinaryReader(new FileStream(Path, FileMode.Open, FileAccess.Read)))
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
            using(BinaryReader br = new BinaryReader(new FileStream(Path, FileMode.Open, FileAccess.ReadWrite)))
            {                
                using(BinaryWriter bw = new BinaryWriter(br.BaseStream))
                {
                    br.BaseStream.Seek(position[id], SeekOrigin.Begin);
                    bw.Write(true);
                }
            }

        }

        public HashSet<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
                     
            using (BinaryReader br = new BinaryReader(new FileStream(Path, FileMode.Open, FileAccess.Read)))
            {
               
                using (BinaryWriter bw = new BinaryWriter(new MemoryStream()))
                {

                    long index = 0;

                    for (long x = 0; x < br.BaseStream.Length; x = index)
                    {

                        bool isDelete = br.ReadBoolean();
                        Person tempPerson = new Person(br.ReadInt64(), br.ReadString(), br.ReadString());

                        bw.Write(isDelete);
                        bw.Write(tempPerson.Id);
                        bw.Write(tempPerson.FirstName);
                        bw.Write(tempPerson.LastName);

                        position.Add(Convert.ToInt64(tempPerson.Id), index);
                        index = bw.BaseStream.Length;
                    }
                       

                    
                }
            }
        }
    }
}
