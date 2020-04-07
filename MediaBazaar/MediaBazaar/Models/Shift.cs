using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    public class Shift : Model
    {
        protected long id;
        private long workerId;
        private Workshift shift;
        private DateTime date;
        public long Id { get => id; }
        public long WorkerId { get => workerId; }
        public Workshift SelectedShift { get => shift; }
        public DateTime Date { get => date; }
        public Shift(long workerId, Workshift shift, DateTime date)
        {
            this.workerId = workerId;
            this.shift = shift;
            this.date = date;
        }
        public override void Insert()
        {
            dbConnection.OpenConnection();
            string query = @"INSERT INTO work_shifts(worker_id,shift,date) 
                    SELECT @workerId,@shift,@date FROM DUAL
                    WHERE NOT EXISTS (SELECT * FROM work_shifts
                    WHERE worker_id = @workerId AND shift=@shift AND date=@date LIMIT 1);";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                
                cmd.Parameters.AddWithValue("@workerId", this.workerId);
                cmd.Parameters.AddWithValue("@shift", this.shift.ToString());
                cmd.Parameters.AddWithValue("@date", this.date.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
            }

            dbConnection.CloseConnection();
        }

        public override void Update(Model obj)
        {

        }

        public override void Delete()
        {

        }
    }
}
