using System;
using System.Collections.Generic;

// Token: 0x02001EA8 RID: 7848
[ayj("ShootHeartbreakPoisonBolt")]
public sealed class djc : eyv
{
	// Token: 0x0600B069 RID: 45161 RVA: 0x003FFDEC File Offset: 0x003FDFEC
	public override string y8()
	{
		return "Выстрел болтом с ядом сердцеед";
	}

	// Token: 0x0600B06A RID: 45162 RVA: 0x003FFDF4 File Offset: 0x003FDFF4
	public override string os()
	{
		return "ShootHeartbreakPoisonBolt";
	}

	// Token: 0x0600B06B RID: 45163 RVA: 0x003FFDFC File Offset: 0x003FDFFC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B06C RID: 45164 RVA: 0x003FFE00 File Offset: 0x003FE000
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B06D RID: 45165 RVA: 0x003FFE04 File Offset: 0x003FE004
	public djc()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B06E RID: 45166 RVA: 0x003FFE2C File Offset: 0x003FE02C
	public override string bo(cnm A_0)
	{
		int num = ezx.v;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/ShootHeartbreakPoisonBolt", new object[]
		{
			num,
			l4.a(ezx.y, false),
			ezx.x
		});
	}

	// Token: 0x0600B06F RID: 45167 RVA: 0x003FFEB0 File Offset: 0x003FE0B0
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B070 RID: 45168 RVA: 0x003FFEBC File Offset: 0x003FE0BC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B071 RID: 45169 RVA: 0x003FFEF0 File Offset: 0x003FE0F0
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x040040DE RID: 16606
	private new List<string> a;
}
