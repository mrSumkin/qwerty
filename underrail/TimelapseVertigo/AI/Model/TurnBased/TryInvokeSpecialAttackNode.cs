using System;
using Ouroboros.Playfield.References;

namespace TimelapseVertigo.AI.Model.TurnBased
{
	// Token: 0x02000019 RID: 25
	public class TryInvokeSpecialAttackNode<T> : t7 where T : c3n
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00003E74 File Offset: 0x00002074
		public new T a()
		{
			return dgk.Get<T>();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003E7C File Offset: 0x0000207C
		protected override cst ip()
		{
			if (base.b().g().aa().SpecialAttacks.a(typeof(T)) || base.b().g().aa().EquippedCapabilities.a(typeof(T)))
			{
				amc amc = new bzv(base.b().c().y6()).g();
				if (amc != null)
				{
					c3n c3n = dgk.Get<T>();
					if (c3n != null)
					{
						eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(base.b().g())), null) as eu7;
						if (eu != null && eu.yw())
						{
							return cp.b(eu, base.b().g().a8(), amc.a8());
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003F60 File Offset: 0x00002160
		public new bool a(e1k A_0)
		{
			if ((A_0.g().aa().SpecialAttacks.a(typeof(T)) || A_0.g().aa().EquippedCapabilities.a(typeof(T))) && new bzv(A_0.c().y6()).g() != null)
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
	}
}
