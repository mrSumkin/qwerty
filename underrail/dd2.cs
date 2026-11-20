using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020019A9 RID: 6569
[eiz("HAIE")]
[Serializable]
public sealed class dd2 : dbj
{
	// Token: 0x06008C37 RID: 35895 RVA: 0x00390E68 File Offset: 0x0038F068
	private dd2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C38 RID: 35896 RVA: 0x00390E74 File Offset: 0x0038F074
	public override string f9()
	{
		return "hyperallergenic";
	}

	// Token: 0x06008C39 RID: 35897 RVA: 0x00390E7C File Offset: 0x0038F07C
	public override string ga()
	{
		return "Гипералергик";
	}

	// Token: 0x06008C3A RID: 35898 RVA: 0x00390E84 File Offset: 0x0038F084
	public override string qj()
	{
		return "Гипералергик";
	}

	// Token: 0x06008C3B RID: 35899 RVA: 0x00390E8C File Offset: 0x0038F08C
	public override SpellTargetType qk()
	{
		return SpellTargetType.PoisonableWeapon;
	}

	// Token: 0x06008C3C RID: 35900 RVA: 0x00390E94 File Offset: 0x0038F094
	public override string ql()
	{
		return "Components.Hyperallergenic";
	}

	// Token: 0x06008C3D RID: 35901 RVA: 0x00390E9C File Offset: 0x0038F09C
	public dd2()
	{
	}

	// Token: 0x06008C3E RID: 35902 RVA: 0x00390EA4 File Offset: 0x0038F0A4
	public override bool qm(bool A_0)
	{
		return A_0;
	}

	// Token: 0x06008C3F RID: 35903 RVA: 0x00390EA8 File Offset: 0x0038F0A8
	public override string qn(coh A_0)
	{
		return "ApplyPoisonToBlade";
	}

	// Token: 0x06008C40 RID: 35904 RVA: 0x00390EB0 File Offset: 0x0038F0B0
	public override string gc(efk A_0)
	{
		return qv.a("StatusEffects/HyperallergenicItemEffect_Cap", new object[]
		{
			80,
			l4.a(bek.b, false),
			l4.a(bek.c, false)
		});
	}

	// Token: 0x06008C41 RID: 35905 RVA: 0x00390EE8 File Offset: 0x0038F0E8
	public override string gd(efk A_0)
	{
		return qv.a("StatusEffects/HyperallergenicItemEffect_Applied", new object[]
		{
			80,
			l4.a(bek.b, false),
			l4.a(bek.c, false)
		});
	}

	// Token: 0x06008C42 RID: 35906 RVA: 0x00390F20 File Offset: 0x0038F120
	public override List<edm> qo(cd1 A_0, bool A_1)
	{
		if (A_1)
		{
			return new List<edm>
			{
				new edm("Гипералергик", 1.0, 1, true)
			};
		}
		return null;
	}
}
