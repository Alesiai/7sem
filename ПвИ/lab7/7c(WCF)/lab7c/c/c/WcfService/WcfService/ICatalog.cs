using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Model;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface ICatalog
    {

        [OperationContract]
        List<User> GetContacts();

        [OperationContract]
        void AddData(User user);

        [OperationContract]
        bool DeleteDataById(int id);

        [OperationContract]
        void UpdateData(User user);

        [OperationContract]
        User GetOneById(int id);


        // TODO: Добавьте здесь операции служб
    }
}