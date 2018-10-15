namespace ConsultR.Interfaces
{
    using System.Collections.Generic;

    using ConsultR.Data;

    public interface IPublicationManager
    {
        IEnumerable<Publication> GetAllPublications();
    }
}