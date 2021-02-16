using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_LocationsWin.DAL
{
    public class ConnexionEF
    {
        private readonly Multi_LocationsEntities _multiLocationsDb;
        internal Multi_LocationsEntities GetInstanceDb => _multiLocationsDb;

        public ConnexionEF()
        {
            _multiLocationsDb = new Multi_LocationsEntities();
        }

        public int SaveChanges()
        {
            return _multiLocationsDb.SaveChanges();
        }

        public void Connecter()
        {
            try
            {
                if (_multiLocationsDb.Database.Connection.State == ConnectionState.Closed)
                    _multiLocationsDb.Database.Connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception($"Trying to open connection. Error: {ex.Message}", ex);
            }
        }

        public void Deconnecter()
        {
            try
            {
                if (_multiLocationsDb.Database.Connection.State == ConnectionState.Open)
                    _multiLocationsDb.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Trying to close connection. Error: {ex.Message}", ex);
            }
        }
    }
}
