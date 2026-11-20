using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001814 RID: 6164
[ayj("Chainsaw")]
public sealed class bti : bon
{
	// Token: 0x06008315 RID: 33557 RVA: 0x0036DB50 File Offset: 0x0036BD50
	public override string y8()
	{
		return "Цепная пила";
	}

	// Token: 0x06008316 RID: 33558 RVA: 0x0036DB58 File Offset: 0x0036BD58
	public override string os()
	{
		return "Chainsaw";
	}

	// Token: 0x06008317 RID: 33559 RVA: 0x0036DB60 File Offset: 0x0036BD60
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x06008318 RID: 33560 RVA: 0x0036DB64 File Offset: 0x0036BD64
	public override bool cs()
	{
		return true;
	}

	// Token: 0x06008319 RID: 33561 RVA: 0x0036DB68 File Offset: 0x0036BD68
	public override int ct()
	{
		return 3;
	}

	// Token: 0x0600831A RID: 33562 RVA: 0x0036DB6C File Offset: 0x0036BD6C
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600831B RID: 33563 RVA: 0x0036DB74 File Offset: 0x0036BD74
	public override bool j7()
	{
		return false;
	}

	// Token: 0x0600831C RID: 33564 RVA: 0x0036DB78 File Offset: 0x0036BD78
	public override bool l8()
	{
		return false;
	}

	// Token: 0x0600831D RID: 33565 RVA: 0x0036DB7C File Offset: 0x0036BD7C
	public override bool i2()
	{
		return true;
	}

	// Token: 0x0600831E RID: 33566 RVA: 0x0036DB80 File Offset: 0x0036BD80
	public bti()
	{
		this.f = new List<string>();
		this.f.Add(d7f.a);
	}

	// Token: 0x0600831F RID: 33567 RVA: 0x0036DBA4 File Offset: 0x0036BDA4
	public override string bm(cnm A_0)
	{
		return "ChainsawAttack";
	}

	// Token: 0x06008320 RID: 33568 RVA: 0x0036DBAC File Offset: 0x0036BDAC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x06008321 RID: 33569 RVA: 0x0036DBB4 File Offset: 0x0036BDB4
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/Chainsaw", new object[]
		{
			Convert.ToInt32(bti.b * 100.0),
			bti.a,
			bti.c,
			bti.d,
			Convert.ToInt32(bti.e * 100.0)
		});
	}

	// Token: 0x06008322 RID: 33570 RVA: 0x0036DC30 File Offset: 0x0036BE30
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x06008323 RID: 33571 RVA: 0x0036DC3C File Offset: 0x0036BE3C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x06008324 RID: 33572 RVA: 0x0036DC70 File Offset: 0x0036BE70
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x06008325 RID: 33573 RVA: 0x0036DC74 File Offset: 0x0036BE74
	protected override int ma(cnm A_0)
	{
		return bti.a * this.mb(A_0);
	}

	// Token: 0x06008326 RID: 33574 RVA: 0x0036DC84 File Offset: 0x0036BE84
	protected override int mb(cnm A_0)
	{
		return 100;
	}

	// Token: 0x06008327 RID: 33575 RVA: 0x0036DC88 File Offset: 0x0036BE88
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null && A_0.b8() != null)
		{
			if (A_0.b8().Offense.u().Battery < (double)bti.c)
			{
				return false;
			}
			if (dz6.e())
			{
				d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
				d4n d4n = serviceOrThrow.ahu(A_0.b8());
				return d4n != null && d4n == serviceOrThrow.ahe() && d4n.c >= (double)bti.d;
			}
		}
		return true;
	}

	// Token: 0x04003276 RID: 12918
	public new static readonly int a = 10;

	// Token: 0x04003277 RID: 12919
	public static readonly double b = 0.7;

	// Token: 0x04003278 RID: 12920
	public static readonly int c = 10;

	// Token: 0x04003279 RID: 12921
	public static readonly int d = 5;

	// Token: 0x0400327A RID: 12922
	public new static readonly double e = 0.5;

	// Token: 0x0400327B RID: 12923
	private List<string> f;
}
