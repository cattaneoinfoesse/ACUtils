﻿using System;
using System.Linq;
using System.Transactions;
using ACUtils;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class SqlDbTest
    {
        private TransactionScope scope;
        private SqlDb db;
        private string CONNECTION_STRING = "Data Source=(local);Initial Catalog=master;Integrated Security=SSPI;";

        [SetUp]
        public void Setup()
        {
            db = new SqlDb(CONNECTION_STRING);
            scope = new TransactionScope();
            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
        }

        [TearDown]
        public void Teardown()
        {
            if (Transaction.Current.TransactionInformation.Status == TransactionStatus.Active)
            {
                scope?.Dispose();
            }
        }

        [Test]
        [TestCase("")]
        [TestCase("1")]
        [TestCase("123")]
        [TestCase("1234")]
        public void TestSelect(string value)
        {
            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
            SqlDb_QueryDataRow.QueryDataRow(
                new System.Data.SqlClient.SqlConnection(CONNECTION_STRING),
                 "SELECT @a AS A",
                "@a".WithValue(value, 3)
            );

            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.Add;
            
            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value, 3)
            );

            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value, 3)
            );

            var expected = value ?? default(string);

            var result = db.QuerySingleValue<string>(
                value == null ? "SELECT NULL AS A" : "SELECT @a AS A",
                "@a".WithValue(value, value?.Length ?? 0)
            );
            Assert.AreEqual(expected, result);
        }


        [TestCase(1)]
        [TestCase(123)]
        [TestCase(1234)]
        [TestCase(null)]
        public void TestSelectInt(int value)
        {
            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
            SqlDb_QueryDataRow.QueryDataRow(
                new System.Data.SqlClient.SqlConnection(CONNECTION_STRING),
                 "SELECT @a AS A",
                "@a".WithValue(value)
            );

            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.Add;

            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value)
            );

            var result = db.QuerySingleValue<int>(
                "SELECT @a AS A",
                "@a".WithValue(value)
            );
            Assert.AreEqual(value, result);
        }


        [Test]
        [TestCase(1)]
        [TestCase(123)]
        [TestCase(1234)]
        [TestCase(null)]
        public void TestSelectNullableInt(int? value)
        {
            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.AddWithKey;
            SqlDb_QueryDataRow.QueryDataRow(
                new System.Data.SqlClient.SqlConnection(CONNECTION_STRING),
                 "SELECT @a AS A",
                "@a".WithValue(value)
            );

            SqlDb.MissingSchemaAction = System.Data.MissingSchemaAction.Add;

            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value)
            );

            db.QueryDataRow(
                "SELECT @a AS A",
                "@a".WithValue(value)
            );

            int? expected = value ?? default(int?);

            var result = db.QuerySingleValue<int?>(
                value == null ? "SELECT NULL AS A" : "SELECT @a AS A",
                "@a".WithValue(value)
            );
            Assert.AreEqual(expected, result);
        }

    }
}
