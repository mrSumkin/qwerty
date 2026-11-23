using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E7B RID: 7803
[ayj("InjectMedicine")]
public sealed class b2v : m0
{
	// Token: 0x0600AE16 RID: 44566 RVA: 0x003FBCDC File Offset: 0x003F9EDC
	public override string y8()
	{
		return "Inject Medicine";
	}

	// Token: 0x0600AE17 RID: 44567 RVA: 0x003FBCE4 File Offset: 0x003F9EE4
	public override string os()
	{
		return "InjectMedicine";
	}

	// Token: 0x0600AE18 RID: 44568 RVA: 0x003FBCEC File Offset: 0x003F9EEC
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AE19 RID: 44569 RVA: 0x003FBCF0 File Offset: 0x003F9EF0
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600AE1B RID: 44571 RVA: 0x003FBD00 File Offset: 0x003F9F00
	public override a3b bl(cnm A_0, efk A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null && A_0.b8().Gear.l().Item.Definition.a5() == "technomedicExoskeleton")
		{
			if (A_0 != null && A_0.b8() != null && A_0.b8() == A_1)
			{
				return new a3b
				{
					c = c0e.t
				};
			}
			return new a3b
			{
				c = c0e.u
			};
		}
		else
		{
			if (A_0 != null && A_0.b8() != null && A_0.b8() == A_1)
			{
				return new a3b
				{
					c = c0e.p,
					b = new int?(80)
				};
			}
			return new a3b
			{
				c = c0e.r,
				b = new int?(80)
			};
		}
	}

	// Token: 0x0600AE1C RID: 44572 RVA: 0x003FBE00 File Offset: 0x003FA000
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AE1D RID: 44573 RVA: 0x003FBE04 File Offset: 0x003FA004
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.LivingCreature;
	}

	// Token: 0x0600AE1E RID: 44574 RVA: 0x003FBE08 File Offset: 0x003FA008
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600AE1F RID: 44575 RVA: 0x003FBE10 File Offset: 0x003FA010
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		if (A_1 == v5.a)
		{
			return new List<cfd>();
		}
		return new List<cfd>
		{
			new cfd("injectMedicine", 500, true, false)
		};
	}

	// Token: 0x0600AE20 RID: 44576 RVA: 0x003FBE3C File Offset: 0x003FA03C
	public override IList<string> bi()
	{
		return new List<string>
		{
			"injectMedicine"
		};
	}

	// Token: 0x0600AE21 RID: 44577 RVA: 0x003FBE50 File Offset: 0x003FA050
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AE22 RID: 44578 RVA: 0x003FBE58 File Offset: 0x003FA058
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x04004077 RID: 16503
	private new const string a = "injectMedicine";
}
