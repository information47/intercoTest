using iothink.interco.lib.Models.Incwo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace iothink.interco.services.Utils
{
    public class IncwoObjectFactory
    {
        private Dictionary<string, string> typeMappings;

        public IncwoObjectFactory()
        {
            // initialize dictionnary to match object_zname and types
            typeMappings = new Dictionary<string, string>
            {
                { "contacts", "Contact" },
                { "leads", "Lead" },
                { "proposal_sheets","Proposal" },
                { "bill_sheets", "Invoice" },
                { "firms", "Firm" }
            };
        }

        public T CreateObject<T>(string zName) where T : IincwoObject
        {
            if (!typeMappings.ContainsKey(zName))
            {
                throw new ArgumentException("Type not found.");
            }
            
            // Get the type name from zName
            string typeName = typeMappings[zName];
            // Get the type thanks to type name
            Type objectType = Type.GetType($"iothink.interco.lib.Models.Incwo.{typeName}, iothink.interco.lib");

            // if objectType isn't null and can be assign to T
            if (objectType == null || !typeof(T).IsAssignableFrom(objectType))
            {
                throw new ArgumentException("Type not found or invalid.");
            }
            // create an instance of an object (Lead, Contact...) and return it
            return (T)Activator.CreateInstance(objectType);

        }
    }
}
