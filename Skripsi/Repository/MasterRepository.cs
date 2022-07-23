using Skripsi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Skripsi.Repository
{
    public class MasterRepository
    {

        private db_conn _conn = new db_conn();

        
        public List<tn_m_area> GetlistArea()
        {

            List<tn_m_area> listArea = new List<tn_m_area>();

            try
            {

                _conn = new db_conn();
                listArea = _conn.tn_m_area.ToList();
            }
            catch (SqlException e)
            {

                Console.WriteLine(e);
                throw;

            }

            return listArea;

        }


  
        public tn_m_area GetDetailArea(int? id)
        {

            tn_m_area area = new tn_m_area();

            try
            {

                _conn = new db_conn();
                area = _conn.tn_m_area.Single(m => m.m_area_id == id);
            }
            catch (SqlException e)
            {

                Console.WriteLine(e);
                throw;

            }

            return area;

        }


       
        public bool SaveArea(tn_m_area area)
        {

            try
            {

                _conn = new db_conn();
                if (area.m_area_id == 0)
                {
                    area.created_date = DateTime.Now;
                    _conn.tn_m_area.Add(area);
                    _conn.SaveChanges();
                }
                else {
                    tn_m_area ar = _conn.tn_m_area.Single(m => m.m_area_id == area.m_area_id);
                    _conn.tn_m_area.Attach(ar);
                    ar.m_area_code = area.m_area_code;
                    ar.m_area_name = area.m_area_name;
                    _conn.SaveChanges();
                }

            }
            catch (SqlException e)
            {

                Console.WriteLine(e);
                return false;
                throw;

            }

            return true;

        }

        public bool DeleteArea(int? id)
        {

            try
            {

                _conn = new db_conn();
                tn_m_area eth = _conn.tn_m_area.Single(m => m.m_area_id == id);
                _conn.tn_m_area.Remove(eth);
                _conn.SaveChanges();

            }
            catch (SqlException e)
            {

                Console.WriteLine(e);
                return false;
                throw;

            }

            return true;

        }
    }
}