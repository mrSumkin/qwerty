using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001C22 RID: 7202
[d29("RemoteSurgeon", "Remote Surgeon")]
public sealed class jh : ai8
{
	// Token: 0x06009E29 RID: 40489 RVA: 0x003E1840 File Offset: 0x003DFA40
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E2A RID: 40490 RVA: 0x003E1844 File Offset: 0x003DFA44
	public jh() : base("膢Дистанционный хирург")
	{
	}

	// Token: 0x06009E2B RID: 40491 RVA: 0x003E1854 File Offset: 0x003DFA54
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009E2C RID: 40492 RVA: 0x003E1858 File Offset: 0x003DFA58
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009E2D RID: 40493 RVA: 0x003E185C File Offset: 0x003DFA5C
	public override object[] at()
	{
		return new object[]
		{
			(int)(jh.a * 100.0)
		};
	}

	// Token: 0x06009E2E RID: 40494 RVA: 0x003E187C File Offset: 0x003DFA7C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 8),
			new bap(60, new Type[]
			{
				typeof(dei)
			}),
			new bap(25, new Type[]
			{
				typeof(b6s)
			})
		};
	}

	// Token: 0x06009E2F RID: 40495 RVA: 0x003E18E8 File Offset: 0x003DFAE8
	public static double a(int A_0)
	{
		return jh.a + (double)A_0 * ce9.a;
	}

	// Token: 0x06009E30 RID: 40496 RVA: 0x003E18FC File Offset: 0x003DFAFC
	public static AmmoType a(efk A_0)
	{
		int result = 150000;
		if (A_0 != null && A_0.Feats.Contains<jh>())
		{
			result = 150001 + A_0.GetSpecializationValue<ce9>(true);
		}
		return (AmmoType)result;
	}

	// Token: 0x04003D5B RID: 15707
	public new static readonly double a = 0.5;
}
