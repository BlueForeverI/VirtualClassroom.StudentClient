using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualClassroom.StudentClient.StudentServiceReference;

namespace VirtualClassroom.StudentClient
{
    /// <summary>
    /// Manages connections to the service
    /// </summary>
    class ClientManager
    {
        private static StudentServiceClient clientInstance;

        /// <summary>
        /// Creates a new connection to the service or uses an existing one
        /// </summary>
        /// <returns>A working connection to the service</returns>
        public static StudentServiceClient GetClient()
        {
            if(clientInstance == null)
            {
                clientInstance = new StudentServiceClient();
            }

            return clientInstance;
        }

        /// <summary>
        /// Closes the existing connection to the service
        /// </summary>
        public static void CloseClient()
        {
            if (clientInstance != null)
            {
                clientInstance.Close();
            }
        }
    }
}
