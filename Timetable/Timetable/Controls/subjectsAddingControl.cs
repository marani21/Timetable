using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
	public partial class SubjectsAddingControl : UserControl
	{
        public ComboBox ComboBoxGet
        {
            get { return comboBoxViewSubjects; }
            private set { }
        }

		public SubjectsAddingControl()
		{
			InitializeComponent();
		}
	}
}
