using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001E6A RID: 7786
[ayj("UseSuicideBomberBelt")]
public sealed class em : m0
{
	// Token: 0x0600ACEB RID: 44267 RVA: 0x003FAAC8 File Offset: 0x003F8CC8
	public override string y8()
	{
		return "Бум!";
	}

	// Token: 0x0600ACEC RID: 44268 RVA: 0x003FAAD0 File Offset: 0x003F8CD0
	public override string os()
	{
		return "UseSuicideBomberBelt";
	}

	// Token: 0x0600ACED RID: 44269 RVA: 0x003FAAD8 File Offset: 0x003F8CD8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600ACEE RID: 44270 RVA: 0x003FAADC File Offset: 0x003F8CDC
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.j,
			d = new int?(50)
		};
	}

	// Token: 0x0600ACEF RID: 44271 RVA: 0x003FAAFC File Offset: 0x003F8CFC
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600ACF0 RID: 44272 RVA: 0x003FAB00 File Offset: 0x003F8D00
	public override bool cz()
	{
		return false;
	}

	// Token: 0x0600ACF1 RID: 44273 RVA: 0x003FAB04 File Offset: 0x003F8D04
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600ACF2 RID: 44274 RVA: 0x003FAB08 File Offset: 0x003F8D08
	public em()
	{
		this.d = new List<string>();
		this.d.Add("SA.UseSuicideBomberBelt");
	}

	// Token: 0x0600ACF3 RID: 44275 RVA: 0x003FAB2C File Offset: 0x003F8D2C
	public override string bm(cnm A_0)
	{
		return "UseSuicideBomberBelt";
	}

	// Token: 0x0600ACF4 RID: 44276 RVA: 0x003FAB34 File Offset: 0x003F8D34
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600ACF5 RID: 44277 RVA: 0x003FAB38 File Offset: 0x003F8D38
	public override string bo(cnm A_0)
	{
		return qv.b("Items\\Utilities/UseSuicideBomberBelt");
	}

	// Token: 0x0600ACF6 RID: 44278 RVA: 0x003FAB44 File Offset: 0x003F8D44
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600ACF7 RID: 44279 RVA: 0x003FAB50 File Offset: 0x003F8D50
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.UseSuicideBomberBelt", em.b * d0u.b, false, false)
		};
	}

	// Token: 0x0600ACF8 RID: 44280 RVA: 0x003FAB74 File Offset: 0x003F8D74
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600ACF9 RID: 44281 RVA: 0x003FAB7C File Offset: 0x003F8D7C
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600ACFA RID: 44282 RVA: 0x003FAB80 File Offset: 0x003F8D80
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null && A_0.b8() != null)
		{
			ItemSlot<coh>[] array = A_0.b8().Gear.d();
			for (int i = 0; i < array.Length; i++)
			{
				coh coh = array[i].pp();
				if (coh != null && coh.Definition is dxw && coh.Definition.a2().Count > 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600ACFB RID: 44283 RVA: 0x003FAC0C File Offset: 0x003F8E0C
	protected override int hi(cnm A_0)
	{
		return em.c;
	}

	// Token: 0x0400405E RID: 16478
	private new const string a = "SA.UseSuicideBomberBelt";

	// Token: 0x0400405F RID: 16479
	public static readonly int b = 6;

	// Token: 0x04004060 RID: 16480
	public static readonly int c = 10;

	// Token: 0x04004061 RID: 16481
	private List<string> d;
}
