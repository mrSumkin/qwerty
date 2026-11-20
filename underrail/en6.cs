using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001486 RID: 5254
[eiz("RZ")]
[Serializable]
public sealed class en6 : a6k
{
	// Token: 0x06007676 RID: 30326 RVA: 0x00321BFC File Offset: 0x0031FDFC
	private en6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007677 RID: 30327 RVA: 0x00321C08 File Offset: 0x0031FE08
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		coh coh = this.fm() as coh;
		if (coh == null)
		{
			return dc4.e;
		}
		if (coh.Definition == null || coh.Definition.a9() || coh.MaxDurability <= 0 || (int)coh.Durability >= coh.MaxDurability)
		{
			return dc4.e;
		}
		coh coh2 = base.vg().e().b9() as coh;
		if (coh2 == null || fi.a(coh2) != coh.Definition.ay())
		{
			return dc4.e;
		}
		int num = fi.b(coh2);
		if (num > 0)
		{
			coh.Durability = Math.Min((double)coh.MaxDurability, coh.Durability + (double)num);
			if (base.vg().q() != null)
			{
				bmj.a(base.vg().q(), new e5x("Починено", Color.White, coh.Definition.a3(), false));
				vr a_ = new vr(new ap9(base.vg().q().h.b.aa()), null, "{0} чинит {2}.", null, coh);
				bey.a(a_, base.vg().q().h.b.aa(), base.vg().q().h.b);
				a7v.a(a_);
				base.vg().q().c().a("ItemRepair", "ItemRepair_" + coh.Definition.ay().ToString(), 1f, c9z.a, false, false);
				if (base.vg().q().h.b != null)
				{
					a06 a = coh as a06;
					if (a != null && base.vg().q().h.b.aa().d(a))
					{
						base.vg().q().h.b.aa().c(a);
						base.vg().q().h.b.aa().bl();
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007678 RID: 30328 RVA: 0x00321E44 File Offset: 0x00320044
	public en6()
	{
	}
}
