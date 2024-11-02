using PHFramework.Fsm;

namespace PHFramework
{
    public class ProcedureFsm : Fsm<ProcedureBase>
    {
        protected override void OnStateChange(ProcedureBase oldState, ProcedureBase newState)
        {
            oldState?.CurrentSubProcedure?.OnExit();
            newState.OnEnter(oldState);
        }
    }
}