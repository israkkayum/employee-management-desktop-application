using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.AxHost;

namespace TaskThree
{
    internal class EMPLOYEE
    {
        MY_DB db = new MY_DB();

       public bool insertEmployee(string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee`(`first_name`, `last_name`, `birthdate`, `gender`, `phone`, `address`, `picture`) VALUES (@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic)", db.getConnection);

            // @fn,@ln,@bdt,@gdr,@phn,@adrs,@pic
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value =  fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
         
        // create a function to return a table f student data

        public DataTable getEmployees(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command); 
            DataTable dataTable = new DataTable();  
            adapter.Fill(dataTable);

            return dataTable;
        }

        // update statement 

        public bool updateEmployee(int id, string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `employee` SET `first_name`=@fn,`last_name`=@ln,`birthdate`=@bdt,`gender`=@gdr,`phone`=@phn,`address`=@adrs,`picture`=@pic WHERE `id`=@ID", db.getConnection);

            // @fn,@ln,@bdt,@gdr,@phn,@adrs,@pic
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        // delete statement

        public bool deleteEmployee(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `employee` WHERE `ID`=@employeeID", db.getConnection);

            // @fn,@ln,@bdt,@gdr,@phn,@adrs,@pic
            command.Parameters.Add("@employeeID", MySqlDbType.Int32).Value = id;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
