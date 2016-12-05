using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using HappyTechSystem;

namespace HappyTechSystem.DB
{
    class DBFactory
    {
        private static DbConnection m_instance = null;

        Dictionary<string, string> m_properties;
        private static string propfile = Environment.CurrentDirectory + "/DataBase/"+ "properties.dat";

        private DBFactory()
        {
            m_properties = new Dictionary<string, string>();
        }
        public static DbConnection instance()
        {
            if (null == m_instance)
            {
                DBFactory factory = new DBFactory();
                m_instance = factory.getConection();
            }
            return m_instance;
        }
        private DbConnection getConection()
        {
            DbConnection connection = null;

            try
            {
                m_properties = getProperties();
                string provider = m_properties["Provider"];

                if (provider.Equals("Microsoft.ACE.OLEDB.15.0"))
                    connection = new OLEDBConnection(m_properties);
                else
                {
                    // should throw unsupport exception here
                    throw new DBException("Not supported provider '" + provider + "'");
                }
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine("Error file not found" + e.Message);
                connection = null;
                throw e;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Property file parsing exception thrown : " + e.Message);
                connection = null;
                throw e;
            }
            return connection;
        }

        private Dictionary<string, string> getProperties()
        {
            string fileData = "";
            using (StreamReader sr = new StreamReader(propfile))
            {
                fileData = sr.ReadToEnd().Replace("\r", "");
            }
            Dictionary<string, string> properties = new Dictionary<string, string>();
            string[] kvp;
            string[] records = fileData.Split("\n".ToCharArray());
            foreach (string record in records)
            {
                kvp = record.Split("=".ToCharArray());
                properties.Add(kvp[0], kvp[1]);
            }
            return properties;
        }
    }
    class DBException : System.Exception
    {
        public DBException(string message) : base(message) { }
    }

    public interface DbConnection
    {
        bool OpenConnection();

        bool CloseConnection();

        int RunSQL(string sqlStatement, params KeyValuePair<string, object>[] args);
        /*
        //Insert statement
        public void Insert(); 
        //Update statement
        public void Update();
        //Delete statement
        public void Delete();
        */


        //Select statement
        DbDataReader Select(String query);
        /*
        //Count statement
        public int Count();
        public void Backup();
        public void Restore();
       
        */

        DataSet getDataSet(string sqlStatement);

    }
}

