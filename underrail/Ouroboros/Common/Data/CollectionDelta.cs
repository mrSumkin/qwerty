using System;
using System.Collections.Generic;
using System.Linq;

namespace Ouroboros.Common.Data
{
	// Token: 0x02002219 RID: 8729
	public sealed class CollectionDelta<T>
	{
		// Token: 0x0600CAAB RID: 51883 RVA: 0x0047CA38 File Offset: 0x0047AC38
		public bool a()
		{
			return (this.a == null || this.a.Count == 0) && (this.b == null || this.b.Count == 0);
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x0047CA74 File Offset: 0x0047AC74
		public CollectionDelta(ICollection<T> A_0, ICollection<T> A_1, List<T> A_2, List<T> A_3)
		{
			this.d = A_0;
			this.c = A_1;
			this.b = A_2;
			this.a = A_3;
		}

		// Token: 0x0600CAAD RID: 51885 RVA: 0x0047CA9C File Offset: 0x0047AC9C
		public void a(List<T> A_0, List<T> A_1)
		{
			this.a = Enumerable.ToList<T>(Enumerable.Except<T>(A_0, A_1));
			this.b = Enumerable.ToList<T>(Enumerable.Except<T>(A_1, A_0));
		}

		// Token: 0x04004A1F RID: 18975
		public List<T> a;

		// Token: 0x04004A20 RID: 18976
		public List<T> b;

		// Token: 0x04004A21 RID: 18977
		public ICollection<T> c;

		// Token: 0x04004A22 RID: 18978
		public ICollection<T> d;
	}
}
