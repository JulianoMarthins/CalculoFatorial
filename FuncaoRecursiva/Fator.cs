using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoRecursiva {
    static internal class Fator {

        public static int Fatorial(int num) {
            if(num <= 0){
                return 1;
            }

            return num * Fatorial(num - 1);
        }

    }
}
