using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E68 RID: 7784
[ayj("genericUseJobItem")]
public sealed class aln : c0z
{
	// Token: 0x0600ACBA RID: 44218 RVA: 0x003FA5A8 File Offset: 0x003F87A8
	public override string y8()
	{
		return "Использование";
	}

	// Token: 0x0600ACBB RID: 44219 RVA: 0x003FA5B0 File Offset: 0x003F87B0
	public override string os()
	{
		return "genericUseJobItem";
	}

	// Token: 0x0600ACBC RID: 44220 RVA: 0x003FA5B8 File Offset: 0x003F87B8
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600ACBD RID: 44221 RVA: 0x003FA5BC File Offset: 0x003F87BC
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600ACBE RID: 44222 RVA: 0x003FA5C0 File Offset: 0x003F87C0
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600ACC0 RID: 44224 RVA: 0x003FA5D0 File Offset: 0x003F87D0
	public override a3b bl(cnm A_0, efk A_1)
	{
		string a = c0e.d;
		bt1 bt = aln.a(A_0);
		if (bt != null)
		{
			a = bt.g();
		}
		return new a3b
		{
			a = a
		};
	}

	// Token: 0x0600ACC1 RID: 44225 RVA: 0x003FA604 File Offset: 0x003F8804
	public override string p6(cnm A_0)
	{
		bt1 bt = aln.a(A_0);
		if (bt != null)
		{
			return bt.b();
		}
		return "Using";
	}

	// Token: 0x0600ACC2 RID: 44226 RVA: 0x003FA62C File Offset: 0x003F882C
	public override bool c3(cnm A_0)
	{
		bt1 bt = aln.a(A_0);
		return bt != null && bt.i();
	}

	// Token: 0x0600ACC3 RID: 44227 RVA: 0x003FA650 File Offset: 0x003F8850
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600ACC4 RID: 44228 RVA: 0x003FA654 File Offset: 0x003F8854
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600ACC5 RID: 44229 RVA: 0x003FA658 File Offset: 0x003F8858
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600ACC6 RID: 44230 RVA: 0x003FA664 File Offset: 0x003F8864
	public override string bp(cnm A_0)
	{
		bt1 bt = aln.a(A_0);
		if (bt != null)
		{
			return bt.m();
		}
		return string.Empty;
	}

	// Token: 0x0600ACC7 RID: 44231 RVA: 0x003FA68C File Offset: 0x003F888C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600ACC8 RID: 44232 RVA: 0x003FA694 File Offset: 0x003F8894
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600ACC9 RID: 44233 RVA: 0x003FA69C File Offset: 0x003F889C
	public override dsk cv(cnm A_0)
	{
		bt1 bt = aln.a(A_0);
		if (bt != null)
		{
			return bt.j();
		}
		return dsk.c;
	}

	// Token: 0x0600ACCA RID: 44234 RVA: 0x003FA6C0 File Offset: 0x003F88C0
	public new static bt1 a(cnm A_0)
	{
		if (A_0 != null)
		{
			return aln.a(A_0.b9());
		}
		return null;
	}

	// Token: 0x0600ACCB RID: 44235 RVA: 0x003FA6D8 File Offset: 0x003F88D8
	public static bt1 a(object A_0)
	{
		coh coh = A_0 as coh;
		if (coh != null)
		{
			bt1 classPropertyValue = coh.CustomProperties.GetClassPropertyValue<bt1>("UsageJob");
			if (classPropertyValue == null)
			{
				classPropertyValue = coh.Definition.a7().GetClassPropertyValue<bt1>("UsageJob");
			}
			return classPropertyValue;
		}
		return null;
	}

	// Token: 0x0600ACCC RID: 44236 RVA: 0x003FA724 File Offset: 0x003F8924
	protected override int hi(cnm A_0)
	{
		bt1 bt = aln.a(A_0);
		if (bt != null)
		{
			return bt.h();
		}
		return 0;
	}

	// Token: 0x0600ACCD RID: 44237 RVA: 0x003FA748 File Offset: 0x003F8948
	protected override int br(cnm A_0)
	{
		bt1 bt = aln.a(A_0);
		if (bt != null)
		{
			return bt.e();
		}
		return 1000;
	}
}
