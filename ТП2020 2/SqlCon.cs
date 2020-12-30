using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ТП2020_2
{
    class SqlCon
    {
		public SqlConnection connection()
		{
			SqlConnection connect = new SqlConnection(@"Data Source = DESKTOP-715RU6Q\SQLEXPRESS; Initial Catalog = Animals; Integrated Security = True");
			connect.Open();
			return connect;
		}
	}
}
