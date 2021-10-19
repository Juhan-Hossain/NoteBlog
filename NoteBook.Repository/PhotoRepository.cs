using Dapper;
using Microsoft.Extensions.Configuration;
using NoteBook.Models.Photo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Repository
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly IConfiguration _config;
        private object dataTable;

        public PhotoRepository(IConfiguration config)
        {
            _config = config;
        }
        public async Task<int> DeleteAsync(int photoId)
        {
            int affectedRows = 0;
            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                affectedRows = await connection.ExecuteScalarAsync<int>(
                    "Photo_Delete",new { PhotoId = photoId },commandType:CommandType.StoredProcedure);
            }
            return affectedRows;
        }

        public async Task<List<Photo>> GetAllByUserIdAsync(int applicationUserId)
        {
            throw new NotImplementedException();
        }

        public async Task<Photo> GetAsync(int photoId)
        {
            throw new NotImplementedException();
        }

        public async Task<Photo> InsertAsync(PhotoCreate photoCreate, int applicationUserId)
        {
            throw new NotImplementedException();
        }
    }
}
