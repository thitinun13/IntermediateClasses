using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlowEngine workFlow = new WorkFlowEngine();
            workFlow.AddWorkFlowObject(new VideoUploader());
            workFlow.AddWorkFlowObject(new CallWebService());
            workFlow.AddWorkFlowObject(new SendEmail());
            workFlow.AddWorkFlowObject(new ChangeStatus());

            workFlow.Run();

            Console.ReadLine();
        }
    }
    public interface IWorkFlow
    {
        void Execute();
    }
    class VideoUploader : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a Video");
        }
    }
    class CallWebService : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Calling Web Service");
        }
    }
    class SendEmail : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email");
        }
    }
    class ChangeStatus : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Status Changed");
        }
    }
    class WorkFlowEngine
    {
        private List<IWorkFlow> T;

        public WorkFlowEngine()
        {
            T = new List<IWorkFlow>();
        }

        public void AddWorkFlowObject(IWorkFlow iObject)
        {
            T.Add(iObject);
        }
        public void RemoveWorkFlowObject(IWorkFlow iObject)
        {
            T.Remove(iObject);
        }
        public void Run()
        {
            foreach (IWorkFlow I in T)
            {
                I.Execute();
            }
        }
    }
}
