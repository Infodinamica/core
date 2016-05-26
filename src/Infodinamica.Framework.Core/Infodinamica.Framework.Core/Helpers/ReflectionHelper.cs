using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Infodinamica.Framework.Core.Exceptions;

namespace Infodinamica.Framework.Core.Helpers
{
    /// <summary>
    /// Helper con utilidades de reflection
    /// </summary>
    public static class ReflectionHelper
    {
        /// <summary>
        /// Obtiene el nombre del método actual
        /// </summary>
        /// <returns>Nombre del método actual en ejecución</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethod()
        {
            return CurrentMethod(2);
        }

        /// <summary>
        /// Obtiene el nombre del método padre
        /// </summary>
        /// <returns>Nombre del método actual en ejecución</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetParentMethod()
        {
            return CurrentMethod(3);
        }

        /// <summary>
        /// Obtiene el nombre de la clase actual del método en ejecución
        /// </summary>
        /// <returns>Nombre de la clase actual en ejecución</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentClass()
        {
            return CurrentClass(2);
        }

        /// <summary>
        /// Obtiene el nombre de la clase actual del método en ejecución
        /// </summary>
        /// <returns>Nombre de la clase actual en ejecución</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetParentClass()
        {
            return CurrentClass(3);
        }


        /// <summary>
        /// Obtiene el nombre del método actual
        /// </summary>
        /// <returns>Nombre del método actual en ejecución</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static string CurrentMethod(int depth)
        {
            StackTrace st = new StackTrace();
            
            if(st.FrameCount < depth)
                throw new CustomException(true, "the frame applied for is out of range");
            
            StackFrame sf = st.GetFrame(depth);
            return sf.GetMethod().Name;
        }

        /// <summary>
        /// Obtiene el nombre de la clase actual del método en ejecución
        /// </summary>
        /// <returns>Nombre de la clase actual en ejecución</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static string CurrentClass(int depth)
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(depth);
            var cls = sf.GetMethod().ReflectedType;

            if (cls != null)
                return cls.Name;

            throw new CustomException(true, "Reflected type is null");
        }
    }
}
