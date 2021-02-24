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
                //Table Connection PostgreSQL

                //A
                #region

                //Activity

                var classeActivity = new Activity();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeActivity.GetType().Name);
                List<Activity> lstActivity = ActivityCommun.GetInstance().Get(new Activity() {  }).ToList();
                //act_id = 984542 

                foreach (var itemActivity in lstActivity)
                {
                    Console.WriteLine(
                         itemActivity.act_id + " | " +
                         itemActivity.act_integrationid + " | " +
                         itemActivity.act_description + " | " +
                         itemActivity.act_active + " | " +
                         itemActivity.aty_id + " | " +
                         itemActivity.med_id + " | " +
                         itemActivity.act_displayorder + " | " 

                        );
                }
                Console.WriteLine(lstActivity.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeActivity.GetType().Name);
                Console.ReadKey();

                //Activitydefault

                var classeActivitydefault = new Activitydefault();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeActivitydefault.GetType().Name);
                List<Activitydefault> lstActivitydefault = ActivitydefaultCommun.GetInstance().Get(new Activitydefault() { }).ToList();

                foreach (var itemActivitydefault in lstActivitydefault)
                {
                    Console.WriteLine(
                         itemActivitydefault.acd_id + " | " +
                         itemActivitydefault.act_id + " | "

                        );
                }
                Console.WriteLine(lstActivitydefault.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeActivitydefault.GetType().Name);
                Console.ReadKey();

                //Activityfield

                var classeActivityfield = new Activityfield();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeActivityfield.GetType().Name);
                List<Activityfield> lstActivityfield = ActivityfieldCommun.GetInstance().Get(new Activityfield() { }).ToList();
                

                foreach (var itemActivityfield in lstActivityfield)
                {
                    Console.WriteLine(
                         itemActivityfield.acf_id + " | " +
                         itemActivityfield.acf_integrationid + " | " +
                         itemActivityfield.acf_description + " | " +
                         itemActivityfield.acf_fieldtype + " | " +
                         itemActivityfield.acf_active + " | " +
                         itemActivityfield.acs_id + " | " +
                         itemActivityfield.acf_displayorder + " | " +
                         itemActivityfield.acf_showwebreport + " | " +
                         itemActivityfield.acf_fieldsize + " | " +
                         itemActivityfield.acf_decimalplaces + " | "

                        );
                }
                Console.WriteLine(lstActivityfield.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeActivityfield.GetType().Name);
                Console.ReadKey();

                //Activityroute

                var classeActivityroute = new Activityroute();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeActivityroute.GetType().Name);
                List<Activityroute> lstActivityroute = ActivityrouteCommun.GetInstance().Get(new Activityroute() { }).ToList();


                foreach (var itemActivityroute in lstActivityroute)
                {
                    Console.WriteLine(
                         itemActivityroute.acr_id + " | " +
                         itemActivityroute.rot_id + " | " +
                         itemActivityroute.act_id + " | " 

                        );
                }
                Console.WriteLine(lstActivityroute.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeActivityroute.GetType().Name);
                Console.ReadKey();

                //Activitysection

                var classeActivitysection = new Activitysection();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeActivitysection.GetType().Name);
                List<Activitysection> lstActivitysection = ActivitysectionCommun.GetInstance().Get(new Activitysection() { }).ToList();


                foreach (var itemActivitysection in lstActivitysection)
                {
                    Console.WriteLine(
                         itemActivitysection.acs_id + " | " +
                         itemActivitysection.acs_integrationid + " | " +
                         itemActivitysection.acs_description + " | " +
                         itemActivitysection.acs_active + " | " +
                         itemActivitysection.act_id + " | " +
                         itemActivitysection.med_id + " | " +
                         itemActivitysection.acs_displayorder + " | "

                        );
                }
                Console.WriteLine(lstActivitysection.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeActivitysection.GetType().Name);
                Console.ReadKey();

                //Activitytype

                var classeActivitytype = new Activitytype();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeActivitytype.GetType().Name);
                List<Activitytype> lstActivitytype = ActivitytypeCommun.GetInstance().Get(new Activitytype() { }).ToList();


                foreach (var itemActivitytype in lstActivitytype)
                {
                    Console.WriteLine(
                         itemActivitytype.aty_id + " | " +
                         itemActivitytype.aty_integrationid + " | " +
                         itemActivitytype.aty_description + " | " +
                         itemActivitytype.aty_active + " | " +
                         itemActivitytype.med_id + " | "

                        );
                }
                Console.WriteLine(lstActivitytype.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeActivitytype.GetType().Name);
                Console.ReadKey();

                //Agent

                var classeAgent = new Agent();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeAgent.GetType().Name);
                List<Agent> lstAgent = AgentCommun.GetInstance().Get(new Agent() { }).ToList();


                foreach (var itemAgent in lstAgent)
                {
                    Console.WriteLine(
                         itemAgent.age_id + " | " +
                         itemAgent.age_integrationid + " | " +
                         itemAgent.age_name + " | " +
                         itemAgent.age_login + " | " +
                         itemAgent.age_observation + " | " +
                         itemAgent.age_country + " | " +
                         itemAgent.age_state + " | " +
                         itemAgent.age_city + " | " +
                         itemAgent.age_neighborhood + " | " +
                         itemAgent.age_street + " | " +
                         itemAgent.age_streetnumber + " | " +
                         itemAgent.age_streetnumbercompl + " | " +
                         itemAgent.age_zipcode + " | " +
                         itemAgent.age_phone + " | " +
                         itemAgent.age_mobilephone + " | " +
                         itemAgent.age_mail + " | " +
                         itemAgent.age_imeilastsync + " | " +
                         itemAgent.age_datehourlastsync + " | " +
                         itemAgent.agg_id + " | " +
                         itemAgent.age_active + " | " +
                         itemAgent.age_mobileversion + " | " +
                         itemAgent.age_lastgeoposition + " | " +
                         itemAgent.med_id + " | " +
                         itemAgent.age_geoposition + " | " +
                         itemAgent.age_batterylevel + " | " +
                         itemAgent.age_mobileplatformtype + " | " +
                         itemAgent.age_mobileplatformversion + " | " +
                         itemAgent.age_ignoreteamfilter + " | " +
                         itemAgent.age_id_insert + " | " +
                         itemAgent.age_datetimeinsert + " | " +
                         itemAgent.age_moduleinsert + " | " +
                         itemAgent.age_id_lastupdate + " | " +
                         itemAgent.age_datetimelastupdate + " | " +
                         itemAgent.age_modulelastupdate + " | " +
                         itemAgent.age_datetimelastgps + " | " +
                         itemAgent.age_customerportfoliofilter + " | " +
                         itemAgent.wkj_id + " | "

                        );
                }
                Console.WriteLine(lstAgent.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeAgent.GetType().Name);
                Console.ReadKey();

                //Agentactivity

                var classeAgentactivity = new Agentactivity();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeAgentactivity.GetType().Name);
                List<Agentactivity> lstAgentactivity = AgentactivityCommun.GetInstance().Get(new Agentactivity() { }).ToList();


                foreach (var itemAgentactivity in lstAgentactivity)
                {
                    Console.WriteLine(
                         itemAgentactivity.aac_id + " | " +
                         itemAgentactivity.age_id + " | " +
                         itemAgentactivity.act_id + " | "

                        );
                }
                Console.WriteLine(lstAgentactivity.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeAgentactivity.GetType().Name);
                Console.ReadKey();

                //Agentactivitystatistics

                var classeAgentactivitystatistics = new Agentactivitystatistics();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeAgentactivitystatistics.GetType().Name);
                List<Agentactivitystatistics> lstAgentactivitystatistics = AgentactivitystatisticsCommun.GetInstance().Get(new Agentactivitystatistics() { }).ToList();


                foreach (var itemAgentactivitystatistics in lstAgentactivitystatistics)
                {
                    Console.WriteLine(
                         itemAgentactivitystatistics.age_id + " | " +
                         itemAgentactivitystatistics.act_id + " | " +
                         itemAgentactivitystatistics.aas_date + " | " +
                         itemAgentactivitystatistics.aas_createdat + " | " +
                         itemAgentactivitystatistics.aas_lastupdate + " | " +
                         itemAgentactivitystatistics.aas_executedtasks + " | " +
                         itemAgentactivitystatistics.aas_executedactivities + " | " +
                         itemAgentactivitystatistics.aas_collectedimages + " | " +
                         itemAgentactivitystatistics.aas_executiontime + " | " +
                         itemAgentactivitystatistics.aas_executedlate + " | " +
                         itemAgentactivitystatistics.aas_executedontime + " | " +
                         itemAgentactivitystatistics.aas_executedearly + " | "

                        );
                }
                Console.WriteLine(lstAgentactivitystatistics.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeAgentactivitystatistics.GetType().Name);
                Console.ReadKey();

                //Agentdailyhours

                var classeAgentdailyhours = new Agentdailyhours();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeAgentdailyhours.GetType().Name);
                List<Agentdailyhours> lstAgentdailyhours = AgentdailyhoursCommun.GetInstance().Get(new Agentdailyhours() { }).ToList();


                foreach (var itemAgentdailyhours in lstAgentdailyhours)
                {
                    Console.WriteLine(
                         itemAgentdailyhours.adh_id + " | " +
                         itemAgentdailyhours.adm_id + " | " +
                         itemAgentdailyhours.adh_seq + " | " +
                         itemAgentdailyhours.adh_initialhour + " | " +
                         itemAgentdailyhours.adh_finalhour + " | " +
                         itemAgentdailyhours.adh_duration + " | " +
                         itemAgentdailyhours.adh_type + " | " +
                         itemAgentdailyhours.adh_description + " | " 

                        );
                }
                Console.WriteLine(lstAgentdailyhours.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeAgentdailyhours.GetType().Name);
                Console.ReadKey();

                //Agentdailyjourney

                var classeAgentdailyjourney = new Agentdailyjourney();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeAgentdailyjourney.GetType().Name);
                List<Agentdailyjourney> lstAgentdailyjourney = AgentdailyjourneyCommun.GetInstance().Get(new Agentdailyjourney() { }).ToList();


                foreach (var itemAgentdailyjourney in lstAgentdailyjourney)
                {
                    Console.WriteLine(
                         itemAgentdailyjourney.adj_id + " | " +
                         itemAgentdailyjourney.adm_id + " | " +
                         itemAgentdailyjourney.adj_totalplannedhours + " | " +
                         itemAgentdailyjourney.adj_totalexecutedhours + " | " +
                         itemAgentdailyjourney.adj_initialhour1 + " | " +
                         itemAgentdailyjourney.adj_finalhour1 + " | " +
                         itemAgentdailyjourney.adj_initialhour2 + " | " +
                         itemAgentdailyjourney.adj_finalhour2 + " | " +
                         itemAgentdailyjourney.adj_initialhour3 + " | " +
                         itemAgentdailyjourney.adj_finalhour3 + " | " +
                         itemAgentdailyjourney.adj_initialhour4 + " | " +
                         itemAgentdailyjourney.adj_finalhour4 + " | " +
                         itemAgentdailyjourney.adj_initialhour5 + " | " +
                         itemAgentdailyjourney.adj_finalhour5 + " | "

                        );
                }
                Console.WriteLine(lstAgentdailyjourney.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeAgentdailyjourney.GetType().Name);
                Console.ReadKey();

                //Agentdailymetrics

                var classeAgentdailymetrics = new Agentdailymetrics();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeAgentdailymetrics.GetType().Name);
                List<Agentdailymetrics> lstAgentdailymetrics = AgentdailymetricsCommun.GetInstance().Get(new Agentdailymetrics() { }).ToList();


                foreach (var itemAgentdailymetrics in lstAgentdailymetrics)
                {
                    Console.WriteLine(
                         itemAgentdailymetrics.adm_id + " | " +
                         itemAgentdailymetrics.age_id + " | " +
                         itemAgentdailymetrics.adm_metricdate + " | " +
                         itemAgentdailymetrics.adm_initialexecutionhour + " | " +
                         itemAgentdailymetrics.adm_finalexecutionhour + " | " +
                         itemAgentdailymetrics.adm_totalexecutedtasktime + " | " +
                         itemAgentdailymetrics.adm_totalunexecutedtasktime + " | " +
                         itemAgentdailymetrics.adm_totalworkedtime + " | " +
                         itemAgentdailymetrics.adm_totalunworkedtime + " | " +
                         itemAgentdailymetrics.adm_totaltraveleddistance + " | " +
                         itemAgentdailymetrics.adm_totalexecutedtasks + " | " +
                         itemAgentdailymetrics.adm_totalnegativestasks + " | " +
                         itemAgentdailymetrics.adm_totalexecutedactivities + " | " +
                         itemAgentdailymetrics.adm_totalplannedtime + " | " +
                         itemAgentdailymetrics.adm_totaljourneytime + " | " +
                         itemAgentdailymetrics.adm_totalperformedtime + " | " +
                         itemAgentdailymetrics.adm_totaldiferencetime + " | " +
                         itemAgentdailymetrics.adm_totalbreaktime + " | " +
                         itemAgentdailymetrics.adm_totalstoppingtime + " | " +
                         itemAgentdailymetrics.adm_totalresttime + " | " +
                         itemAgentdailymetrics.adm_loggedinmobile + " | " +
                         itemAgentdailymetrics.adm_totalscheduledtasks + " | " +
                         itemAgentdailymetrics.adm_totalcanceledtasks + " | " +
                         itemAgentdailymetrics.adm_totalinactivatedtasks + " | " +
                         itemAgentdailymetrics.adm_totalunexecutedtasktimeoptimized + " | " +
                         itemAgentdailymetrics.adm_totaltraveleddistanceoptimized + " | "

                        );
                }
                Console.WriteLine(lstAgentdailymetrics.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeAgentdailymetrics.GetType().Name);
                Console.ReadKey();

                //Agentdailystatistics

                var classeAgentdailystatistics = new Agentdailystatistics();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeAgentdailystatistics.GetType().Name);
                List<Agentdailystatistics> lstAgentdailystatistics = AgentdailystatisticsCommun.GetInstance().Get(new Agentdailystatistics() { }).ToList();


                foreach (var itemAgentdailystatistics in lstAgentdailystatistics)
                {
                    Console.WriteLine(
                         itemAgentdailystatistics.age_id + " | " +
                         itemAgentdailystatistics.ads_date + " | " +
                         itemAgentdailystatistics.ads_executedtasks + " | " +
                         itemAgentdailystatistics.ads_executedactivities + " | " +
                         itemAgentdailystatistics.ads_collectedimages + " | " +
                         itemAgentdailystatistics.ads_executiontime + " | " +
                         itemAgentdailystatistics.ads_delaytime + " | " +
                         itemAgentdailystatistics.ads_executedlate + " | " +
                         itemAgentdailystatistics.ads_executedontime + " | " +
                         itemAgentdailystatistics.ads_executedearly + " | " +
                         itemAgentdailystatistics.ads_firstsincronism + " | " +
                         itemAgentdailystatistics.ads_waittime + " | " +
                         itemAgentdailystatistics.ads_traveltime + " | " +
                         itemAgentdailystatistics.ads_standingtime + " | " +
                         itemAgentdailystatistics.ads_traveldistance + " | " +
                         itemAgentdailystatistics.ads_datatransmitted + " | " +
                         itemAgentdailystatistics.ads_createdat + " | " +
                         itemAgentdailystatistics.ads_lastupdate + " | "

                        );
                }
                Console.WriteLine(lstAgentdailystatistics.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeAgentdailystatistics.GetType().Name);
                Console.ReadKey();

                //Agentgroup

                var classeAgentgroup = new Agentgroup();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeAgentgroup.GetType().Name);
                List<Agentgroup> lstAgentgroup = AgentgroupCommun.GetInstance().Get(new Agentgroup() { }).ToList();


                foreach (var itemAgentgroup in lstAgentgroup)
                {
                    Console.WriteLine(
                         itemAgentgroup.agg_id + " | " +
                         itemAgentgroup.agg_integrationid + " | " +
                         itemAgentgroup.agg_description + " | " +
                         itemAgentgroup.agg_active + " | "

                        );
                }
                Console.WriteLine(lstAgentgroup.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeAgentgroup.GetType().Name);
                Console.ReadKey();

                //Agentroute

                var classeAgentroute = new Agentroute();
                Console.WriteLine("------ Abrindo conexão com a tabela: {0} ------\n\n ", classeAgentroute.GetType().Name);
                List<Agentroute> lstAgentroute = AgentrouteCommun.GetInstance().Get(new Agentroute() { }).ToList();


                foreach (var itemAgentroute in lstAgentroute)
                {
                    Console.WriteLine(
                         itemAgentroute.agr_id + " | " +
                         itemAgentroute.rot_id + " | " +
                         itemAgentroute.age_id + " | " 

                        );
                }
                Console.WriteLine(lstAgentroute.Count);
                Console.WriteLine("\n\n------ Fechando conexão com a tabela: {0} ------ ", classeAgentroute.GetType().Name);
                Console.ReadKey();
                #endregion

                //B
                #region
                #endregion



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
           
        }
    }
}
