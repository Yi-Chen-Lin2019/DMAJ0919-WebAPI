using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class CoronaOperations
    {
        private readonly IDbConnection _db;

        public CoronaOperations()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
        public List<Datum> GetTheRecords(int number, string sort)
        {
            return this._db.Query<Datum>
             ("SELECT TOP 100 [CountryCode], [Date], [Cases], [Deaths], [Recovered] FROM [Datum] ORDER BY [CountryCode]" + sort).ToList();

        }

        public bool InsertRecord(Datum datum)
        {
            int rowAffected = this._db.Execute(@"INSERT Datum ( [CountryCode], [Date], [Cases], [Deaths], [Recovered]) values (@CountryCode, @Date, @Cases, @Deaths, @Recovered)",
                 new { CountryCode = datum.countrycode , Date = datum.date, Cases = datum.cases, Deaths = datum.deaths, Recovered = datum.recovered });

            if (rowAffected > 0) { return true; }
            return false;
        }
    }
}