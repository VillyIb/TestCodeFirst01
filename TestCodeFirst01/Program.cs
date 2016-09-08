using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using Model.Pickup;

namespace TestCodeFirst01
{
    public class Program
    {
        private static string Showlog(SqlError ex)
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - ", ex.LineNumber, ex.Message, ex.Number, ex.Procedure, ex.Server, ex.Source);
        }


        private static string Showlog(SqlErrorCollection ex)
        {
            var result = new StringBuilder();

            foreach (var current in ex)
            {
                var t1 = current as SqlError;
                if (t1 != null)
                {
                    result.Append(Showlog(t1));
                }
            }

            return result.ToString();
        }


        private static string Showlog(SqlException ex)
        {
            var result = string.Format(
                "{0} -  {1} \r\n "
                , ex.Message
                , ex.ErrorCode
                );

            result += Showlog(ex.Errors);

            return result;
        }


        private static string Showlog(DbEntityValidationException ex)
        {
            var result = string.Format(
                "{0} - {1} - {2} - "
                , ex.HelpLink
                , ex.Message
                , ex.Source
                );

            result += Showlog(ex.InnerException);

            return result;
        }


        //DbEntitiyValidationResult

        private static string Showlog(DbValidationError ex)
        {
            var result = string.Format("\r\n    {0} - {1}", ex.ErrorMessage, ex.PropertyName);

            return result;
        }


        private static string Showlog(ICollection<DbValidationError> ex)
        {
            var result = new StringBuilder();

            foreach (var current in ex)
            {
                result.Append(Showlog(current));
            }

            return result.ToString();
        }


        private static string Showlog(DbEntityValidationResult ex)
        {
            var result = string.Format("{0} - {1}", ex.Entry, ex.IsValid);

            result += Showlog(ex.ValidationErrors);

            return result;
        }


        private static string Showlog(IEnumerable<DbEntityValidationResult> ex)
        {
            var result = new StringBuilder();

            foreach (var current in ex)
            {
                result.Append(Showlog(current));
            }

            return result.ToString();
        }




        private static string Showlog(Exception ex)
        {
            if (ex == null) return "";

            {
                var exx = ex as DbEntityValidationException;
                if (exx != null)
                {
                    var result = string.Format(
                        "{0} - "
                        , Showlog(exx)
                        );

                    result += Showlog(exx.EntityValidationErrors);

                    result += Showlog(exx.InnerException);

                    return result;
                }
            }

            {
                var exx = ex as SqlException;
                if (exx != null)
                {
                    var result = string.Format(
                        "{0} - "
                        , Showlog(exx)
                        );

                    result += Showlog(exx.InnerException);

                    return result;
                }
            }

            //{
            //    var exx = ex as DbEntityValidationException;
            //    if (exx != null)
            //    {
            //        return Showlog(exx);
            //    }
            //}

            return string.Format("{2} - {0} \r\n{1}", ex.Message, Showlog(ex.InnerException), ex.GetType());
        }




        static void Main(string[] args)
        {

            Database.SetInitializer(
                //new DropCreateDatabaseIfModelChanges<DatabaseLayer.PickupV2.PickupContext>()
                new DropCreateDatabaseAlways<DatabaseLayer.Context.ContextSharedPickup>()
                );

            SqlConnectionStringBuilder connectionBuilder;

            if (bool.Parse("true"))
            {
                var localDb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Villy-T400\Documents\TestCodeFirst01.mdf;Integrated Security=True;Connect Timeout=30";
                connectionBuilder = new SqlConnectionStringBuilder(localDb);
            }
            else
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Model2"];
                connectionBuilder = new SqlConnectionStringBuilder(connectionString.ConnectionString);
            }

            var physicalFile = connectionBuilder.AttachDBFilename;


