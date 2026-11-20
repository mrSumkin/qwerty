using System;
using Ouroboros.Events;

namespace TimelapseVertigo.Game.Events.Handlers
{
	// Token: 0x02000060 RID: 96
	public abstract class LocaleControllerEventHandlerBase<T> : GlobalEventHandler<T> where T : dli
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00009020 File Offset: 0x00007220
		protected dka a()
		{
			return this.a;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009028 File Offset: 0x00007228
		protected LocaleControllerEventHandlerBase(dka A_0)
		{
			czh.a(A_0, "localeController");
			this.a = A_0;
		}

		// Token: 0x040002F7 RID: 759
		private dka a;
	}
}
