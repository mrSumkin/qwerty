using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FF5 RID: 8181
public sealed class dvx : eb1
{
	// Token: 0x0600C08E RID: 49294 RVA: 0x0042BF44 File Offset: 0x0042A144
	public override av zc()
	{
		return this.a;
	}

	// Token: 0x0600C08F RID: 49295 RVA: 0x0042BF4C File Offset: 0x0042A14C
	public override bool zd()
	{
		return base.Enabled;
	}

	// Token: 0x0600C090 RID: 49296 RVA: 0x0042BF54 File Offset: 0x0042A154
	public override void ze(bool A_0)
	{
		base.Enabled = A_0;
	}

	// Token: 0x0600C091 RID: 49297 RVA: 0x0042BF60 File Offset: 0x0042A160
	protected override bool ag4()
	{
		return true;
	}

	// Token: 0x0600C092 RID: 49298 RVA: 0x0042BF64 File Offset: 0x0042A164
	protected override bool aqf()
	{
		return true;
	}

	// Token: 0x0600C093 RID: 49299 RVA: 0x0042BF68 File Offset: 0x0042A168
	protected override bool aqg()
	{
		return false;
	}

	// Token: 0x0600C094 RID: 49300 RVA: 0x0042BF6C File Offset: 0x0042A16C
	protected override bool aqh()
	{
		return true;
	}

	// Token: 0x0600C095 RID: 49301 RVA: 0x0042BF70 File Offset: 0x0042A170
	public dvx(efk A_0)
	{
		czh.a(A_0, "character");
		this.b = A_0;
		this.b();
	}

	// Token: 0x0600C096 RID: 49302 RVA: 0x0042BF90 File Offset: 0x0042A190
	public dvx(efk A_0, esj A_1, esj A_2) : base(A_1, A_2)
	{
		czh.a(A_0, "character");
		this.b = A_0;
		this.b();
	}

	// Token: 0x0600C097 RID: 49303 RVA: 0x0042BFB4 File Offset: 0x0042A1B4
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if ((this.c -= A_0.a().ElapsedGameTime.TotalMilliseconds) <= 0.0)
		{
			this.c = (double)(100 + cuo.a.Next(100));
			this.a();
		}
	}

	// Token: 0x0600C098 RID: 49304 RVA: 0x0042C018 File Offset: 0x0042A218
	private new void b()
	{
		base.c(bo1.ae);
		base.e(epu.a);
		base.h(Color.Orange);
		base.Color = epu.a;
		base.g(adi.a * 0.5f);
		base.f(adi.a * 0.5f);
		base.a(new Color(0, 0, 255) * 0.5f);
		base.d(new Color(255, 0, 0) * 0.5f);
		base.a(0);
		base.c(Color.Purple * 0.45f);
		this.a();
	}

	// Token: 0x0600C099 RID: 49305 RVA: 0x0042C0D8 File Offset: 0x0042A2D8
	private new void a()
	{
		if (this.b != null && this.b.Gear.h().Item != null)
		{
			this.a = ecf.a(dgk.Get<d0i>(), new dsx(), this.b.Gear.h().Item);
			return;
		}
		this.a = null;
	}

	// Token: 0x0600C09A RID: 49306 RVA: 0x0042C13C File Offset: 0x0042A33C
	protected override void zh(av A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C09B RID: 49307 RVA: 0x0042C148 File Offset: 0x0042A348
	protected override void i0()
	{
		base.i0();
		this.b.Gear.d(new EventHandler<by0>(this.a));
		this.b.Gear.b(new EventHandler<by0>(this.b));
	}

	// Token: 0x0600C09C RID: 49308 RVA: 0x0042C194 File Offset: 0x0042A394
	protected override void i1()
	{
		base.i1();
		this.b.Gear.c(new EventHandler<by0>(this.a));
		this.b.Gear.a(new EventHandler<by0>(this.b));
	}

	// Token: 0x0600C09D RID: 49309 RVA: 0x0042C1E0 File Offset: 0x0042A3E0
	private new void b(object A_0, by0 A_1)
	{
		this.a();
	}

	// Token: 0x0600C09E RID: 49310 RVA: 0x0042C1E8 File Offset: 0x0042A3E8
	private new void a(object A_0, by0 A_1)
	{
		this.a();
	}

	// Token: 0x0600C09F RID: 49311 RVA: 0x0042C1F4 File Offset: 0x0042A3F4
	protected override void rd(object A_0, b25 A_1)
	{
		base.rd(A_0, A_1);
		if (this.a is eu7 && this.a.yw())
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() is c5x)
			{
				cp.b(this.a as eu7, serviceOrThrow.aqu().v().b() as c5x, serviceOrThrow.aqu().v().Gear.h().Item);
			}
		}
	}

	// Token: 0x04004594 RID: 17812
	private new av a;

	// Token: 0x04004595 RID: 17813
	private new efk b;

	// Token: 0x04004596 RID: 17814
	private new double c;
}
