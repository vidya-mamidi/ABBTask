using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABBTask.Shared;
using  ABBTask.Model;

namespace ABBTask.Data
{
    public interface IAlbumServices
    {
        Task<List<Album>> GetAlbums();
    }
}
