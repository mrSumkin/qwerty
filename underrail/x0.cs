using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x0200031A RID: 794
[apc("psionicDoppelganger")]
public class x0 : or
{
	// Token: 0x060016B1 RID: 5809 RVA: 0x00070484 File Offset: 0x0006E684
	public x0()
	{
		this.a = new ej0(new Action<ej0>(x0.a.a.a));
		this.a.a = this.c;
		this.j.a.Insert(0, new arr(this.a, new Func<e1k, bool>(x0.a.a.a)));
	}

	// Token: 0x04000D4E RID: 3406
	protected new ej0 a;

	// Token: 0x0200031B RID: 795
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060016B4 RID: 5812 RVA: 0x0007052C File Offset: 0x0006E72C
		internal void a(ej0 A_0)
		{
			dtb dtb = new dtb();
			dtb dtb2 = dtb;
			dtb2.a(dtb2.kh() | m7.k);
			List<auv> list = dtb.ad();
			ad6 ad = new ad6(A_0.b().c().a8());
			ad.b(1.0);
			ad.c(0.0);
			ad.a(dz6.a(0.001));
			list.Add(ad);
			dtb.ad().Add(new c7(A_0.b().c().a8(), true, true, true, false));
			A_0.b().c().a8().Zone.ActionManager.g9(dtb, atp.a);
			dz6.a(dtb);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000705F0 File Offset: 0x0006E7F0
		internal bool a(e1k A_0)
		{
			dlo dlo = Enumerable.FirstOrDefault<dlo>(A_0.g().aa().StatusEffects.Get<dlo>());
			if (dlo == null || dlo.TimeLeft <= (double)d0u.b)
			{
				return true;
			}
			Guid? primitivePropertyValue = A_0.c().y6().GetPrimitivePropertyValue<Guid>(ddq.a3, null);
			if (primitivePropertyValue != null)
			{
				EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(A_0.c().a8().Area, primitivePropertyValue.Value);
				if (entityAspectReference.ao() == null || entityAspectReference.ao().aa().Dead)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000D4F RID: 3407
		public static readonly x0.a a = new x0.a();

		// Token: 0x04000D50 RID: 3408
		public static Action<ej0> b;

		// Token: 0x04000D51 RID: 3409
		public static Func<e1k, bool> c;
	}
}
