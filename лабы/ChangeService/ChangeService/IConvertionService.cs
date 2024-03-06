using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace ChangeService.Contracts
{

    [ServiceContract(Namespace = " http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx")]

         public interface IConvertionService
         {
            [OperationContract]
            double Convert (string from, double summ, string to);
         }
    
}
