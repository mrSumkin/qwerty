using System;
using Ouroboros.Playfield.References;

namespace TimelapseVertigo.AI.Model.TurnBased
{
	// Token: 0x02000012 RID: 18
	public class TryActivateAuraNode<T> : t7 where T : a8s
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002F64 File Offset: 0x00001164
		public TryActivateAuraNode()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002F6C File Offset: 0x0000116C
		public TryActivateAuraNode(bool? A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002F7C File Offset: 0x0000117C
		public new bool a(e1k A_0)
		{
			if (A_0.g().aa().SpecialAbilities.a(typeof(T)))
			{
				bool flag = A_0.g().aa().Auras.IsActive<T>();
				bool? flag2 = this.a;
				if (flag == flag2.GetValueOrDefault() & flag2 != null)
				{
					return false;
				}
				c3n c3n = dgk.Get<T>();
				if (c3n != null)
				{
					bl6 bl = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.g())), null) as bl6;
					return bl != null && bl.yw();
				}
			}
			return false;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003020 File Offset: 0x00001220
		protected override cst ip()
		{
			bool flag = base.b().g().aa().Auras.IsActive<T>();
			bool? flag2 = this.a;
			if (flag == flag2.GetValueOrDefault() & flag2 != null)
			{
				return null;
			}
			if (base.b().g().aa().SpecialAbilities.a(typeof(T)) || base.b().g().aa().EquippedCapabilities.a(typeof(T)))
			{
				c3n c3n = dgk.Get<T>();
				if (c3n != null)
				{
					bl6 bl = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(base.b().g())), null) as bl6;
					if (bl != null && bl.yw())
					{
						return cp.a(bl, base.b().g().a8(), false);
					}
				}
			}
			return null;
		}

		// Token: 0x04000074 RID: 116
		public new bool? a;
	}
}
