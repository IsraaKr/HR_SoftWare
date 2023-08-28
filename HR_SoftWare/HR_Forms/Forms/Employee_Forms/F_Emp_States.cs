using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HR_DataBase;

namespace HR_Forms.Forms.Employee_Forms
{
    public partial class F_Emp_States : F_Master_Inhertanz
    {
        public F_Emp_States()
        {
            InitializeComponent();
        }
        ClsCommander<T_Employee_State> cmdEmpState ;
        T_Employee_State T_Emp_State;

        public override void Get_Data(string status_mess)
        {
            try
            {
                cmdEmpState = new ClsCommander<T_Employee_State>();
                T_Emp_State = cmdEmpState.Get_All().FirstOrDefault();
                Fill_Controls();
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
            base.Get_Data(status_mess);
        }
        public override void Insert_Data()
        {
            base.Insert_Data();
        }
        public override void Update_Data()
        {
            base.Update_Data();
        }
        public override string Delete_Data()
        {
            return base.Delete_Data();
        }
        public override string Delete_Data(long s_id)
        {
            return base.Delete_Data(s_id);
        }
        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(s_controls);
        }
        public override void Print_Data()
        {
            base.Print_Data();
        }
        public void Fill_Controls()
        {

        }
        public void Fill_Entitey()
        {

        }
    }
}
