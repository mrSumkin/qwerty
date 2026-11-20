using System;

namespace Ouroboros.Common.Events
{
	// Token: 0x0200005F RID: 95
	[eiz("iEVt")]
	public interface IEventSubscriber<T> where T : EventArgs
	{
		// Token: 0x06000183 RID: 387
		void a(object A_0, EventHandler<T> A_1);

		// Token: 0x06000184 RID: 388
		void b(object A_0, EventHandler<T> A_1);
	}
}
