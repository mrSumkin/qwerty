using System;
using Ouroboros.Playfield.References;

namespace TimelapseVertigo.AI.Model.TurnBased
{
	// Token: 0x02000018 RID: 24
	public class TryInvokeSpecialAbilityNode<T> : t7 where T : c3n
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00003C8C File Offset: 0x00001E8C
		public new bool b(e1k A_0)
		{
			if ((A_0.g().aa().SpecialAbilities.a(typeof(T)) || A_0.g().aa().EquippedCapabilities.a(typeof(T))) && this.a(A_0) != null)
			{
				c3n c3n = dgk.Get<T>();
				if (c3n != null)
				{
					eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.g())), null) as eu7;
					return eu != null && eu.yw();
				}
			}
			return false;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003D2C File Offset: 0x00001F2C
		protected override cst ip()
		{
			if (base.b().g().aa().SpecialAbilities.a(typeof(T)) || base.b().g().aa().EquippedCapabilities.a(typeof(T)))
			{
				c3n c3n = dgk.Get<T>();
				if (c3n != null)
				{
					eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(base.b().g())), null) as eu7;
					if (eu != null && eu.yw())
					{
						object obj = this.a(base.b());
						if (obj != null)
						{
							return cp.b(eu, base.b().g().a8(), obj);
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003DFC File Offset: 0x00001FFC
		private new object a(e1k A_0)
		{
			if (this.b != null)
			{
				return this.b(A_0);
			}
			e8t e8t = this.a;
			if (e8t != e8t.a)
			{
				if (e8t != e8t.b)
				{
					return null;
				}
				return A_0.g().a8();
			}
			else
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc != null)
				{
					return amc.a8();
				}
				return null;
			}
		}

		// Token: 0x0400007F RID: 127
		public new e8t a;

		// Token: 0x04000080 RID: 128
		public new Func<e1k, object> b;
	}
}
