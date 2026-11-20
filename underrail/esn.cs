using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E77 RID: 7799
[ayj("taserTase")]
public sealed class esn : m0
{
	// Token: 0x0600ADD3 RID: 44499 RVA: 0x003FB92C File Offset: 0x003F9B2C
	public override string y8()
	{
		return "Tase";
	}

	// Token: 0x0600ADD4 RID: 44500 RVA: 0x003FB934 File Offset: 0x003F9B34
	public override string os()
	{
		return "taserTase";
	}

	// Token: 0x0600ADD5 RID: 44501 RVA: 0x003FB93C File Offset: 0x003F9B3C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600ADD6 RID: 44502 RVA: 0x003FB940 File Offset: 0x003F9B40
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600ADD7 RID: 44503 RVA: 0x003FB944 File Offset: 0x003F9B44
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j
		};
	}

	// Token: 0x0600ADD8 RID: 44504 RVA: 0x003FB958 File Offset: 0x003F9B58
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600ADD9 RID: 44505 RVA: 0x003FB95C File Offset: 0x003F9B5C
	public esn()
	{
		this.d = new List<string>();
		this.d.Add("taze");
	}

	// Token: 0x0600ADDA RID: 44506 RVA: 0x003FB980 File Offset: 0x003F9B80
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600ADDB RID: 44507 RVA: 0x003FB984 File Offset: 0x003F9B84
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600ADDC RID: 44508 RVA: 0x003FB98C File Offset: 0x003F9B8C
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/Taser", new object[]
		{
			esn.b(A_0).a(true),
			l4.a(esn.c, false),
			esn.a(A_0)
		});
	}

	// Token: 0x0600ADDD RID: 44509 RVA: 0x003FB9D8 File Offset: 0x003F9BD8
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600ADDE RID: 44510 RVA: 0x003FB9E4 File Offset: 0x003F9BE4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("taze", esn.b, false, false)
		};
	}

	// Token: 0x0600ADDF RID: 44511 RVA: 0x003FBA04 File Offset: 0x003F9C04
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600ADE0 RID: 44512 RVA: 0x003FBA10 File Offset: 0x003F9C10
	public static a1q b(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				int? primitivePropertyValue = coh.Definition.a7().GetPrimitivePropertyValue<int>("TaserStrength", null);
				if (primitivePropertyValue != null)
				{
					return new a1q(DamageType.Electricity, 5 + primitivePropertyValue.Value / 7, 10 + primitivePropertyValue.Value / 4);
				}
			}
		}
		return new a1q(DamageType.Electricity, 1, 2);
	}

	// Token: 0x0600ADE1 RID: 44513 RVA: 0x003FBA94 File Offset: 0x003F9C94
	public new static int a(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				int? primitivePropertyValue = coh.Definition.a7().GetPrimitivePropertyValue<int>("TaserStrength", null);
				if (primitivePropertyValue != null)
				{
					return 3 + primitivePropertyValue.Value / 8;
				}
			}
		}
		return 3;
	}

	// Token: 0x0600ADE2 RID: 44514 RVA: 0x003FBAFC File Offset: 0x003F9CFC
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600ADE3 RID: 44515 RVA: 0x003FBB04 File Offset: 0x003F9D04
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600ADE4 RID: 44516 RVA: 0x003FBB08 File Offset: 0x003F9D08
	protected override double q3(cnm A_0)
	{
		return (double)esn.a(A_0);
	}

	// Token: 0x04004073 RID: 16499
	private new const string a = "taze";

	// Token: 0x04004074 RID: 16500
	public static readonly int b = 15000;

	// Token: 0x04004075 RID: 16501
	public static readonly int c = 1;

	// Token: 0x04004076 RID: 16502
	private List<string> d;
}
