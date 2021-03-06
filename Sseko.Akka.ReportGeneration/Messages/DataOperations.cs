﻿using System;
using System.Collections.Generic;
using Sseko.Akka.DataService.Magento.Entities;

namespace Sseko.Akka.DataService.Magento.Messages
{
    public abstract class DataOperations
    {

        public interface IOperation
        {
            
        }

        public class DataOperation : IOperation
        {
            public DataOperation(OperationType reportType, int fellowId = 0, DateTime? start = null, DateTime? end = null )
            {
                ReportType = reportType;
                FellowId = fellowId;

                StartDate = start ?? DateTime.MinValue;
                EndDate = end ?? DateTime.MaxValue;
            }

            public OperationType ReportType { get; }

            public int FellowId { get; }

            public DateTime StartDate { get; }

            public DateTime EndDate { get; }
        }

        public class Result<T> : Data.QueryModels.Result<T>
        {
            public Result(T output, Exception exception = null)
            {
                Output = output;
                Exception = exception;
            }

            public Result(Data.QueryModels.Result<T> input)
            {
                Output = input.Output;
                Exception = input.Exception;
            }
        }

        public class ResultList<T> : Data.QueryModels.ResultList<T>
        {
            public ResultList(List<T> output, Exception exception = null)
            {
                Output = output;
                Exception = exception;
            }

            public ResultList(Data.QueryModels.ResultList<T> input)
            {
                Output = input.Output;
                Exception = input.Exception;
            }
        }

        public class GetNewFellows : IOperation
        {
            public GetNewFellows(DateTime? lastUpdated = null)
            {
                LastUpdated = lastUpdated;
            }
            public DateTime? LastUpdated { get; }
        }

        public class GetTransactions : IOperation
        {
            public GetTransactions(int fellowId)
            {
                FellowId = fellowId;
            }
            public int FellowId { get; }
        }
    }
}
