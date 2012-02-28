using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Configuration;

namespace SafeService
{
  public delegate void UseServiceDelegate<T>(T proxy);

  public static class Service<T>
  {
    public static ChannelFactory<T> ChannelFactory { get; private set; }
    private static string EndpointName { get; set; }

    static Service()
    {
      EndpointName = GetEndpointName();
      ChannelFactory = new ChannelFactory<T>(EndpointName);
    }

    public static void Use(UseServiceDelegate<T> codeBlock)
    {
      IClientChannel proxy = (IClientChannel)ChannelFactory.CreateChannel();
      bool success = false;
      try
      {
        codeBlock((T)proxy);
        proxy.Close();
        success = true;
      } 
      finally
      {
        if (!success)
        {
          proxy.Abort();
        }
      }
    }

    private static string GetEndpointName()
    {
      var endpointName = ConfigurationManager.AppSettings[typeof(T).ToString()];
      if (string.IsNullOrEmpty(endpointName))
        throw new ArgumentException(string.Format("The contract for {0} was not defined in the app settings.  Please add {0} in the AppSettings section.", typeof(T).ToString()));

      return endpointName;
    }

  }
}
