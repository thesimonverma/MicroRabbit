﻿using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
	public class TransferRepository : ITransferRepository
	{
		private TransferDbContext _ctx;

		public TransferRepository(TransferDbContext ctx)
		{
			_ctx = ctx;
		}
		public IEnumerable<TransferLog> GetTransferLogs()
		{
			return _ctx.TransferLogs;
		}
	}
}