            try
            {

                if (bool.Parse("false"))
                // Optionally provide usename - password
                {
                    connectionBuilder.Password = "xxx";
                    connectionBuilder.UserID = "yyy";
                }


                using (var contextSharedPickup = new DatabaseLayer.Context.ContextSharedPickup(connectionBuilder))
                using (var contextMainPickup = new DatabaseLayer.Context.ContextMainPickup(connectionBuilder))
                {

                    //context.Shipment.Add(new Model.Pickup.Shipment
                    //{
                    //    Address = new Model.Pickup.Address
                    //    {
                    //        Attention = "att",
                    //        City = "cit",
                    //        CountryCode = "DK",
                    //        Email = "ema",
                    //        //HashCode
                    //        Name = "nam",
                    //        Phone = "phon",
                    //        State = "na",
                    //        Street1 = "Str1",
                    //        Street2 = "str2",
                    //        Zip = "zip"
                    //    },
                    //    BranchId = 0,
                    //    CarrierId = 0,
                    //    CarrierName = "cna",
                    //    CustomerAccountId = 0,
                    //    CustomerId = 0,
                    //    CustomerPickupId = 0,
                    //    DispositionSettingId = 0,
                    //    DryiceWeight = 0m,
                    //    Forwarder1PickupId = 0,
                    //    Forwarder2PickupId = 0,
                    //    Forwarder2WebsiteId = Guid.Empty,
                    //    ForwarderName = "fwn",
                    //    GroupIndex = 0,
                    //    Id = 0,
                    //    IsDeleted = false,
                    //    IsLocked = false,
                    //    SalesProductId = 0,
                    //    ShipmentDate = DateTime.Now.Date,
                    //    SourceShipmentId = 0,
                    //    TansportProductId = 0,
                    //    TimestampCreate = DateTime.Now,
                    //    TimestampUpdate = DateTime.Now,
                    //    UniqueSequence = 0,
                    //    WaybillNumber = "wbn",
                    //    WebsiteId = Guid.Empty,
                    //    WebsiteIdHash = 0,
                    //    Weight = 0m                        
                    //});

                    contextSharedPickup.CustomerPickup.Add(
                        new Model.Pickup.CustomerPickup
                        {
                            Address = new Address
                            {
                                Attention = "att",
                                City = "cit",
                                CountryCode = "DK",
                                Email = "ema",
                                //HashCode
                                Name = "nam",
                                Phone = "phon",
                                State = "na",
                                Street1 = "Str1",
                                Street2 = "str2",
                                Zip = "zip"
                            },
                            BranchId = 0,
                            CustomerId = 0,
                            Note = "not",
                            SpecialTreatment = "spt",
                            PickupStatusString = Model.Pickup.PickupStatusCustomer.CustWait.ToString("G"),
                            PickupStatus = Model.Pickup.PickupStatusCustomer.CustWait,
                            PickupDate = DateTime.Today,
                            TimestampUpdate = DateTime.Now,
                            WebsiteId = Guid.Empty,
                            ShipmentList = new List<Shipment>
                            {
                                new Shipment
                                {
                                Address = new Address
                                {
                                    Attention = "att",
                                    City = "cit",
                                    CountryCode = "DK",
                                    Email = "ema",
                                    //HashCode
                                    Name = "nam",
                                    Phone = "phon",
                                    State = "na",
                                    Street1 = "Str1",
                                    Street2 = "str2",
                                    Zip = "zip"
                                },
                                GroupIndex = 0,
                                CarrierId =   0,
                                CustomerId = 0,
                                SalesProductId = 0,
                                BranchId = 0,
                                CarrierName = "DHL",
                                CustomerAccountId = 0,
                                //CustomerPickupId = 0,
                                DispositionSettingId = 0,
                                DryiceWeight = 0m,
                                Forwarder1PickupId = 0,
                                ForwarderName = "gls",
                                WaybillNumber = "12345",
                                ShipmentDate = DateTime.Now.Date,
                                TimestampCreate = DateTime.Now,
                                TimestampUpdate = DateTime.Now,
                                WebsiteId = Guid.Empty,
                                }
                            }
                        }
                    );

                    contextSharedPickup.SaveChanges();

                    contextMainPickup.DispositionSettings.Add(
                        new DispositionSettings
                        {
                            AccountId = "*",
                            CarrierId = "*",
                            CustomerId = "1277",
                            SalesProductId = "*",

                            PickupOperator = PickupOperator.DHL,
                            EnabledForPickup = true,
                            PickupStatus = PickupStatusCustomer.CustWait,
                            PreallocatePickup = true,

                            DispositionCode = "Forwarder1",
                            TimeClose = new TimeSpan(16, 0, 0),
                            TimeReady = new TimeSpan(12, 0, 0),

                            Text = "Test",
                        });
                    contextMainPickup.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                var t1 = Showlog(ex);
            }

            using (var context = new DatabaseLayer.Context.ContextSharedPickup(connectionBuilder))
            {

                //var objContext = ((IObjectContextAdapter)context).ObjectContext;

                //objContext.MetadataWorkspace.

                var t1 = context.CustomerPickup.First();

                var t2 = context.Entry(t1);

                //t2.State = EntityState.Unchanged;
                var t3 = t2.State;

                //t1.CarrierId = 100;

                t1.PickupStatus = Model.Pickup.PickupStatusCustomer.ForwWait;

                t2 = context.Entry(t1); // must be reloaded in order to reflect state.

                context.SaveChanges();
            }

            // Observations:
            // A property in class but not saved in the database does not flip State (modified) when updated.
            // It looks like the "State" is determined by comparing the "CurrentValues" value with the "OriginalValues"
            // -> Property Mapping (E.G. Enum to String) doesn't matter if the saved property reads from the mapped property or reverse

        }
    }
}
