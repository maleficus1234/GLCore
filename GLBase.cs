// 
// Copyright (c) 2013 Jason Bell
// 
// Permission is hereby granted, free of charge, to any person obtaining a 
// copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included 
// in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
// 

using System;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

// Ignore all the "will always have default value of null" warnings for the delegates: they
// do get values assigned through reflection.
#pragma warning disable 649

namespace GLCore
{
    public abstract class GLBase
    {
        /// <summary>
        /// The context with which this GL30 instance is associated.
        /// </summary>
        public Context Context { get; protected set; }

        public GLBase(Context context)
        {
            if (context == null) throw new NullReferenceException();

            this.Context = context;

            // Some reflection magic to automate assigning function pointers to their delegates.
            // Iterate through the fields of the class, and if the field is a delegate, get the
            // function pointer for the GL function of that name and assign it to the delegate.
            FieldInfo[] fields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var f in fields)
                if (f.FieldType.BaseType == typeof(MulticastDelegate))
                {
                    Delegate ptr = SetupDelegate(f.Name, f.FieldType);
                    if (ptr == null)
                        throw new Exception("Error setting up delegate for: " + f.Name);
                    f.SetValue(this, ptr);
                }
        }

        /// <summary>
        /// Returns a delegate to the named GL function.
        /// </summary>
        /// <param name="procName">The name of the GL function.</param>
        /// <param name="type">The type of the delegate it is being assigned to.</param>
        /// <returns></returns>
        protected Delegate SetupDelegate(string procName, Type type)
        {
            Delegate r = null;
            try
            {
                r = Marshal.GetDelegateForFunctionPointer(this.Context.GetGLProcAddress(procName), type);
            }
            catch (ArgumentNullException)
            {
                throw new NullReferenceException("Unable to find function: " + procName);
            }
            return r;
        }
    }
}
