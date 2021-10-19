using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace MicroRabbit.Domain.Core.Events
{
	public abstract class Message : IRequest<bool>
	{
		public string Messagetype { get; protected set; }
		protected Message()
		{
			Messagetype = GetType().Name;
		}
	}
}
