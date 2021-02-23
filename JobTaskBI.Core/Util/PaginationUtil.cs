using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Util
{
    public class PaginationUtil
    {
        public long NumPagina { get; set; }
        public long TotalPaginas { get; set; }

        public PaginationButton botaoAnterior = new PaginationButton();
        public PaginationButton botaoSeguinte = new PaginationButton();
        public PaginationButton botao1 = new PaginationButton();
        public PaginationButton botao2 = new PaginationButton();
        public PaginationButton botao3 = new PaginationButton();
        public PaginationButton botao4 = new PaginationButton();
        public PaginationButton botao5 = new PaginationButton();

        public PaginationUtil()
        {

        }
    }

    public class PaginationButton
    {
        public long value { get; set; }
        public string cssClassHide { get; set; }
        public string cssClassActive { get; set; }
        public string cssClassDisabled { get; set; }
    }

    public class PaginationTh
    {
        public string orderBy { get; set; }
        public bool orderThis { get; set; }
        public string orderClass { get; set; }
    }

    public class PaginationFunctions
    {
        #region Singleton

        private static PaginationFunctions _instance = null;

        public PaginationFunctions()
        {
        }

        public static PaginationFunctions GetInstance()
        {
            if (_instance == null)
                _instance = new PaginationFunctions();

            return _instance;
        }

        #endregion

        public PaginationUtil GeneratePagination(long NumPagina, long TotalPaginas)
        {
            PaginationUtil retorno = new PaginationUtil();

            retorno.botaoAnterior.value = (NumPagina > 1) ? NumPagina - 1 : NumPagina;
            if (NumPagina == 1)
            {
                retorno.botaoAnterior.cssClassDisabled = "disabled";
            }

            retorno.botaoSeguinte.value = (TotalPaginas > NumPagina) ? NumPagina + 1 : NumPagina;
            if (NumPagina == TotalPaginas)
            {
                retorno.botaoSeguinte.cssClassDisabled = "disabled";
            }

            if (NumPagina <= 3)
            {
                retorno.botao1.value = 1;
                retorno.botao2.value = 2;
                retorno.botao3.value = 3;
                retorno.botao4.value = 4;
                retorno.botao5.value = 5;

                if (NumPagina == 1)
                    retorno.botao1.cssClassActive = "active";
                if (NumPagina == 2)
                    retorno.botao2.cssClassActive = "active";
                if (NumPagina == 3)
                    retorno.botao3.cssClassActive = "active";
            }
            else
            {
                if (NumPagina >= TotalPaginas - 2)
                {

                    if (TotalPaginas <= 5)
                    {
                        retorno.botao1.value = 1;
                        retorno.botao2.value = 2;
                        retorno.botao3.value = 3;
                        retorno.botao4.value = 4;
                        retorno.botao5.value = 5;

                        if (NumPagina == 4)
                            retorno.botao4.cssClassActive = "active";
                        if (NumPagina == 5)
                            retorno.botao5.cssClassActive = "active";

                    }
                    else
                    {
                        retorno.botao1.value = TotalPaginas - 4;
                        retorno.botao2.value = TotalPaginas - 3;
                        retorno.botao3.value = TotalPaginas - 2;
                        retorno.botao4.value = TotalPaginas - 1;
                        retorno.botao5.value = TotalPaginas;

                        if (NumPagina == TotalPaginas - 2)
                            retorno.botao3.cssClassActive = "active";
                        if (NumPagina == TotalPaginas - 1)
                            retorno.botao4.cssClassActive = "active";
                        if (NumPagina == TotalPaginas)
                            retorno.botao5.cssClassActive = "active";
                    }
                }
                else
                {
                    if (TotalPaginas <= 5)
                    {

                    }
                    else
                    {
                        retorno.botao1.value = NumPagina - 2;
                        retorno.botao2.value = NumPagina - 1;
                        retorno.botao3.value = NumPagina;
                        retorno.botao4.value = NumPagina + 1;
                        retorno.botao5.value = NumPagina + 2;

                        retorno.botao3.cssClassActive = "active";
                    }
                }
            }

            if (TotalPaginas <= 4)
            {
                if (TotalPaginas < 5)
                    retorno.botao5.cssClassHide = "displayNone";
                if (TotalPaginas < 4)
                    retorno.botao4.cssClassHide = "displayNone";
                if (TotalPaginas < 3)
                    retorno.botao3.cssClassHide = "displayNone";
                if (TotalPaginas < 2)
                    retorno.botao2.cssClassHide = "displayNone";

            }

            return retorno;
        }

        public PaginationTh GenerateTh(string id, string ordenacao)
        {
            PaginationTh retorno = new PaginationTh();

            retorno.orderThis = ordenacao.Contains(id);
            retorno.orderBy = retorno.orderThis ? (ordenacao.Equals(id + " DESC") ? id + " ASC" : id + " DESC") : id + " ASC";
            retorno.orderClass = retorno.orderThis ? (ordenacao.EndsWith("DESC") ? "sorting_desc" : "sorting_asc") : "sorting";

            return retorno;
        }
    }
    
}
