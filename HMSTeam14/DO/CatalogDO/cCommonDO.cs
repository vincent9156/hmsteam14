using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO
{
    public class cCommonDO
    {
        private static cNhanVienDO m_CurrentUser;
        public static cNhanVienDO CurrentUser
        {
            get { return m_CurrentUser; }
            set { m_CurrentUser = value; }
        }
    }
}
