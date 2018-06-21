using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IList<stations> GetStation();

        //[OperationContract]
        //IList<clients> GetClient();

        //[OperationContract]
        //IList<answers> GetAnswer();

        //[OperationContract]
        //IList<questions> GetQuestion();

        [OperationContract]
        IList<SPI_QuestionAnswer_Result> GetQuestionAnswer();




    }

}
