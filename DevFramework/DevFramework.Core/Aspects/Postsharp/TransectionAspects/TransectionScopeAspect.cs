using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DevFramework.Core.Aspects.Postsharp.TransectionAspects
{
    [Serializable]
   public class TransectionScopeAspect:OnMethodBoundaryAspect
    {
        private TransactionScopeOption _option;

        public TransectionScopeAspect(TransactionScopeOption option)
        {
            _option = option;
        }

        public TransectionScopeAspect()
        {
            //using (TransactionScope scope= new TransactionScope())
            //{

            //}
      
    }
        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope(_option);
        }
        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }
        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }
    }
}
