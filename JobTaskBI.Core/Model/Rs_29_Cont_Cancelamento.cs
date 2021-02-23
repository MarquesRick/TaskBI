using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Rs_29_Cont_Cancelamento
    {

        [_MapperTO("ID_DELEGACAO")]
        public int id_delegacao { get; set; }

        [_MapperTO("DT_CANCELAMENTO")]
        public DateTime dt_cancelamento { get; set; }

        [_MapperTO("NM_PESSOA")]
        public string nm_pessoa { get; set; }

        [_MapperTO("NR_QUANTIDADE")]
        public int nr_quantidade { get; set; }

        [_MapperTO("OBSERVACAO")]
        public string observacao { get; set; }

        [_MapperTO("DATA_LIMITE_CONTRATACAO")]
        public string data_limite_contratacao { get; set; }

        [_MapperTO("NM_TITULO")]
        public string nm_titulo { get; set; }

        [_MapperTO("NM_RAZAO_SOCIAL")]
        public string nm_razao_social { get; set; }

        [_MapperTO("DT_LIMITE_ANALISTA")]
        public string dt_limite_analista { get; set; }

        [_MapperTO("NOME_ANALISTA")]
        public string nome_analista { get; set; }

        [_MapperTO("NM_FILIAL")]
        public string nm_filial { get; set; }

        [_MapperTO("ID_UNIDADE")]
        public int id_unidade { get; set; }

        [_MapperTO("ID_DLG_POSICAO")]
        public int id_dlg_posicao { get; set; }

        [_MapperTO("OBSERVACAO_MOVIMENTACAO")]
        public string observacao_movimentacao { get; set; }

        [_MapperTO("NM_UNIDADE_NEGOCIO")]
        public string nm_unidade_negocio { get; set; }

        [_MapperTO("TAXA")]
        public string taxa { get; set; }

        [_MapperTO("VL_SALARIO")]
        public string vl_salario { get; set; }

        [_MapperTO("OBSERVACAO2")]
        public string observacao2 { get; set; }

        [_MapperTO("NM_MOTIVO")]
        public string nm_motivo { get; set; }

        [_MapperTO("ID_CONTRATO")]
        public string id_contrato { get; set; }

        [_MapperTO("ID_ITEM")]
        public string id_item { get; set; }

        [_MapperTO("ID_LOTACAO")]
        public string id_lotacao { get; set; }

        [_MapperTO("ID_PEP")]
        public string id_pep { get; set; }

        [_MapperTO("DT_POSICAO")]
        public DateTime dt_posicao { get; set; }

        [_MapperTO("TAXA_CANCELAMENTO")]
        public int taxa_cancelamento { get; set; }

        [_MapperTO("CODCLIENTE")]
        public string codcliente { get; set; }

        [_MapperTO("SLA")]
        public int sla { get; set; }

        [_MapperTO("DATA_EXTRACAO")]
        public DateTime data_extracao { get; set; }

    }
}
