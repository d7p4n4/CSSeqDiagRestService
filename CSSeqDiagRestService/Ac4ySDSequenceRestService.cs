
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CSAc4yObjectService.Class;
using d7p4n4Namespace.Final.Class;
using d7p4n4Namespace.PersistentService.Class;
using d7p4n4NamespaceApi.Controller.Class;

namespace d7p4n4NamespaceApi.Controller.Class
{
    public class Ac4ySDSequenceController : ApiController
    {

        private string baseName = ConfigurationManager.AppSettings["baseName"];

        public GetObjectResponse GetFirstById(int id)
        {
            Ac4ySDSequencePersistentService persistentService = new Ac4ySDSequencePersistentService(baseName);

            return persistentService.GetFirstById(id);
        }

        public GetObjectResponse GetFirstWithXML(int id)
        {
            Ac4ySDSequencePersistentService persistentService = new Ac4ySDSequencePersistentService(baseName);

            return persistentService.GetFirstWithXML(id);
		}
		
		public GetObjectResponse SaveWithXml(Ac4ySDSequence _Ac4ySDSequence)
        {
            Ac4ySDSequencePersistentService persistentService = new Ac4ySDSequencePersistentService(baseName);

            return persistentService.SaveWithXml(_Ac4ySDSequence);
        }
		
		public GetObjectResponse Save(Ac4ySDSequence _Ac4ySDSequence)
        {
            Ac4ySDSequencePersistentService persistentService = new Ac4ySDSequencePersistentService(baseName);

            return persistentService.Save(_Ac4ySDSequence);
        }
    }
}
