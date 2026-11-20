using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001755 RID: 5973
[eiz("RIEA")]
[Serializable]
public sealed class cey : a6k
{
	// Token: 0x0600809B RID: 32923 RVA: 0x00365568 File Offset: 0x00363768
	private cey(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("RIEA:W");
	}

	// Token: 0x0600809C RID: 32924 RVA: 0x00365584 File Offset: 0x00363784
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RIEA:W", this.a);
	}

	// Token: 0x0600809D RID: 32925 RVA: 0x003655A4 File Offset: 0x003637A4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		coh coh;
		if (this.a)
		{
			if (base.vg().q() == null || base.vg().q().h.b == null)
			{
				return dc4.e;
			}
			cd1 cd = base.vg().q().h.b.aa().Offense.u();
			if (!eub.b(cd))
			{
				return dc4.e;
			}
			coh = cd;
		}
		else
		{
			coh = (base.vg().h() as coh);
		}
		if (coh == null || coh.MaxBattery == 0 || coh.Battery >= (double)coh.MaxBattery)
		{
			return dc4.e;
		}
		int num = a25.a(base.vg().e());
		if (num > 0)
		{
			coh.Battery = Math.Min((double)coh.MaxBattery, coh.Battery + (double)num);
		}
		if (base.vg().q() != null)
		{
			bmj.a(base.vg().q(), new e5x("Заряжено", Color.White, coh.Definition.a3(), false));
			vr a_ = new vr(new ap9(base.vg().q().h.b.aa()), null, "{0} заряжает {2}.", null, coh);
			bey.a(a_, base.vg().q().h.b.aa(), base.vg().q().h.b);
			a7v.a(a_);
			base.vg().q().c().a("ItemRecharge", "ItemRecharge", 1f, c9z.a, false, false);
		}
		return dc4.c;
	}

	// Token: 0x0600809E RID: 32926 RVA: 0x0036575C File Offset: 0x0036395C
	public cey(bool A_0 = false)
	{
		this.a = A_0;
	}

	// Token: 0x04003254 RID: 12884
	private new bool a;
}
