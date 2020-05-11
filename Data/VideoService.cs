using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCRUD.Data
{
    public class VideoService : IVideoService
    {
        //Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public VideoService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        //Add video table row
        public async Task<bool> VideoInsert(Video video)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("title", video.title, DbType.String);
                parameters.Add("datePublished", video.datePublished, DbType.Date);
                parameters.Add("isActive", video.isActive, DbType.Boolean);

                //Raw SQL method
                const string query = @"INSERT INTO tblVideo(title, datePublished, isActive)VALUES(@title, @datePublished, @isActive)";
                await conn.ExecuteAsync(query, new { video.title, video.datePublished, video.isActive }, commandType: CommandType.Text);
            }

            return true;
        }

        public async Task<IEnumerable<Video>> VideoList()
        {
            IEnumerable<Video> videos;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = @"SELECT * FROM tblVideo";
                videos = await conn.QueryAsync<Video>(query, commandType: CommandType.Text);
            }

            return videos;
        }

        //This to get video ID
        public async Task<Video> Video_GetOne(int id)
        {
            Video video = new Video();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                video = await conn.QueryFirstOrDefaultAsync<Video>("spVideo_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return video;
        }

        //Update video
        public async Task<bool> VideoUpdate(Video video)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("videoId", video.videoId, DbType.Int32);
                parameters.Add("title", video.title, DbType.String);
                parameters.Add("datePublished", video.datePublished, DbType.Date);
                parameters.Add("isActive", video.isActive, DbType.Boolean);

                //Raw SQL method
                const string query = @"UPDATE tblVideo SET title=@title, datePublished=@datePublished, isActive=@isActive WHERE videoId=@videoId";
                await conn.ExecuteAsync(query, new { video.title, video.datePublished, video.isActive }, commandType: CommandType.Text);
            }

            return true;
        }
    }
}
