using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    public class WorkShift : Model
    {
        protected long id;
        private long workerId;
        private Shift shift;
        private DateTime date;
        private decimal wage;
        private int workersNeeded;

        public long Id { get => id; }
        public decimal Wage { get => wage; }
        public int WorkersNeeded { get => workersNeeded; }
        public Shift SelectedShift { get => shift; }
        public DateTime Date { get => date; }
        public WorkShift(Shift shift, DateTime date, decimal wage, int workersNeeded)
        {
            this.shift = shift;
            this.date = date;
            this.wage = wage;
            this.workersNeeded = workersNeeded;
        }

        public override void Insert()
        {
            dbConnection.OpenConnection();
            string query = @"
                    INSERT INTO work_shifts (shift, date, wage, workers_needed, created_at, updated_at) 
                    SELECT @shift, @date, @wage, @workers_needed, NOW(), NOW() FROM DUAL
                    WHERE NOT EXISTS (
                        SELECT * FROM work_shifts 
                        WHERE shift = @shift 
                        AND date = @date 
                        LIMIT 1
                    );
            ";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.connection))
            {
                cmd.Parameters.AddWithValue("@shift", this.shift.ToString());
                cmd.Parameters.AddWithValue("@date", this.date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@wage", this.wage.ToString());
                cmd.Parameters.AddWithValue("@workers_needed", this.workersNeeded.ToString());
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
