using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001743 RID: 5955
[eiz("AGRBA")]
[Serializable]
public sealed class dm8 : a6k
{
	// Token: 0x06008059 RID: 32857 RVA: 0x00363564 File Offset: 0x00361764
	private dm8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600805A RID: 32858 RVA: 0x00363570 File Offset: 0x00361770
	public dm8()
	{
	}

	// Token: 0x0600805B RID: 32859 RVA: 0x00363578 File Offset: 0x00361778
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		coh coh = base.vg().h() as coh;
		if (base.vg().q() == null || coh == null)
		{
			return dc4.e;
		}
		coh coh2 = base.vg().e().b9() as coh;
		if (coh2 == null || coh2.Definition == null)
		{
			return dc4.e;
		}
		dbj dbj = cme.a(base.vg().e());
		if (dbj == null)
		{
			return dc4.e;
		}
		dbj dbj2 = dbj.b();
		dbj2.ajq(coh);
		coh.a(dbj2);
		bmj.a(base.vg().q(), new e5x("Применено", Color.White, coh.Definition.a3(), false));
		a1h a_ = new a1h(new ap9(base.vg().q().h.b.aa()), string.Format("{0} применяет {1} к {2}.", base.vg().q().h.b.aa().Name, coh2.Definition, coh), new Color?(adi.v));
		bey.a(a_, base.vg().q().h.b.aa(), base.vg().q().h.b);
		a7v.a(a_);
		string text = dbj.qn(coh);
		if (!string.IsNullOrEmpty(text))
		{
			base.vg().q().c().a(text);
		}
		return dc4.c;
	}
}
