using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALvideo
    {
        DatabaseAccessLayer db;

        public DALvideo(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM video";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(video _video)
        {
            string query = "INSERT INTO `video`( `url`, `type`) VALUES ('"+_video.Url+"', '"+_video.Type+"')";
            return db.ExecuteNonQuery(query);
        }
        public bool update(video _video)
        {
            string query = "UPDATE `video` SET `url`='"+_video.Url+"',`type`='"+_video.Type+"' WHERE id = "+_video.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `video` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
