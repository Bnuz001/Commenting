///<summary>
/// Namn: Christian Fröberg
/// Klass: SY21
/// Info:
/// I denna fil finns mina klasser för genomgången om kommentering.
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentProgram
{
    /// <summary>
    /// En klass för att exemplifiera kommentering
    /// </summary>
    class ClassOne
    {
        /// <value>
        /// ParaOne är en Propertie
        /// </value>
        private int ParaOne;
        /// <value>
        /// 
        /// </value>
        private int ParaTwo;

        /// <summary>
        /// Konstruktor för klassen ClassOne
        /// </summary>
        /// <param name="paraOne">Förklaring av paraOne</param>
        /// <param name="paraTwo">Förklaring av paraTwo</param>
        public ClassOne(int paraOne, int paraTwo)
        {
            ParaOne = paraOne;
            ParaTwo = paraTwo;
        }
        /// <summary>
        /// En förklaring av metoden
        /// </summary>
        /// <param name="paraThree">Förklaring av paraThree</param>
        /// <returns>Summan av paraOne, paraTwo och paraThree</returns>
        public int methodOne(int paraThree)
        {
            return ParaOne + ParaTwo + paraThree;
        }
    
    }
}


