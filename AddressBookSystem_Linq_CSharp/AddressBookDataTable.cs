﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookSystem_Linq_CSharp
{
    class AddressBookDataTable
    {
        public readonly DataTable dataTable = new DataTable();
        public DataTable CreateTable(AddressBookModel model)
        {
            var tableColumn1 = new DataColumn("First_Name");
            dataTable.Columns.Add(tableColumn1);
            var tableColumn2 = new DataColumn("Last_Name");
            dataTable.Columns.Add(tableColumn2);
            var tableColumn3 = new DataColumn("Address");
            dataTable.Columns.Add(tableColumn3);
            var tableColumn4 = new DataColumn("City");
            dataTable.Columns.Add(tableColumn4);
            var tableColumn5 = new DataColumn("State");
            dataTable.Columns.Add(tableColumn5);
            var tableColumn6 = new DataColumn("Zip");
            dataTable.Columns.Add(tableColumn6);
            var tableColumn7 = new DataColumn("Phone_Number");
            dataTable.Columns.Add(tableColumn7);
            var tableColumn8 = new DataColumn("Email");
            dataTable.Columns.Add(tableColumn8);
            var tableColumn9 = new DataColumn("BookName");
            dataTable.Columns.Add(tableColumn9);
            var tableColumn10 = new DataColumn("BookType");
            dataTable.Columns.Add(tableColumn10);

            dataTable.Rows.Add("Nijam", "Sayyad", "ShivajiChoak", "Beed", "Maha","123456", "1478523690","nks@gmail.com","address001","family");
            dataTable.Rows.Add("Imran", "Shaikh", "Dighi","Mumbai", "Maha", "415263", "3216547890","imr@gmail.com","address001","family");
            dataTable.Rows.Add("Dipak", "Nagargoje", "Golai","Latur", "Maha", "415789", "9632154870","dipak@gmail.com","address002","friend");
            dataTable.Rows.Add("Mahesh", "Kande", "DangeChoak","Pune", "Maha", "789456", "8529631470","mk@gmail.com","address003","office");
            dataTable.Rows.Add("Vishal", "Karad", "AoneStreet","Banglore", "Karanataka", "569874", "8963254170","vish@gmail.com","address003","office");
            dataTable.Rows.Add("Ganesh", "Jadhav", "firsStreet","Chennai", "Tamil", "526341", "8974563210","gan@gmail.com","address003", "friend");
            dataTable.Rows.Add("Mahesha", "Jadhav", "golai", "Latur", "Maha", "526341", "8974563210", "gan@gmail.com", "address003", "friend");
            dataTable.Rows.Add("Mahesha", "Jadhav", "golai", "Latur", "Maha", "526341", "8974563210", "gan@gmail.com", "address003", "family");
            return dataTable;
        }

        public void AddContact(AddressBookModel model)
        {
            dataTable.Rows.Add(model.First_Name, model.Last_Name, model.Address, model.City,
                model.State, model.Zip, model.Phone_Number , model.Email);
            Console.WriteLine("Contact Added Succesfully...");
        }

        public void EditContact(AddressBookModel model)
        {
            var recordData = dataTable.AsEnumerable().Where(data => data.Field<string>("First_Name") == model.First_Name).First();
            if (recordData != null)
            {
                recordData.SetField("Last_Name", model.Last_Name);
                recordData.SetField("Address", model.Address);
                recordData.SetField("City", model.City);
                recordData.SetField("State", model.State);
                recordData.SetField("Zip", model.Zip);
                recordData.SetField("Phone_Number", model.Phone_Number);
                recordData.SetField("Email", model.Email);
                recordData.SetField("Book_Name", model.BookName);
                recordData.SetField("Book_Type", model.BookType);
            }
        }

        public void DeleteContact(AddressBookModel model)
        {
            var recordData = dataTable.AsEnumerable().Where(data => data.Field<string>("First_Name") == model.First_Name).First();
            if (recordData != null)
            {
                recordData.Delete();
                Console.WriteLine("Contact Deleted Successfully....");
            }
        }

        public void RetrievePersonByUsingState(AddressBookModel model)
        {
            var selectdData = from dataTable in dataTable.AsEnumerable().Where((dataTable => dataTable.Field<string>("State") == model.State)) select dataTable;
            foreach (var table in selectdData.AsEnumerable())
            {
                Console.WriteLine("\nFirstName: " + table.Field<string>("First_Name"));
                Console.WriteLine("LastName: " + table.Field<string>("Last_Name"));
                Console.WriteLine("Address: " + table.Field<string>("Address"));
                Console.WriteLine("City: " + table.Field<string>("City"));
                Console.WriteLine("State: " + table.Field<string>("State"));
                Console.WriteLine("ZipCode: " + table.Field<string>("Zip"));
                Console.WriteLine("PhoneNumber: " + table.Field<string>("Phone_Number"));
                Console.WriteLine("E-mail: " + table.Field<string>("Email"));
                Console.WriteLine("Book_Name: " + table.Field<string>("BookName"));
                Console.WriteLine("Book_Type: " + table.Field<string>("BookType"));

            }
        }

        public void RetrievePersonByUsingCity(AddressBookModel model)
        {
            var selectdData = from dataTable in dataTable.AsEnumerable().Where(dataTable => dataTable.Field<string>("City") == model.City) select dataTable;
            foreach (var table in selectdData.AsEnumerable())
            {
                Console.WriteLine("\nFirstName: " + table.Field<string>("First_Name"));
                Console.WriteLine("LastName: " + table.Field<string>("Last_Name"));
                Console.WriteLine("Address: " + table.Field<string>("Address"));
                Console.WriteLine("City: " + table.Field<string>("City"));
                Console.WriteLine("State: " + table.Field<string>("State"));
                Console.WriteLine("ZipCode: " + table.Field<string>("Zip"));
                Console.WriteLine("PhoneNumber: " + table.Field<string>("Phone_Number"));
                Console.WriteLine("E-mail: " + table.Field<string>("Email"));
                Console.WriteLine("Book_Name: " + table.Field<string>("BookName"));
                Console.WriteLine("Book_Type: " + table.Field<string>("BookType"));
            }
        }
    
        public void Display()
        {
            foreach (var table in dataTable.AsEnumerable())
            {
                Console.WriteLine("\nFirstName: " + table.Field<string>("First_Name"));
                Console.WriteLine("LastName: " + table.Field<string>("Last_Name"));
                Console.WriteLine("Address: " + table.Field<string>("Address"));
                Console.WriteLine("City: " + table.Field<string>("City"));
                Console.WriteLine("State: " + table.Field<string>("State"));
                Console.WriteLine("ZipCode: " + table.Field<string>("Zip"));
                Console.WriteLine("PhoneNumber: " + table.Field<string>("Phone_Number"));
                Console.WriteLine("E-mail: " + table.Field<string>("Email"));
                Console.WriteLine("Book_Name: " + table.Field<string>("BookName"));
                Console.WriteLine("Book_Type: " + table.Field<string>("BookType"));
            }
        }

        public void CountByCityAndState()
        {
            var countByCityAndState = from row in dataTable.AsEnumerable()
                                      group row by new { City = row.Field<string>("City"), State = row.Field<string>("State") } into groups
                                      select new
                                      {
                                          City = groups.Key.City,
                                          State = groups.Key.State,
                                          Count = groups.Count()
                                      };
            foreach (var row in countByCityAndState)
            {
                Console.WriteLine(row.City + "  " + row.State + "--->" + row.Count);
            }
        }

        public void SortContactAlphabeticallyForGivenCity(AddressBookModel model)
        {
            var records = dataTable.AsEnumerable().Where(x => x.Field<string>("City") == model.City).OrderBy(x => x.Field<string>("First_Name")).ThenBy(x => x.Field<string>("Last_Name"));
            foreach (var table in records)
            {
                Console.WriteLine("\nFirstName: " + table.Field<string>("First_Name"));
                Console.WriteLine("LastName: " + table.Field<string>("Last_Name"));
                Console.WriteLine("Address: " + table.Field<string>("Address"));
                Console.WriteLine("City: " + table.Field<string>("City"));
                Console.WriteLine("State: " + table.Field<string>("State"));
                Console.WriteLine("ZipCode: " + table.Field<string>("Zip"));
                Console.WriteLine("PhoneNumber: " + table.Field<string>("Phone_Number"));
                Console.WriteLine("E-mail: " + table.Field<string>("Email"));
                Console.WriteLine("Book_Name: " + table.Field<string>("BookName"));
                Console.WriteLine("Book_Type: " + table.Field<string>("BookType"));
            }
        }
        public void GetCountByAddressBookType()
        {
            var countData = dataTable.AsEnumerable().GroupBy(BookType => BookType.Field<string>("BookType")).
                Select(BookType => new
                {
                    BookType = BookType.Key,
                    BookTypeCount = BookType.Count()
                });
            foreach (var contactlist in countData)
            {
                Console.WriteLine("AddressBook Type =" + contactlist.BookType + " --> " + "AddressBook_Count = " + contactlist.BookTypeCount);
            }
        }
    }
}
