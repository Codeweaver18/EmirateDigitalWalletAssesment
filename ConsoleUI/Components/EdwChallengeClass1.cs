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
        public void Report()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// EdwChallengeClass2 SamPle Class Implementing the IEdwChallenge Interface.
    /// </summary>
    /// 
    public class EdwChallengeClass2 : IEdwChallenge
    {
        /// <summary>
        /// Report Instance information for
        /// </summary>
        public void Report()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// EdwChallengeClass3 SamPle Class Implementing the IEdwChallenge Interface.
    /// </summary>
    public class EdwChallengeClass3 : IEdwChallenge
    {
        public void Report()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
