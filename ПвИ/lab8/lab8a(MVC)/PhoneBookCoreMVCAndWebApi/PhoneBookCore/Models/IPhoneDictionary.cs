using System.Collections.Generic;

namespace PhoneBookCore.Models
{
    public interface IPhoneDictionary
    {
        List<Phone> SelectAll();
        Phone SelectById(int id);
        bool Insert(string name, string phoneNumber);
        bool Update(int? id, string name, string phoneNumber);
        bool Delete(int? id);
    }
}
