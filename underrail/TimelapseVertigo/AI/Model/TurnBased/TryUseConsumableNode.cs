using System;
using System.Linq;
using Ouroboros.Playfield.References;

namespace TimelapseVertigo.AI.Model.TurnBased
{
	// Token: 0x02000015 RID: 21
	public class TryUseConsumableNode<T> : t7 where T : c3n
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000035FC File Offset: 0x000017FC
		public new T a()
		{
			return dgk.Get<T>();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003604 File Offset: 0x00001804
		public TryUseConsumableNode(string A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003618 File Offset: 0x00001818
		protected override cst ip()
		{
			coh coh = Enumerable.FirstOrDefault<coh>(base.b().g().aa().Bag.b(this.a));
			if (coh != null)
			{
				c3n c3n = dgk.Get<T>();
				if (c3n != null)
				{
					eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(base.b().g())), coh) as eu7;
					if (eu != null && eu.yw())
					{
						return cp.b(eu, base.b().g().a8(), base.b().g().a8());
					}
				}
			}
			return null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000036C0 File Offset: 0x000018C0
		public new bool a(e1k A_0)
		{
			coh coh = Enumerable.FirstOrDefault<coh>(A_0.g().aa().Bag.b(this.a));
			if (coh != null)
			{
				c3n c3n = dgk.Get<T>();
				if (c3n != null)
				{
					eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.g())), coh) as eu7;
					return eu != null && eu.yw();
				}
			}
			return false;
		}

		// Token: 0x0400007A RID: 122
		private new string a;
	}
}
