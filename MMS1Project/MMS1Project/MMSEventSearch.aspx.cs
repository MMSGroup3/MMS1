using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;


namespace MMS1Project
{
    public partial class MMSEventSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            string strSearch = txtKeyword.Text.ToString();
            if (strSearch.Length>0)
            {
                
                using (SqlConnection conn = new SqlConnection(strConnectionString))
                {
                    StringBuilder strSQLQuery = new StringBuilder("SELECT [MMSEvents].[ID]");
                    strSQLQuery.Append(",[MMSEvents].[Name]");
                    strSQLQuery.Append(",[MMSEvents].[Description]");
                    strSQLQuery.Append(",[MMSEvents].[Date]");
                    strSQLQuery.Append(",[MMSEvents].[Host]");
                    strSQLQuery.Append(",[Vendor1].[ID] as vendorID");
                    strSQLQuery.Append(",[Vendor1].[VendorType]");
                    strSQLQuery.Append(",[Vendor1].VendorAddress");
                    strSQLQuery.Append(",[Vendor1].URL");
                    strSQLQuery.Append(" FROM [dbo].[MMSEvents], [dbo].Vendor1");
                    strSQLQuery.Append(" where (lower([Name]) like ('%");
                    strSQLQuery.Append(strSearch.ToLower());
                    strSQLQuery.Append("%')");
                    strSQLQuery.Append(" or LOWER([Description]) like ('%");
                    strSQLQuery.Append(strSearch.ToLower());
                    strSQLQuery.Append("%'))");
                    strSQLQuery.Append("and [dbo].[MMSEvents].Host=[dbo].Vendor1.VendorName");
                    SqlCommand cmd = new SqlCommand(strSQLQuery.ToString(), conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet d = new DataSet();
                    da.Fill(d);
 
                    if(rdbSimpleSearch.Checked==true)
                    { 
                    grdEvents.DataSource = d;
                    grdEvents.DataBind();
                    }
                    else
                    {
                        DataTable dt = d.Tables[0];
                        Dictionary<string, string> vendorInformation = new Dictionary<string, string>();
                        foreach(DataRow dr in dt.Rows)
                        {
                            vendorInformation.Add(dr["vendorID"].ToString(), dr["URL"].ToString());
                        }
                        Dictionary<string,double> vendorRanking= MMS1Project.Calculation.CalculateScores(vendorInformation);

                        var items = from pair in vendorRanking
                                    orderby pair.Value descending
                                    select pair;

                        dt.Columns.Add("Rank", typeof(int));
                        int intRank=0;
                        foreach(KeyValuePair<string,double> pair in items)
                        {
                            intRank=intRank+1;
                            DataRow[] dr1 = dt.Select("vendorID =" + pair.Key);
                            
                            dr1[0]["Rank"] = intRank;
                        }

                        grdEvents.DataSource = d;
                        grdEvents.DataBind();
                    }
                }  
      
      
      
      
      
      
  

            }
        }
    }
}