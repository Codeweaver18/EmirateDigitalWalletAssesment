using System;
using System.Collections.Generic;
using System.Text;
using ComponentLoader;
using ComponentLoader.Abstract;

[assembly: EDW_Challenge("EDW CHallenge")]
namespace ComponentLoader.Components
{


    /// <summary>
    /// EdwChallengeClass1 SamPle Class Implementing the IEdwChallenge Interface.
    /// </summary>

    public class EdwChallengeClass1 : IEdwChallenge
    {
        public string guid = string.Empty;
        EdwChallengeClass1()
        {
            Guid obj = new Guid();
            guid = obj.ToString();
        }

        /// <summary>
        /// Report Instance information for
        /// </summary>
        public void Report()
        {
            var className = this.GetType().Name;
            var AssemblyName = this.GetType().Assembly;

            try
            {
                Console.WriteLine("Class Name:" + className);
                Console.WriteLine("Assembly Name:" + AssemblyName);
                Console.WriteLine("Guid:" + guid);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }

    /// <summary>
    /// EdwChallengeClass2 SamPle Class Implementing the IEdwChallenge Interface.
    /// </summary>
    /// 
    public class EdwChallengeClass2 : IEdwChallenge
    {
        EdwChallengeClass2()
        {
            Guid obj = new Guid();
            guid = obj.ToString();
        }

        public string guid = string.Empty;
        /// <summary>
        /// Report Instance information for
        /// </summary>
        public void Report()

        {

            var className = this.GetType().Name;
            var AssemblyName = this.GetType().Assembly;

            try
            {
                Console.WriteLine("Class Name:" + className);
                Console.WriteLine("Assembly Name:" + AssemblyName);
                Console.WriteLine("Guid:" + guid);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }

    /// <summary>
    /// EdwChallengeClass3 SamPle Class Implementing the IEdwChallenge Interface.
    /// </summary>
    public class EdwChallengeClass3 : IEdwChallenge
    {
        public string guid = string.Empty;
        EdwChallengeClass3()
        {
            Guid obj = new Guid();
            guid = obj.ToString();
        }

        public void Report()
        {
            var className = this.GetType().Name;
            var AssemblyName = this.GetType().Assembly;
            try
            {
                Console.WriteLine("Class Name:" + className);
                Console.WriteLine("Assembly Name:" + AssemblyName);
                Console.WriteLine("Guid:" + guid);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
