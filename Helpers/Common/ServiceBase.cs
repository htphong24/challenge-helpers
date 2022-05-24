using System;
using System.Diagnostics;

namespace HelperLibrary
{
    public abstract class ServiceBase<RQ, RS>
    {
        protected virtual RS DoRun(RQ request)
        {
            throw new NotImplementedException();
        }

        public virtual void RunTest()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="time">Running time</param>
        /// <returns></returns>
        public RS Run(RQ request, out double time)
        {
            var stopwatch = Stopwatch.StartNew();
            var result = DoRun(request);
            stopwatch.Stop();
            time = stopwatch.Elapsed.TotalMilliseconds;
            return result;
        }
    }
}
