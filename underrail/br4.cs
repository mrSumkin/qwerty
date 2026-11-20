using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001FFB RID: 8187
public sealed class br4 : pm, amj
{
	// Token: 0x0600C10D RID: 49421 RVA: 0x0042E7F0 File Offset: 0x0042C9F0
	public override float wf()
	{
		return 0f;
	}

	// Token: 0x0600C10E RID: 49422 RVA: 0x0042E7F8 File Offset: 0x0042C9F8
	public override void wg(float A_0)
	{
	}

	// Token: 0x0600C10F RID: 49423 RVA: 0x0042E7FC File Offset: 0x0042C9FC
	public override float wh()
	{
		return this.a;
	}

	// Token: 0x0600C110 RID: 49424 RVA: 0x0042E804 File Offset: 0x0042CA04
	public override void wi(float A_0)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600C111 RID: 49425 RVA: 0x0042E80C File Offset: 0x0042CA0C
	public override float wj()
	{
		return this.b;
	}

	// Token: 0x0600C112 RID: 49426 RVA: 0x0042E814 File Offset: 0x0042CA14
	public override void wk(float A_0)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0600C113 RID: 49427 RVA: 0x0042E820 File Offset: 0x0042CA20
	public override float? aah()
	{
		if (this.c == ExperienceSystem.Oddity)
		{
			return new float?(1f);
		}
		return null;
	}

	// Token: 0x0600C114 RID: 49428 RVA: 0x0042E850 File Offset: 0x0042CA50
	public override int? aai()
	{
		return new int?(-2);
	}

	// Token: 0x0600C115 RID: 49429 RVA: 0x0042E85C File Offset: 0x0042CA5C
	public br4()
	{
		wj wj = global::wj.a();
		if (wj.d != UiSize.Classic)
		{
			base.a(wj.f);
			this.e = wj.aa;
			this.f = new esj?(wj.ab);
		}
	}

	// Token: 0x0600C116 RID: 49430 RVA: 0x0042E8AC File Offset: 0x0042CAAC
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			this.c = serviceOrThrow.aqu().v().e();
			this.a = (float)c2h.a(serviceOrThrow.aqu().v().Level + 1, serviceOrThrow.aqu().v().e(), serviceOrThrow.aqu().v().BaseAbilities.Get<av8>().f());
			this.b = (float)serviceOrThrow.aqu().v().i();
			base.a(this.a > 30f);
			return;
		}
		this.c = ExperienceSystem.Classic;
		this.a = 1f;
		this.b = 0f;
	}

	// Token: 0x0600C117 RID: 49431 RVA: 0x0042E988 File Offset: 0x0042CB88
	public ecs yf(euz A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		Color a_;
		if ((float)serviceOrThrow.aqu().v().i() >= this.wh())
		{
			a_ = Color.Green;
		}
		else
		{
			a_ = Color.White;
		}
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			return new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.White), "Опыт: ", null),
					new bph(new d22(cq4.c(), a_), serviceOrThrow.aqu().v().i().ToString(), null),
					new bph(new d22(cq4.c(), Color.White), " / " + this.a.ToString(), null)
				})
			});
		}
		return null;
	}

	// Token: 0x040045D7 RID: 17879
	private new float a;

	// Token: 0x040045D8 RID: 17880
	private new float b;

	// Token: 0x040045D9 RID: 17881
	private new ExperienceSystem c;
}
