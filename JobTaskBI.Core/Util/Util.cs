using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Core.Model;


namespace Core.Util
{
    public class Util
    {
        /*public List<String> VerificaPermissoes(List<Usuario_Permissao> permissoesId)
        {
            List<String> container = new List<String>();
            String permissoes = "";

            if (permissoesId.Count > 0)
            {
                foreach (var permissao in permissoesId)
                {
                    if (permissao.permissao_id.Equals(1))
                    {
                        permissoes = "ADMIN";
                        container.Add(permissoes);
                    }
                    else if (permissao.permissao_id.Equals(2))
                    {
                        permissoes = "USUARIO";
                        container.Add(permissoes);
                    }
                    else
                    {
                        permissoes = "CLIENTE";
                        container.Add(permissoes);
                    }

                }
            }

            return container;
        }*/

        public static string SemFormatacaoCpf(string Codigo)
        {
            return Codigo.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
        }


        public String SqlIn(string[] vetor)
        {
            String retorno = " IN ('";

            if (vetor.Length > 0)
            {
                foreach (String valor in vetor)
                {
                    retorno += (valor + "','");
                }
            }

            if (retorno.EndsWith(",'"))
                retorno = retorno.Remove(retorno.Length - 2);

            retorno += ") ";

            return retorno;
        }

        public DateTime FirstDayOfMonth(DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }

        public DateTime FirstDayOfYear(DateTime value)
        {
            return new DateTime(value.Year, 1, 1);
        }

        public DateTime FirstMonthOfYear(DateTime value)
        {
            return new DateTime(value.Year, 1, value.Day);
        }

        public int DaysInMonth(DateTime value)
        {
            return DateTime.DaysInMonth(value.Year, value.Month);
        }

        public DateTime LastDayOfMonth(DateTime value)
        {
            return new DateTime(value.Year, value.Month, DaysInMonth(value));
        }

        public DateTime LastDayOfYear(DateTime value)
        {
            return new DateTime(value.Year, 12, DaysInMonth(value));
        }

        public DateTime LastMonthOfYear(DateTime value)
        {
            return new DateTime(value.Year, 12, value.Day);
        }

        public DateTime LastHourOfDay(DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
        }

        public DateTime FirstHourOfDay(DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
        }

        public List<DateTime> ListMonth(DateTime value, int months)
        {
            DateTime p_DataF = value;
            DateTime monthsI = new DateTime(value.AddMonths(-months).Year, value.AddMonths(-months).Month, 1);
            DateTime p_DataI = monthsI;
            List<DateTime> mesesRetornados = new List<DateTime>();
            List<Double> valores = new List<Double>();

            DateTime dataInicial = p_DataI.AddHours(-monthsI.Hour).AddMinutes(-monthsI.Minute);

            while (dataInicial < value)
            {
                mesesRetornados.Add(dataInicial);
                dataInicial = dataInicial.AddMonths(1);
            }

            return mesesRetornados;

        }

        public List<String> ListMonthString(List<DateTime> Month)
        {

            List<string> meses = new List<string>();

            foreach (DateTime item in Month)
            {
                meses.Add(item.ToString("MM/yyyy").ToUpper());
            }

            return meses;

        }

        public List<DateTime> ListYear(DateTime value, int years)
        {
            DateTime yearsI = new DateTime(value.AddYears(-years).Year, 1, 1);
            DateTime p_DataI = yearsI;
            List<DateTime> anosRetornados = new List<DateTime>();
            List<Double> valores = new List<Double>();

            DateTime dataInicial = p_DataI.AddHours(-yearsI.Hour).AddMinutes(-yearsI.Minute);

            while (dataInicial < value)
            {
                anosRetornados.Add(dataInicial);
                dataInicial = dataInicial.AddYears(1);
            }

            return anosRetornados;

        }

        public List<String> ListYearString(List<DateTime> Year)
        {

            List<string> anos = new List<string>();

            foreach (DateTime item in Year)
            {
                anos.Add(item.ToString("yyyy").ToUpper());
            }

            return anos;

        }

