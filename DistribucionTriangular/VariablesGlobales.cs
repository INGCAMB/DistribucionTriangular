using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribucionTriangular
{
    class VariablesGlobales
    {
        private static int XN = 0;

        public static int XNActivo
        {
            get { return XN; }
            set { XN = value; }
        }

        private static int C = 0;

        public static int CActivo
        {
            get { return C; }
            set { C = value; }
        }

        private static int A = 0;

        public static int AActivo
        {
            get { return A; }
            set { A = value; }
        }

        private static int M = 0;

        public static int MActivo
        {
            get { return M; }
            set { M = value; }
        }

        private static int N = 0;

        public static int NActivo
        {
            get { return N; }
            set { N = value; }
        }
    }
}
