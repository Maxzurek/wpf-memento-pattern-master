﻿using qa_eval_finale_memento.states;
using System;

namespace qa_eval_finale_memento.mementos
{
    internal class ConcreteMemento : IMemento
    {
        #region Constructor

        public ConcreteMemento(IState state)
        {
            State = state;
            Date = DateTime.Now;
        }

        #endregion

        #region Properties
        public string Name
        {
            get { return $"{Date} : {State}"; }
        }

        public IState State { get; private set; }
        public DateTime Date { get; private set; }

        #endregion

        #region Interface Implementation
        public string GetName()
        {
            return Name;
        }

        public IState GetState()
        {
            return State;
        }

        public DateTime GetDate()
        {
            return Date;
        }

        #endregion
    }
}