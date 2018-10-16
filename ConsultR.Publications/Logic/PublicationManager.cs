namespace ConsultR.Logic
{
    using System.Collections.Generic;

    using ConsultR.Data;
    using ConsultR.Interfaces;

    public class PublicationManager : IPublicationManager
    {
        public IEnumerable<Publication> GetAllPublications()
        {
            return new List<Publication>() {new Publication() {Name = "Test"}};
        }
    }
}