using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirebaseSharp.Portable;
using Newtonsoft.Json;
using ProvenanceWeb.Models;

namespace ProvenanceWeb
{
    public static class Connection
    {
        //, "AIzaSyB0Ifgr059d6xFhGDW26zGWwiImZ3aiwIM"
        private static FirebaseApp Firebase = new FirebaseApp(new Uri("https://project1-9177e.firebaseio.com/"));
        public static IFirebase Data = Firebase.Child("paintings");

        public static void InsertPainting(Painting painting)
        {
            Data.Push(JsonConvert.SerializeObject(painting));
        }

        public static void UpdatePainting(Painting painting)
        {
            Data.Child(painting.ID).Update(JsonConvert.SerializeObject(painting));
        }

        public static void DeletePainting(Painting painting)
        {
            Data.Child(painting.ID).Remove();
        }
    }
}