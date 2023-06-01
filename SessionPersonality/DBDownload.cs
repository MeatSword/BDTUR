using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SessionPersonality
{
    public class DBDownload
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["TurBase"].ConnectionString;
        SqlConnection conn;
        
        public DBDownload()
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }

        public List<int> idTour = new List<int>();
        public List<int> idCityT = new List<int>();
        public List<int> costTour = new List<int>();
        public List<DateTime> ariveTour = new List<DateTime>();
        public List<DateTime> departTour = new List<DateTime>();
        public List<int> idHotelT = new List<int>();

        public List<int> idHotel = new List<int>();
        public List<int> rateHotel = new List<int>();
        public List<string> servicesHotel = new List<string>();
        public List<int> nutrHotel = new List<int>();
        public List<string> nameHotel = new List<string>();
        public List<string> imgHotel = new List<string>();

        public List<int> idUser = new List<int>();
        public List<int> category = new List<int>();

        public List<string> nameAct = new List<string>();
        public List<double> CategoryAct = new List<double>();
        public List<int> ValueDisc= new List<int>();
        public List<string> Ways = new List<string>();
        public List<bool> IsSumm = new List<bool>();
        public List<string> Type = new List<string>();

        public List<int> CityId = new List<int>();
        public List<string> NameCity = new List<string>();
        public List<int> CntIdC = new List<int>();
        
        public List<int> CountryId = new List<int>();
        public List<string> NameCnt = new List<string>();

        public List<int> ServiceId = new List<int>();
        public List<string> NameServ = new List<string>();

        private SqlDataReader rd;

        public void Services()
        {
            ServiceId.Clear();
            NameServ.Clear();

            SqlCommand com = new SqlCommand("SELECT * FROM Services", conn);
            rd = com.ExecuteReader();

            while (rd.Read())
            {
                ServiceId.Add(Convert.ToInt32(rd.GetValue(0)));
                NameServ.Add(rd.GetValue(1).ToString());
            }
        }
        
        public void Tour()
        {
            idTour.Clear();
            costTour.Clear();
            ariveTour.Clear();
            departTour.Clear();
            idHotelT.Clear();
            
            SqlCommand com = new SqlCommand("SELECT * FROM Tour",conn);
            rd = com.ExecuteReader();

            while (rd.Read())
            {
                idTour.Add(Convert.ToInt32(rd.GetValue(0)));
                idCityT.Add(Convert.ToInt32(rd.GetValue(1)));
                costTour.Add(Convert.ToInt32(rd.GetValue(2)));
                ariveTour.Add(Convert.ToDateTime(rd.GetValue(3)));
                departTour.Add(Convert.ToDateTime(rd.GetValue(4)));
                idHotelT.Add(Convert.ToInt32(rd.GetValue(5)));
            }
            rd.Close();
        }

        public void Country()
        {
            CountryId.Clear();
            NameCnt.Clear();
            SqlCommand com = new SqlCommand("SELECT * FROM Country",conn);
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                CountryId.Add(Convert.ToInt32(rd.GetValue(0)));
                NameCnt.Add(rd.GetValue(1).ToString());
            }
            rd.Close();
           
        }

        public void User()
        {
            SqlCommand com = new SqlCommand("SELECT * FROM Users WHERE status ='user'",conn);
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                int order = Convert.ToInt32(rd.GetValue(3));
                idUser.Add(Convert.ToInt32(rd.GetValue(0)));
                if (order<500000)
                {
                    category.Add(0);
                }
                if (order>=500000 && order<1500000)
                {
                    category.Add(1);
                }
                if (order>=1500000 && order<5000000)
                {
                    category.Add(2);
                }
                if (order>=5000000)
                {
                    category.Add(3);
                }
               
               
            }
            rd.Close();
        }

        public void City()
        {
            CityId.Clear();
            NameCity.Clear();
            CntIdC.Clear();
            SqlCommand com= new SqlCommand("SELECT cityid,cityname,idCountry FROM City",conn);
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                CityId.Add(Convert.ToInt32(rd.GetValue(0)));
                NameCity.Add(rd.GetValue(1).ToString());
                CntIdC.Add(Convert.ToInt32(rd.GetValue(2)));
            }
            rd.Close();
        }

        public void Actions()
        {
            SqlCommand com = new SqlCommand("SELECT * FROM Actions",conn);
            rd = com.ExecuteReader();   
            while (rd.Read())
            {
                nameAct.Add(rd.GetValue(1).ToString());
                CategoryAct.Add(Convert.ToInt32(rd.GetValue(3)));
                ValueDisc.Add(Convert.ToInt32(rd.GetValue(4)));
                Ways.Add(rd.GetValue(8).ToString());
                IsSumm.Add(Convert.ToBoolean(rd.GetValue(7)));
                Type.Add(rd.GetValue(5).ToString());
            }
            rd.Close();
        }

        

        

        public void Hotel()
        {
            idHotel.Clear();
            rateHotel.Clear();
            servicesHotel.Clear();
            nutrHotel.Clear();
            nameHotel.Clear();
            
            SqlCommand com = new SqlCommand("SELECT * FROM Hotel",conn);
            rd = com.ExecuteReader();

            while (rd.Read())
            {
                idHotel.Add(Convert.ToInt32(rd.GetValue(0)));
                nameHotel.Add(rd.GetValue(1).ToString());
                rateHotel.Add(Convert.ToInt32(rd.GetValue(2)));
                servicesHotel.Add(rd.GetValue(3).ToString());
                nutrHotel.Add(Convert.ToInt32(rd.GetValue(4)));
                imgHotel.Add(rd.GetValue(5).ToString());
            }
            rd.Close();
        }
    }
}