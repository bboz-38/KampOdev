using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T,K>
    {
        // T ve K isimli diziler oluşturuldu
        T[] Key;       
        K[] Value;
        // constructor
        public MyDictionary()
        {
            
            Key = new T[0];
            Value = new K[0];
        }
        // ekleme metodu oluşturuldu
        public void Add(T itemKey, K itemvalue)
        {
            // geçici dizi oluşturuldu
            T[] tempstudentKey = Key;
            K[] tempstudentValue = Value;

            // diziye eleman ekleniyor
            Key = new T[Key.Length + 1];     
            Value = new K[Value.Length + 1];

            for (int i = 0; i < tempstudentKey.Length; i++)
            {
                Key[i] = tempstudentKey[i];    
                Value[i] = tempstudentValue[i];
            }

            
            Key[Key.Length - 1] = itemKey;
            Value[Value.Length - 1] = itemvalue;
        }


       
        public int MyLength
        {
            get { return Key.Length; }
        }

       
        public void List()
        {
            foreach (var ckey in Key)
            {
                Console.WriteLine($"Key: {ckey}");
            }
            foreach (var cvalue in Value)
            {
                Console.WriteLine($"Value: {cvalue}");
            }
        }
    }
}
