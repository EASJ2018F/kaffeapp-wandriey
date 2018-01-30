using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
   public class FlatWhite : Kaffe , Imælk
    {
        public FlatWhite()
        {

        } 

        public override string Styrke()
        {
            return "Svag";
        } 

        public int MlMælk()
        {
            return 25;
        }

        /// <summary>
        /// giver prisen tilbage på en kop flatwhtie
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 75;
        }
    }
}
