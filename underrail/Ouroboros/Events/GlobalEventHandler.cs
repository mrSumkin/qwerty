using System;

namespace Ouroboros.Events
{
	// Token: 0x0200003E RID: 62
	public abstract class GlobalEventHandler<T> : IGlobalEventHandler<T> where T : dli
	{
		// Token: 0x060000B4 RID: 180
		public abstract void cr(T A_0);

		// Token: 0x060000B5 RID: 181 RVA: 0x00004D84 File Offset: 0x00002F84
		public virtual bool aqq(T A_0)
		{
			return true;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004D88 File Offset: 0x00002F88
		void b61.b(dli A_0)
		{
			this.cr(A_0 as T);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004D9C File Offset: 0x00002F9C
		bool b61.a(dli A_0)
		{
			return this.aqq(A_0 as T);
		}
	}
}
