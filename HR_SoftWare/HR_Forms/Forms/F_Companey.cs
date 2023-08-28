using HR_DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Forms.Forms
{
    public partial class F_Companey : F_Master_Inhertanz
    { 
        public F_Companey()
        {
            InitializeComponent();
        }

        ClsCommander<T_Companey> cmdCompaney ;
        T_Companey TF_Comp;


        public override void Get_Data(string status_mess)
        {
            try
            {
                cmdCompaney = new ClsCommander<T_Companey>();
                TF_Comp = cmdCompaney.Get_All().FirstOrDefault();
                Fill_Controls();
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
            base.Get_Data(status_mess);
        }
       
        public override void Update_Data()
        {
            try
            {
                long com_id = Convert.ToInt64(Company_IdTextEdit.Text);
                TF_Comp = cmdCompaney.Get_By(c_id => c_id.Company_Id == com_id).FirstOrDefault();

                Fill_Entitey();
                cmdCompaney.Update_Data(TF_Comp);
               
                base.Update_Data();
                MessageBox.Show("تم التعديل بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ ex.InnerException.InnerException.ToString());
                Get_Data(ex.InnerException.InnerException.ToString());
            }

        }
       
        public void Fill_Controls()
        {
             Company_IdTextEdit.Text =TF_Comp.Company_Id .ToString();
            Company_NameTextEdit.Text = TF_Comp.Company_Name;
            Company_AddressTextEdit.Text = TF_Comp.Company_Address;
            Company_TitalTextEdit.Text = TF_Comp.Company_Tital;
            Company_MobileTextEdit.Text = TF_Comp.Company_Mobile;
            Company_PhoneTextEdit.Text = TF_Comp.Company_Phone;
            Company_FaxTextEdit.Text = TF_Comp.Company_Fax;
            Company_EmailTextEdit.Text = TF_Comp.Company_Email;
            Company_StateCheckEdit.Checked =Convert.ToBoolean( TF_Comp.Company_State);
            Company_NoteTextEdit.Text = TF_Comp.Company_Note;

        }
        public void Fill_Entitey()
        {
            
             TF_Comp.Company_Name = Company_NameTextEdit.Text.Trim() ;
            TF_Comp.Company_Address = Company_AddressTextEdit.Text.Trim();
           TF_Comp.Company_Tital = Company_TitalTextEdit.Text.Trim();
             TF_Comp.Company_Mobile =Company_MobileTextEdit.Text.Trim();
             TF_Comp.Company_Phone = Company_PhoneTextEdit.Text.Trim();
            TF_Comp.Company_Fax = Company_FaxTextEdit.Text.Trim();
             TF_Comp.Company_Email = Company_EmailTextEdit.Text.Trim();
             TF_Comp.Company_State = Convert.ToBoolean(Company_StateCheckEdit.CheckState) ;
            TF_Comp.Company_Note = Company_NoteTextEdit.Text.Trim();
        }

 
    }
}
