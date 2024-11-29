using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALimage
    {
        DatabaseAccessLayer db;

        public DALimage(string connectionString)
        {
            db = new DatabaseAccessLayer(connectionString);
        }
        public DataTable load()
        {
            string query = "SELECT * FROM image";
            DataTable dt = new DataTable();
            dt = db.ExecuteQuery(query);
            return dt;
        }
        public bool insert(image _image)
        {
            string query = "INSERT INTO `image`(`title`, `url`, `enable`, `type`, `product_id`) " +
                "VALUES (N'"+_image.Title+"', '"+_image.Url+"',"+_image.Enable+" , '"+_image.Type+"', "+_image.Product_id+")";
            return db.ExecuteNonQuery(query);
        }
        public bool update(image _image)
        {
            string query = "UPDATE `image` " +
                "SET `title`='"+_image.Title+"',`url`='"+_image.Url+"',`enable`="+_image.Enable+",`type`='"+_image.Type+"',`product_id`="+_image.Product_id+" " +
                "WHERE `id`="+_image.Id;
            return db.ExecuteNonQuery(query);
        }
        public bool delete(int id)
        {
            string query = "DELETE FROM `image` WHERE id = "+id;
            return db.ExecuteNonQuery(query);
        }
    }
}
