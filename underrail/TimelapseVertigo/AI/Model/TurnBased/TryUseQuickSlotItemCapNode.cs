using System;
using System.Collections.Generic;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Items;

namespace TimelapseVertigo.AI.Model.TurnBased
{
	// Token: 0x02000016 RID: 22
	public class TryUseQuickSlotItemCapNode<T> : t7 where T : c3n
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00003734 File Offset: 0x00001934
		protected override cst ip()
		{
			aia aia = null;
			ItemSlot<coh> itemSlot = null;
			if (this.a != null)
			{
				ItemSlot<coh> itemSlot2 = base.b().g().aa().Gear.d()[this.a.Value];
				if (!itemSlot2.Enabled || itemSlot2.Item == null)
				{
					goto IL_173;
				}
				using (List<aia>.Enumerator enumerator = itemSlot2.Item.Definition.a2().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						aia aia2 = enumerator.Current;
						if (aia2 != null && aia2.Value is T)
						{
							itemSlot = itemSlot2;
							aia = aia2;
							break;
						}
					}
					goto IL_173;
				}
			}
			foreach (ItemSlot<coh> itemSlot3 in base.b().g().aa().Gear.d())
			{
				if (itemSlot3.Enabled && itemSlot3.Item != null)
				{
					foreach (aia aia3 in itemSlot3.Item.Definition.a2())
					{
						if (aia3 != null && aia3.Value is T)
						{
							itemSlot = itemSlot3;
							aia = aia3;
							break;
						}
					}
				}
			}
			IL_173:
			if (itemSlot != null && aia != null && aia.Value is T)
			{
				object obj;
				if (this.c != null)
				{
					obj = this.c(base.b());
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
				eu7 eu = ecf.a(aia.Value, new eru(new EntityAspectReference<amc, amc>(base.b().g())), itemSlot.Item) as eu7;
				if (eu != null && eu.yw() && obj != null)
				{
					return cp.b(eu, base.b().g().a8(), obj);
				}
			}
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000039A8 File Offset: 0x00001BA8
		public new bool a(e1k A_0)
		{
			foreach (ItemSlot<coh> itemSlot in A_0.g().aa().Gear.d())
			{
				if (itemSlot.Enabled && itemSlot.Item != null)
				{
					foreach (aia aia in itemSlot.Item.Definition.a2())
					{
						if (aia != null && aia.Value is T)
						{
							eu7 eu = ecf.a(aia.Value, new eru(new EntityAspectReference<amc, amc>(A_0.g())), itemSlot.Item) as eu7;
							return eu != null && eu.yw();
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0400007B RID: 123
		public new int? a;

		// Token: 0x0400007C RID: 124
		public new string b;

		// Token: 0x0400007D RID: 125
		public new Func<e1k, object> c;
	}
}
