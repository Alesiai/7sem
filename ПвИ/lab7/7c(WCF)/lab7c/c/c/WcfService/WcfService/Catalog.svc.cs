using System.Collections.Generic;
using WcfService.Db.Ms;
using WcfService.Model;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Catalog : ICatalog
    {
        UserContextFactory userContext = new UserContextFactory();

        public List<User> GetContacts()
        {
            return userContext.GetAll();
        }

        public void AddData(User user)
        {
            userContext.Create(user);
        }

        public void UpdateData(User user)
        {
            userContext.Update(user);
        }

        public User GetOneById(int id)
        {
            return userContext.GetOneById(id);
        }

        public bool DeleteDataById(int id)
        {
            return userContext.Delete(id);
        }

       
    }
}
