using System;
using System.Collections.Generic;

namespace TimelapseVertigo.Generators
{
	// Token: 0x02000030 RID: 48
	public class ItemPoolForQuality<T>
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00004BA0 File Offset: 0x00002DA0
		public ItemPoolForQuality(int A_0)
		{
			this.a = A_0;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004BBC File Offset: 0x00002DBC
		public void a(T A_0, int A_1 = -2147483648, int A_2 = 2147483647, int A_3 = 1)
		{
			if (this.a >= A_1 && this.a <= A_2)
			{
				for (int i = 0; i < A_3; i++)
				{
					this.b.Add(A_0);
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004C00 File Offset: 0x00002E00
		public T a()
		{
			if (this.b.Count > 0)
			{
				return this.b[zp.a.Next(this.b.Count)];
			}
			return default(T);
		}

		// Token: 0x04000179 RID: 377
		private int a;

		// Token: 0x0400017A RID: 378
		private List<T> b = new List<T>();
	}
}
