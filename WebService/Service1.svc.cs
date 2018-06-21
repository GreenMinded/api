using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public IList<SPI_QuestionAnswer_Result> GetQuestionAnswer()
        {
            IList<SPI_QuestionAnswer_Result> items;
            using (var database = new GreenMindedEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                items = database.SPI_QuestionAnswer().ToList();
            }
            return items.ToList();
        }

        public IList<stations> GetStation()
        {
            IList<stations> items;
            using (var database = new GreenMindedEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                items = database.stations.ToList();
            }
            return items.ToList();
        }
    }
}
