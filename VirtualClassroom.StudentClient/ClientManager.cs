using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualClassroom.StudentClient.StudentServiceReference;

namespace VirtualClassroom.StudentClient
{
    class ClientManager
    {
        private static StudentServiceClient clientInstance;

        public static StudentServiceClient GetClient()
        {
            if(clientInstance == null)
            {
                clientInstance = new StudentServiceClient();
            }

            return clientInstance;
        }

        public static void CloseClient()
        {
            if (clientInstance != null)
            {
                clientInstance.Close();
            }
        }
    }
}
