using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


using Model;

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
                new DropCreateDatabaseIfModelChanges<DatabaseLayer.Model2>()
                );

            try
            {
                var context = new DatabaseLayer.Model2();

                context.Person.Add(new Model.Person
                {
                    Name = "Villy"
                    ,
                    Surname = "Jørgensen"
                    //, AddressList = new List<Model.Address>
                    //{
                    ,
                    Address =
                        new Model.Address
                        {
                            Attention = "Villy", City = "Hundested", CountryCode = "DK", Email = string.Empty, Name = "Villy", Phone = string.Empty, State = string.Empty, Street1 = "Nordstjernen 9", Street2 = "Torup", Zip = "3390"
                        }
                        //}
                });


                context.Person2.Add(new Person2
                {
                    Name = "Villy",
                    Surname = "Jørgensen"
                    ,
                    Address =
                        new Address
                        {
                            Attention = "",
                            City = "Hundested",
                            CountryCode = "DK",
                            Email = "",
                            Name = "Villy Ib Jørgensen",
                            Phone = "",
                            State = "",
                            Street1 = "Nordstjernen 9",
                            Street2 = "",
                            Zip = "3390"
                        }
                });

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                var t1 = Showlog(ex);
            }
        }
    }
}
