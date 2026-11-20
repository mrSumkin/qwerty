using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200145D RID: 5213
[eiz("CTA")]
[Serializable]
public abstract class boa : a6k, bgn, ISerializable
{
	// Token: 0x06007577 RID: 30071 RVA: 0x0031C548 File Offset: 0x0031A748
	protected boa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (afq)A_0.GetValue("CTA:TA", typeof(afq));
			this.b = A_0.GetDouble("CTA:TP");
			this.c = A_0.GetDouble("CTA:TTP");
			di7.ReadArray<evd>("CTA:V", ref this.d, A_0);
			this.e = A_0.GetBoolean("CTA:A");
			this.f = A_0.GetInt32("CTA:IP");
			this.g = A_0.GetDouble("CTA:IPC");
			this.h = A_0.GetInt32("CTA:P");
			return;
		}
		if (base.GetType() == typeof(boa))
		{
			this.a = (afq)A_0.GetValue("_TickAction", typeof(afq));
			this.b = A_0.GetDouble("_TimePassed");
			this.c = A_0.GetDouble("_TickTimePassed");
			this.d = (evd[])A_0.GetValue("_Validators", typeof(evd[]));
			this.e = A_0.GetBoolean("_Abort");
			this.f = A_0.GetInt32("_InvokerPhase");
			this.g = A_0.GetDouble("_InvokerPhaseCache");
			this.h = A_0.GetInt32("_Pushback");
			return;
		}
		this.a = (afq)A_0.GetValue("ChannellingTickingAction+_TickAction", typeof(afq));
		this.b = A_0.GetDouble("ChannellingTickingAction+_TimePassed");
		this.c = A_0.GetDouble("ChannellingTickingAction+_TickTimePassed");
		this.d = (evd[])A_0.GetValue("ChannellingTickingAction+_Validators", typeof(evd[]));
		this.e = A_0.GetBoolean("ChannellingTickingAction+_Abort");
		this.f = A_0.GetInt32("ChannellingTickingAction+_InvokerPhase");
		this.g = A_0.GetDouble("ChannellingTickingAction+_InvokerPhaseCache");
		this.h = A_0.GetInt32("ChannellingTickingAction+_Pushback");
	}

	// Token: 0x06007578 RID: 30072 RVA: 0x0031C768 File Offset: 0x0031A968
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CTA:TA", this.a);
		info.AddValue("CTA:TP", this.b);
		info.AddValue("CTA:TTP", this.c);
		di7.WriteArray<evd>("CTA:V", this.d, info);
		info.AddValue("CTA:A", this.e);
		info.AddValue("CTA:IP", this.f);
		info.AddValue("CTA:IPC", this.g);
		info.AddValue("CTA:P", this.h);
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x06007579 RID: 30073 RVA: 0x0031C808 File Offset: 0x0031AA08
	public int ChannellingTime
	{
		get
		{
			return dz6.a(this.a.vg().e().e());
		}
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x0600757A RID: 30074 RVA: 0x0031C824 File Offset: 0x0031AA24
	public int ChannellingTickTime
	{
		get
		{
			return dz6.b(this.a.vg().e().k());
		}
	}

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x0600757B RID: 30075 RVA: 0x0031C840 File Offset: 0x0031AA40
	public double TimePassed
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x0600757C RID: 30076 RVA: 0x0031C848 File Offset: 0x0031AA48
	public virtual int? InvokerPhase
	{
		get
		{
			return new int?(this.f);
		}
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x0600757D RID: 30077
	public abstract CharacterState? InvokerState { get; }

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x0600757E RID: 30078 RVA: 0x0031C858 File Offset: 0x0031AA58
	public evd[] Validators
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x0600757F RID: 30079 RVA: 0x0031C860 File Offset: 0x0031AA60
	public virtual bool ShouldValidateProxy
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06007580 RID: 30080 RVA: 0x0031C868 File Offset: 0x0031AA68
	protected boa(ad5 A_0, afq A_1, params evd[] A_2) : base(A_0)
	{
		czh.a(A_1, "tickAction");
		this.a = A_1;
		this.a.o(new EventHandler<EventArgs>(this.a));
		this.d = A_2;
		if (this.d != null)
		{
			evd[] array = this.d;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].gm(new EventHandler<EventArgs>(this.b));
			}
		}
	}

	// Token: 0x06007581 RID: 30081 RVA: 0x0031C8E8 File Offset: 0x0031AAE8
	public void a(int A_0)
	{
		this.b += (double)A_0;
		this.h += A_0;
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06007582 RID: 30082 RVA: 0x0031C908 File Offset: 0x0031AB08
	public virtual int DefaultChannellingPhaseStep
	{
		get
		{
			return dz6.b(cux.e);
		}
	}

	// Token: 0x06007583 RID: 30083 RVA: 0x0031C918 File Offset: 0x0031AB18
	protected override dc4 dt()
	{
		this.b = 0.0;
		this.c = 0.0;
		this.e = false;
		this.f = this.a();
		this.g = this.b();
		dqw dqw = base.vg().c();
		if (dqw != null && dqw.mk())
		{
			this.c = (double)this.ChannellingTickTime * 0.9;
		}
		return dc4.b;
	}

	// Token: 0x06007584 RID: 30084 RVA: 0x0031C998 File Offset: 0x0031AB98
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.e)
		{
			this.c();
			return dc4.e;
		}
		base.vg().i();
		this.a(A_1.TotalMilliseconds);
		this.b += A_1.TotalMilliseconds;
		this.c += A_1.TotalMilliseconds;
		dqw dqw = base.vg().c();
		if (dqw != null && dqw.mk() && this.b >= (double)this.ChannellingTime)
		{
			this.c();
			return dc4.c;
		}
		while (this.c >= (double)this.ChannellingTickTime)
		{
			this.c -= (double)this.ChannellingTickTime;
			if (this.ShouldValidateProxy && !base.vg().o())
			{
				this.c();
				return dc4.e;
			}
			if (this.d != null)
			{
				evd[] array = this.d;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].go(base.vg());
				}
			}
			if (!string.IsNullOrEmpty(base.vg().p()))
			{
				base.vg().q().c().a(base.vg().p());
			}
			this.g();
			base.vg().t();
		}
		if (this.b >= (double)this.ChannellingTime)
		{
			this.c();
			return dc4.c;
		}
		if (this.ShouldValidateProxy && !base.vg().o())
		{
			this.c();
			return dc4.e;
		}
		return dc4.b;
	}

	// Token: 0x06007585 RID: 30085 RVA: 0x0031CB34 File Offset: 0x0031AD34
	protected virtual void g()
	{
		base.y().g9(this.a, atp.a);
	}

	// Token: 0x06007586 RID: 30086 RVA: 0x0031CB4C File Offset: 0x0031AD4C
	private void c()
	{
		if (this.d != null)
		{
			evd[] array = this.d;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].gn(new EventHandler<EventArgs>(this.b));
			}
		}
	}

	// Token: 0x06007587 RID: 30087 RVA: 0x0031CB94 File Offset: 0x0031AD94
	private void a(double A_0)
	{
		if ((this.g -= A_0) < 0.0)
		{
			this.g = this.b();
			int num = this.f + 1;
			this.f = num;
			if (num == 2147483647)
			{
				this.f = 0;
			}
		}
	}

	// Token: 0x06007588 RID: 30088 RVA: 0x0031CBF0 File Offset: 0x0031ADF0
	private double b()
	{
		dqw dqw = base.vg().c();
		if (dqw != null)
		{
			int? num = dqw.g4();
			if (num != null)
			{
				return (double)num.Value;
			}
		}
		return (double)this.DefaultChannellingPhaseStep;
	}

	// Token: 0x06007589 RID: 30089 RVA: 0x0031CC34 File Offset: 0x0031AE34
	private int a()
	{
		dqw dqw = base.vg().c();
		if (dqw != null)
		{
			int? num = dqw.xv();
			if (num != null)
			{
				return num.Value;
			}
		}
		return 0;
	}

	// Token: 0x0600758A RID: 30090 RVA: 0x0031CC70 File Offset: 0x0031AE70
	[dcc("CTA:mVV")]
	private void b(object A_0, EventArgs A_1)
	{
		bool? flag = ((evd)A_0).gl();
		bool flag2 = false;
		this.e = (flag.GetValueOrDefault() == flag2 & flag != null);
	}

	// Token: 0x0600758B RID: 30091 RVA: 0x0031CCA4 File Offset: 0x0031AEA4
	[dcc("CTA:mTAF")]
	private void a(object A_0, EventArgs A_1)
	{
		this.e = true;
	}

	// Token: 0x04003014 RID: 12308
	private new afq a;

	// Token: 0x04003015 RID: 12309
	private double b;

	// Token: 0x04003016 RID: 12310
	private double c;

	// Token: 0x04003017 RID: 12311
	private evd[] d;

	// Token: 0x04003018 RID: 12312
	private bool e;

	// Token: 0x04003019 RID: 12313
	private int f;

	// Token: 0x0400301A RID: 12314
	private double g;

	// Token: 0x0400301B RID: 12315
	private int h;
}
