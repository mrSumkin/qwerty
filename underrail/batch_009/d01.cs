using System;
using System.Collections.Generic;

// Token: 0x02001ECA RID: 7882
[ayj("ShootPoisonBolt")]
public sealed class d01 : eyv
{
	// Token: 0x0600B242 RID: 45634 RVA: 0x004043F8 File Offset: 0x004025F8
	public override string y8()
	{
		return "Запустить отравленный болт";
	}

	// Token: 0x0600B243 RID: 45635 RVA: 0x00404400 File Offset: 0x00402600
	public override string os()
	{
		return "ShootPoisonBolt";
	}

	// Token: 0x0600B244 RID: 45636 RVA: 0x00404408 File Offset: 0x00402608
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B245 RID: 45637 RVA: 0x0040440C File Offset: 0x0040260C
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B246 RID: 45638 RVA: 0x00404410 File Offset: 0x00402610
	public d01()
	{
		this.b = new List<string>();
		this.b.Add(d7f.a);
		this.b.Add("SAt.ShootPoisonBolt");
	}

	// Token: 0x0600B247 RID: 45639 RVA: 0x00404448 File Offset: 0x00402648
	public override string bo(cnm A_0)
	{
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		int num = cl5.a(a_);
		string text = cl5.b(a_);
		if (string.IsNullOrEmpty(text))
		{
			text = "poison";
		}
		else
		{
			text = text.ToLowerInvariant();
		}
		if (num > 1)
		{
			return qv.a("SpecialAttacks/ShootPoisonBoltStackable", new object[]
			{
				text,
				cl5.a(a_, (A_0 != null) ? A_0.b8() : null),
				cl5.d(a_),
				num
			});
		}
		return qv.a("SpecialAttacks/ShootPoisonBolt", new object[]
		{
			text,
			cl5.a(a_, (A_0 != null) ? A_0.b8() : null),
			cl5.d(a_)
		});
	}

	// Token: 0x0600B248 RID: 45640 RVA: 0x00404530 File Offset: 0x00402730
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B249 RID: 45641 RVA: 0x0040453C File Offset: 0x0040273C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B24A RID: 45642 RVA: 0x00404570 File Offset: 0x00402770
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0400414D RID: 16717
	private new const string a = "SAt.ShootPoisonBolt";

	// Token: 0x0400414E RID: 16718
	private List<string> b;
}
