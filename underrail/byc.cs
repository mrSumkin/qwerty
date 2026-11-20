using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F07 RID: 7943
[ayj("AcidBlobAttack")]
public sealed class byc : c0z
{
	// Token: 0x0600B643 RID: 46659 RVA: 0x0040AD90 File Offset: 0x00408F90
	public override string y8()
	{
		return "Выстрел кислотой";
	}

	// Token: 0x0600B644 RID: 46660 RVA: 0x0040AD98 File Offset: 0x00408F98
	public override string os()
	{
		return "AcidBlobAttack";
	}

	// Token: 0x0600B645 RID: 46661 RVA: 0x0040ADA0 File Offset: 0x00408FA0
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B646 RID: 46662 RVA: 0x0040ADA4 File Offset: 0x00408FA4
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B647 RID: 46663 RVA: 0x0040ADA8 File Offset: 0x00408FA8
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a,
			c = c0e.g
		};
	}

	// Token: 0x0600B648 RID: 46664 RVA: 0x0040ADC8 File Offset: 0x00408FC8
	public byc()
	{
		this.c = new List<string>();
		this.c.Add("SA.AcidBlobAttack");
	}

	// Token: 0x0600B649 RID: 46665 RVA: 0x0040ADEC File Offset: 0x00408FEC
	public override string bm(cnm A_0)
	{
		if (c2h.a(A_0))
		{
			return "RustingAcidBlobAttack";
		}
		return "AcidBlobAttack";
	}

	// Token: 0x0600B64A RID: 46666 RVA: 0x0040AE04 File Offset: 0x00409004
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B64B RID: 46667 RVA: 0x0040AE0C File Offset: 0x0040900C
	public override string bo(cnm A_0)
	{
		a1q a1q = byc.b(A_0);
		int num = byc.c(A_0);
		if (c2h.a(A_0))
		{
			return qv.a("SpecialAbilities/AcidBlobAttack_Rusting", new object[]
			{
				a1q.a(true),
				l4.a((double)byc.a(A_0), false),
				num,
				c18.bq,
				ce.c,
				l4.a(ce.b, false),
				ce.a,
				Convert.ToInt32(d9b.a * 100.0)
			});
		}
		return qv.a("SpecialAbilities/AcidBlobAttack", new object[]
		{
			a1q.a(true),
			l4.a((double)byc.a(A_0), false),
			num
		});
	}

	// Token: 0x0600B64C RID: 46668 RVA: 0x0040AEEC File Offset: 0x004090EC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.AcidBlobAttack", byc.b, false, false)
		};
	}

	// Token: 0x0600B64D RID: 46669 RVA: 0x0040AF0C File Offset: 0x0040910C
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B64E RID: 46670 RVA: 0x0040AF18 File Offset: 0x00409118
	public static int a(efk A_0)
	{
		if (A_0 == null)
		{
			return 0;
		}
		if (A_0.b(d8o.t))
		{
			return Convert.ToInt32(qw.a(A_0.Level, 10));
		}
		return (int)((double)A_0.Skills.Get<ct7>().g() * 1.5);
	}

	// Token: 0x0600B64F RID: 46671 RVA: 0x0040AF70 File Offset: 0x00409170
	private static bool d(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().b(d8o.t);
	}

	// Token: 0x0600B650 RID: 46672 RVA: 0x0040AF98 File Offset: 0x00409198
	public static int c(cnm A_0)
	{
		if (byc.d(A_0))
		{
			return 35;
		}
		return 10;
	}

	// Token: 0x0600B651 RID: 46673 RVA: 0x0040AFAC File Offset: 0x004091AC
	public static a1q b(cnm A_0)
	{
		if (byc.d(A_0))
		{
			return new a1q(DamageType.Acid, 50, 100);
		}
		return new a1q(DamageType.Acid, 5, 10);
	}

	// Token: 0x0600B652 RID: 46674 RVA: 0x0040AFD0 File Offset: 0x004091D0
	public new static int a(cnm A_0)
	{
		int num;
		if (byc.d(A_0))
		{
			num = 3;
		}
		else
		{
			num = 2;
		}
		return d0u.b * num;
	}

	// Token: 0x0600B653 RID: 46675 RVA: 0x0040AFF8 File Offset: 0x004091F8
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B654 RID: 46676 RVA: 0x0040B000 File Offset: 0x00409200
	protected override float f0(cnm A_0)
	{
		return 8f;
	}

	// Token: 0x0600B655 RID: 46677 RVA: 0x0040B008 File Offset: 0x00409208
	protected override int hi(cnm A_0)
	{
		return 35;
	}

	// Token: 0x04004245 RID: 16965
	private new const string a = "SA.AcidBlobAttack";

	// Token: 0x04004246 RID: 16966
	private static readonly int b = d0u.b * 5;

	// Token: 0x04004247 RID: 16967
	private List<string> c;
}
