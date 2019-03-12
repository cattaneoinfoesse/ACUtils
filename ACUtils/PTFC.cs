﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACUtils
{
    public class PTFC<T>
    {
        public ConcurrentQueue<T> OutQueue { get; }

        protected bool isRunning;
        public bool IsRunning => isRunning;

        public bool IsRunningOrNotEmpty => IsRunning || !OutQueue.IsEmpty;

        private PTFC<T> producer;

        public PTFC()
        {
            OutQueue = new ConcurrentQueue<T>();
        }

        public PTFC(PTFC<T> producer)
        {
            OutQueue = new ConcurrentQueue<T>();
            this.producer = producer;
        }


        public PTFC<T> Produce(Action<ConcurrentQueue<T>> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    action(OutQueue);
                }
                finally
                {
                    isRunning = false;
                }
            });
            return new PTFC<T>(this);
        }


        private void _filter(Func<T, T> action)
        {
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    try
                    {
                        var o = action(t);
                        OutQueue.Enqueue(o);
                    }
                    catch (DiscartException)
                    {
                        // ignore - elemento scartato
                    }
                }
            }
        }

        public PTFC<T> Filter(Func<T, T> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    _filter(action);
                }
                finally
                {
                    isRunning = false;
                }
            });
            return new PTFC<T>(this);
        }

        public PTFC<TO, T> Filter<TO>(Func<T, T> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    _filter(action);
                }
                finally
                {
                    isRunning = false;
                }
            });
            return new PTFC<TO, T>(this);
        }

        public List<T> Consume()
        {
            var l = new List<T>();
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    l.Add(t);
                }
            }

            return l;
        }

        public void Consume(Action<T> action)
        {
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    action(t);
                }
            }
        }

        public PTFC<T> Produce()
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    while (producer.IsRunningOrNotEmpty)
                    {
                        if (producer.TryDequeue(out var t))
                        {
                            OutQueue.Enqueue(t);
                        }
                    }
                }
                finally
                {
                    isRunning = false;
                }
            });
            return new PTFC<T>(this);
        }

        public bool TryDequeue(out T t)
        {
            if (IsRunningOrNotEmpty)
            {
                return OutQueue.TryDequeue(out t);
            }

            t = default(T);
            return false;
        }
    }


    public class PTFC<TO, TI> : PTFC<TO>
    {
        private PTFC<TI> producer;

        public PTFC(PTFC<TI> producer)
        {
            this.producer = producer;
        }

        private void _filterT(Func<TI, TO> action)
        {
            while (producer.IsRunningOrNotEmpty)
            {
                if (producer.TryDequeue(out var t))
                {
                    try
                    {
                        var o = action(t);
                        OutQueue.Enqueue(o);
                    }
                    catch (DiscartException)
                    {
                        // ignore - elemento scartato
                    }
                }
            }
        }

        public PTFC<TO> Transmorm(Func<TI, TO> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    _filterT(action);
                }
                finally
                {
                    isRunning = false;
                }
            });

            return new PTFC<TO>(this);
        }

        public PTFC<TT, TO> Transmorm<TT>(Func<TI, TO> action)
        {
            isRunning = true;
            Task.Run(() =>
            {
                try
                {
                    _filterT(action);
                }
                finally
                {
                    isRunning = false;
                }
            });

            return new PTFC<TT, TO>(this);
        }
    }
}