using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.

    public class User
    {
        Dictionary<int, string> users = null;

        public User()
        {
            users = new Dictionary<int, string>();

            users.Add(1, "Sathish");
            users.Add(2, "Joe");
            users.Add(3, "Babu");
            users.Add(4, "Deb");
        }

        public string[] GetUser(int Id)
        {
            var user = from u in users
                        where u.Key == Id
                        select u.Value;

            return user.ToArray<string>();
        }

    }

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public string[] GetUser(string Id)
        {
            return new User().GetUser(Convert.ToInt32(Id));
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
