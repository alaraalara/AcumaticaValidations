﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AcumaticaValidations
//note: add a helper to create a connection strign with specific format
//add function to create a table if it doesnt exists.
{
    public class Program
    {
        static void Main(string[] args)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();


            //NOTE: Connection string should be added to App.Config file to be able to connect to database!
            Parsing example = new Parsing("name=AcuProx", "name=Validations");
            example.ClearData(true, true, true, true);
            example.ParseAndWriteData();
            
            Console.WriteLine("finished parsing!");

           // Console.WriteLine("odata validations started");
            //example.ValidateOData();
            
            //Console.WriteLine("rest validations started");
           // example.ValidateRestAPI();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
            //20740 milliseconds with addrange method (only in other data) for 100,000 entries 














        }


    }
    }

