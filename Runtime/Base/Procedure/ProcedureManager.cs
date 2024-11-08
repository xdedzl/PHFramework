﻿using System;

namespace PHFramework
{
    /// <summary>
    /// 流程的优先级应比状态机低
    /// </summary>
    public class ProcedureManager : MonoSingleton<ProcedureManager>
    {
        /// <summary>
        /// 流程状态机
        /// </summary>
        private readonly ProcedureFsm m_Fsm;

        public ProcedureManager()
        {
            m_Fsm = new ProcedureFsm();
        }

        /// <summary>
        /// 当前流程
        /// </summary>
        public ProcedureBase CurrentProcedure
        {
            get
            {
                return m_Fsm.CurrentState;
            }
        }

        /// <summary>
        /// 当前的子流程
        /// </summary>
        public SubProcedureBase CurrenSubProcedure
        {
            get
            {
                return m_Fsm.CurrentState?.CurrentSubProcedure;
            }
        }

        /// <summary>
        /// 切换流程
        /// </summary>
        /// <typeparam name="TProcedure">流程类型</typeparam>
        /// <param name="parms">参数</param>
        public void ChangeProcedure<TProcedure>(params object[] parms) where TProcedure : ProcedureBase
        {
            m_Fsm.ChangeState<TProcedure>(parms);
        }

        /// <summary>
        /// 切换流程
        /// </summary>
        /// <param name="type">流程类型</param>
        /// <param name="parms">参数</param>
        public void ChangeProcedure(Type type, params object[] parms)
        {
            m_Fsm.ChangeState(type, parms);
        }

        /// <summary>
        /// 新增一个流程
        /// </summary>
        /// <param name="procedure">流程</param>
        public void UpdateProcedure(ProcedureBase procedure)
        {
            m_Fsm.UpdateState(procedure);
        }

        /// <summary>
        /// 获取当前流程
        /// </summary>
        /// <typeparam name="TProcedure">流程类型</typeparam>
        /// <returns>当前流程</returns>
        public TProcedure GetCurrentProcedure<TProcedure>() where TProcedure : ProcedureBase
        {
            var current = m_Fsm.CurrentState;
            if (current is TProcedure procedure)
            {
                return procedure;
            }
            else
            {
                throw new PHFrameworkException($"[Procedure] current procedure is not {typeof(TProcedure).Name}");
            }
        }

        public void Update()
        {
            m_Fsm.OnUpdate();
        }
    }
}