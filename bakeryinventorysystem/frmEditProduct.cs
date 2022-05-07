using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryInventorySystem
{
    public partial class frmEditProduct : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction func = new usableFunction();
        string sql;
        int maxrow;
        frmListofProducts frm;

        public frmEditProduct(string id,frmListofProducts frm)
        {
            InitializeComponent();

            retrieveProduct(id);
            this.frm = frm;
        }

        private void retrieveProduct(string id)
        {

            sql = "SELECT PROCODE,PRONAME,PRODESC,CATEGORY, PROPRICE, PROQTY FROM tblProductInfo  WHERE PROCODE='" + id + "'";
            maxrow = config.maxrow(sql);

            if(maxrow > 0)
            {
                foreach(DataRow r in config.dt.Rows)
                {
                    txtPROCODE.Text = r.Field<string>(0);
                    TXTPRONAME.Text = r.Field<string>(1);
                    TXTDESC.Text = r.Field<string>(2);
                    cboCateg.Text = r.Field<string>(3);
                    TXTPRICE.Text = r.Field<decimal>(4).ToString();
              
                }

            }
             
        }
        private void frmEditProduct_Load(object sender, EventArgs e)
        {

        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        { 
            sql = "UPDATE  tblProductInfo  SET PRONAME='" + TXTPRONAME.Text +
                        "' ,PRODESC='" + TXTDESC.Text +
                        "',CATEGORY='" + cboCateg.Text +
                        "', PROQTY ='" + TXTQTY.Text +
                        "',PROPRICE=" + TXTPRICE.Text + "  WHERE PROCODE='" + txtPROCODE.Text + "'";
            config.Execute_CUD(sql, "Error to update Item.", "Item Has Been Updated.");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTDESC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
