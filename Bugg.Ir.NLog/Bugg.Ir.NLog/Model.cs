using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugg.Ir.NLog
{
    public class Model
    {
        public static List<Tuple<string, string>> NLogModel = new List<Tuple<string, string>>
        {
            new Tuple<string, string>("MVCAction", "${aspnet-MVC-Action}"),
            new Tuple<string, string>("MVCController", "${aspnet-MVC-Controller}"),
            new Tuple<string, string>("Application", "${aspnet-Application:variable=String}"),
            new Tuple<string, string>("Item", "${aspnet-Item}"),
            new Tuple<string, string>("TraceIdentifier", "${aspnet-TraceIdentifier}"),
            new Tuple<string, string>("Request", "${aspnet-Request}"),
            new Tuple<string, string>("RequestCookie", "${aspnet-Request-Cookie}"),
            new Tuple<string, string>("RequestHost", "${aspnet-Request-Host}"),
            new Tuple<string, string>("RequestMethod", "${aspnet-Request-Method}"),
            new Tuple<string, string>("RequestIP", "${aspnet-Request-IP}"),
            new Tuple<string, string>("RequestQueryString", "${aspnet-Request-QueryString}"),
            new Tuple<string, string>("RequestReferrer", "${aspnet-Request-Referrer}"),
            new Tuple<string, string>("RequestUserAgent", "${aspnet-Request-UserAgent}"),
            new Tuple<string, string>("RequestUrl", "${aspnet-Request-Url}"),
            new Tuple<string, string>("Session", "${aspnet-Session}"),
            new Tuple<string, string>("SessionId", "${aspnet-SessionId}"),
            new Tuple<string, string>("UserIsAuthenticated", "${aspnet-User-isAuthenticated}"),
            new Tuple<string, string>("UserAuthType","${aspnet-User-AuthType}"),
            new Tuple<string, string>("UserIdentity","${aspnet-User-Identity}"),
            new Tuple<string, string>("IISSiteName","${iis-site-name}"),
            new Tuple<string, string>("EventDate","${date}"),
            new Tuple<string, string>("EventLevel","${level}"),
            new Tuple<string, string>("EventMessage","${message}"),
            new Tuple<string, string>("ErrorClass","${event-context:item=error-class}"),
            new Tuple<string, string>("ErrorMethod","${event-context:item=error-method}"),
            new Tuple<string, string>("ErrorMessage","${event-context:item=error-message}"),
            new Tuple<string, string>("InnerErrorMessage","${event-context:item=inner-error-message}"),
            new Tuple<string, string>("Stacktrace","${stacktrace}")
        };
    }
}
