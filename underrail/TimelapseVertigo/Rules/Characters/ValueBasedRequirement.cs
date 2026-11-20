using System;

namespace TimelapseVertigo.Rules.Characters
{
	// Token: 0x02000022 RID: 34
	public abstract class ValueBasedRequirement<T> : brl where T : struct
	{
		// Token: 0x0600006B RID: 107 RVA: 0x000040F0 File Offset: 0x000022F0
		public T c()
		{
			return this.a;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000040F8 File Offset: 0x000022F8
		public ValueBasedRequirement()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004100 File Offset: 0x00002300
		public ValueBasedRequirement(T A_0)
		{
			this.a = A_0;
		}

		// Token: 0x04000121 RID: 289
		private T a;
	}
}
