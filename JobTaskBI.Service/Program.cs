using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Model;
using Core.Data;
using Core.DAL;
using System.Linq;

namespace JobTaskBI.Service
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var classe = new Rs_29_Cont_Cancelamento();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------ ", classe.GetType().Name);
                List<Rs_29_Cont_Cancelamento> rs29 = Rs_29_Cont_CancelamentoCommun.GetInstance().Get(new Rs_29_Cont_Cancelamento() { codcliente = "1078" }).ToList();
                foreach (var item in rs29)
                {

                    Console.WriteLine("Codigo cliente: " + item.codcliente + "|" + " Nome filial: " + item.nm_filial);
                }
                Console.WriteLine("\n------ Fechando conexão com a tabela: {0} ------ ", classe.GetType().Name);

                var classeActivity = new Activity();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------ ", classeActivity.GetType().Name);
                List<Activity> lstActivity = ActivityCommun.GetInstance().Get(new Activity() { act_id = 984542 }).ToList();
                foreach (var itemActivity in lstActivity)
                {
                    Console.WriteLine("Act Id: " + itemActivity.act_id + "|" + "Descrição: " + itemActivity.act_description);
                }
                Console.WriteLine("\n------ Fechando conexão com a tabela: {0} ------ ", classeActivity.GetType().Name);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
           
        }
    }
}
