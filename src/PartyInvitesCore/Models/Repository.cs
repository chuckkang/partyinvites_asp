using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvitesCore.Models
{
    public class Repository
    {

        private static List<GuestResponses> responses = new List<GuestResponses>();

        public static IEnumerable<GuestResponses> Responses
        { get
            { return responses; }
        }

        public static void AddResponse(GuestResponses response)
        { responses.Add(response); }
    }
}