        public string ReturnImage(string value)
        {
            if (value == "APROVADO")
            {
                return "<img style='width: 24px; height: 24px' src='/Images/status_A.png' />";
            }
            else if (value == "PENDENTE")
            {
                return "<img style='width: 24px; height: 24px' src='/Images/status_P.png' />";
            }
            else
            {
                return "<img style='width: 24px; height: 24px' src='/Images/status_R.png' />";
            }
        }

        public int ReturnDayOfWeek(DateTime currentDate)
        {
            int dayOfWeek = 1;

            if (currentDate.DayOfWeek.ToString().ToUpper().Equals("SUNDAY"))
                dayOfWeek = 1;
            else if (currentDate.DayOfWeek.ToString().ToUpper().Equals("MONDAY"))
                dayOfWeek = 2;
            else if (currentDate.DayOfWeek.ToString().ToUpper().Equals("TUESDAY"))
                dayOfWeek = 3;
            else if (currentDate.DayOfWeek.ToString().ToUpper().Equals("WEDNESDAY"))
                dayOfWeek = 4;
            else if (currentDate.DayOfWeek.ToString().ToUpper().Equals("THURSDAY"))
                dayOfWeek = 5;
            else if (currentDate.DayOfWeek.ToString().ToUpper().Equals("FRIDAY"))
                dayOfWeek = 6;
            else if (currentDate.DayOfWeek.ToString().ToUpper().Equals("SATURDAY"))
                dayOfWeek = 7;

            return dayOfWeek;
        }

        public string ReturnDayOfWeek(int day)
        {
            string dayOfWeek = "Domingo";

            switch (day)
            {
                case 1:
                    dayOfWeek = "Domingo";
                    break;
                case 2:
                    dayOfWeek = "Segunda-Feira";
                    break;
                case 3:
                    dayOfWeek = "Terça-Feira";
                    break;
                case 4:
                    dayOfWeek = "Quarta-Feira";
                    break;
                case 5:
                    dayOfWeek = "Quinta-Feira";
                    break;
                case 6:
                    dayOfWeek = "Sexta-Feira";
                    break;
                case 7:
                    dayOfWeek = "Sábado";
                    break;
                default:
                    dayOfWeek = "error";
                    break;
            }

            return dayOfWeek;
        }

        public string ReturnMonth(int month)
        {
            CultureInfo culture = new CultureInfo("pt-BR");

            return CapitalizeFirstLetter(culture.DateTimeFormat.GetMonthName(month));
        }

        public string CapitalizeFirstLetter(String value)
        {

            return value.First().ToString().ToUpper() + value.Substring(1);

        }

        public string MinutesToTime(int minutosTotais)
        {
            string horas = "";
            string minutos = "";
            string time = "";

            int horasEmMinutos = minutosTotais / 60;

            #region conversao
            if (horasEmMinutos <= 9)
            {
                horas = "0" + horasEmMinutos.ToString();
            }
            if (horasEmMinutos == 0)
            {
                horas = "0" + horasEmMinutos.ToString();
            }
            if (horasEmMinutos > 9)
            {
                horas = horasEmMinutos.ToString();
            }

            int minutosDeHora = minutosTotais % 60;

            if (minutosDeHora < 10)
            {
                minutos = "0" + minutosDeHora.ToString();
            }
            if (minutosDeHora == 0)
            {
                minutos = "0" + minutosDeHora.ToString();
            }
            if (minutosDeHora >= 10)
            {
                minutos = minutosDeHora.ToString();
            }
            #endregion

            time = horas + ":" + minutos;

            return time;
        }

        public static bool IsEmailValid(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public string getParamValue(string Param, string PClient = null)
        //{
        //    ParametroTO objParametro = new ParametroTO();

        //    objParametro.Param = Param;
        //    objParametro.PClient = PClient;

        //    List<ParametroTO> lstParametro = new List<ParametroTO>();

        //    ParametroBLL objParametroBLL = new ParametroBLL();

        //    lstParametro = objParametroBLL.GetData(objParametro);

        //    if (lstParametro.Any())
        //    {
        //        return lstParametro.First().Value;
        //    }
        //    else return null;
        //}

        //public string getParamValue(string Param)
        //{
        //    return getParamValue(Param, null);
        //}
    }
}
