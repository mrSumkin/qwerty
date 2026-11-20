using System;
using Ouroboros.Playfield.References;

namespace TimelapseVertigo.AI.Model.TurnBased
{
	// Token: 0x02000017 RID: 23
	public class TryInvokePsiAbilityNode<T> : t7 where T : c3n
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00003AB8 File Offset: 0x00001CB8
		protected override cst ip()
		{
			if (base.b().g().aa().PsiAbilities.a(typeof(T)))
			{
				object obj;
				if (this.a != null)
				{
					obj = this.a(base.b());
				}
				else
				{
					amc amc = new bzv(base.b().c().y6()).g();
					if (amc != null)
					{
						obj = amc.a8();
					}
					else
					{
						obj = null;
					}
				}
				if (obj != null)
				{
					c3n c3n = dgk.Get<T>();
					if (c3n != null)
					{
						eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(base.b().g())), null) as eu7;
						if (eu != null && eu.yw())
						{
							return cp.b(eu, base.b().g().a8(), obj);
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003BA4 File Offset: 0x00001DA4
		public new bool a(e1k A_0)
		{
			c3n c3n = dgk.Get<T>();
			if (c3n != null && A_0.g().aa().PsiAbilities.a(typeof(T)))
			{
				eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.g())), null) as eu7;
				if (eu != null && eu.yw())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003C18 File Offset: 0x00001E18
		public new eu7 b(e1k A_0)
		{
			c3n c3n = dgk.Get<T>();
			if (c3n != null && A_0.g().aa().PsiAbilities.a(typeof(T)))
			{
				return ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.g())), null) as eu7;
			}
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003C78 File Offset: 0x00001E78
		public new T a()
		{
			return dgk.Get<T>();
		}

		// Token: 0x0400007E RID: 126
		public new Func<e1k, object> a;
	}
}
