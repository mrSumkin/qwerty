using System;
using System.Collections.Generic;

namespace TimelapseVertigo.Rules.Characters
{
	// Token: 0x0200001F RID: 31
	public sealed class RequirementRestrictedElementContainer<T> where T : class
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00004018 File Offset: 0x00002218
		public RequirementRestrictedElementContainer()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004020 File Offset: 0x00002220
		public RequirementRestrictedElementContainer(T A_0, object A_1 = null, c6m A_2 = null)
		{
			this.c = A_0;
			this.a = A_1;
			this.b = A_2;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004040 File Offset: 0x00002240
		public bool a(efk A_0)
		{
			cq6 cq = this.c as cq6;
			if (cq != null && cq.ae5())
			{
				return true;
			}
			if (this.b != null)
			{
				List<brl> list = this.b.j0();
				if (list != null && list.Count > 0)
				{
					using (List<brl>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (!enumerator.Current.oh(A_0))
							{
								return false;
							}
						}
					}
					return true;
				}
			}
			return true;
		}

		// Token: 0x040000FB RID: 251
		public object a;

		// Token: 0x040000FC RID: 252
		public c6m b;

		// Token: 0x040000FD RID: 253
		public T c;

		// Token: 0x040000FE RID: 254
		public bool? d;
	}
}
