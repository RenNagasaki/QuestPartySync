using System.Collections.Generic;
using System.Numerics;

namespace Echosync.DataClasses
{
    public static class Constants
    {
        public static readonly Vector4 INFOLOGCOLOR = new Vector4(.3f, 1.0f, 1.0f, 1f);
        public static readonly Vector4 DEBUGLOGCOLOR = new Vector4(0.0f, 1.0f, 0.0f, 1f);
        public static readonly Vector4 ERRORLOGCOLOR = new Vector4(1.0f, 0.0f, 0.0f, 1f);
        public static string RabbitMQConnectionUrl = "https://echosync.echotools.cloud";
        public static string RabbitMQUserName = "Echosync-User";
        public static string RabbitMQPassword = "1234432112344321";
    }
}
