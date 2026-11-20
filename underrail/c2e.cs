using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200143F RID: 5183
[eiz("UWA")]
[Serializable]
public abstract class c2e : azp, bgn, ISerializable
{
	// Token: 0x0600747B RID: 29819 RVA: 0x0031692C File Offset: 0x00314B2C
	protected c2e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (c1k)A_0.GetValue("UWA:US", typeof(c1k));
		this.b = A_0.GetDouble("UWA:TL");
		this.c = A_0.GetInt32("UWA:CSP");
		this.e = A_0.GetInt32("UWA:SPC");
		this.f = A_0.GetInt32("UWA:WUFD");
		this.g = (CharacterState)A_0.GetValue("UWA:AS", typeof(CharacterState));
		this.h = A_0.GetInt32("UWA:D");
		this.i = A_0.GetBoolean("UWA:TB");
		di7.ReadEvent<EventArgs>("UWA:WUS", ref this.k, A_0);
		if (ell.b() >= 122)
		{
			this.j = A_0.GetBoolean("UWA:P");
		}
		this.d = A_0.GetInt32("UWA:MP");
	}

	// Token: 0x0600747C RID: 29820 RVA: 0x00316A28 File Offset: 0x00314C28
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UWA:US", this.a);
		info.AddValue("UWA:TL", this.b);
		info.AddValue("UWA:CSP", this.c);
		info.AddValue("UWA:SPC", this.e);
		info.AddValue("UWA:WUFD", this.f);
		info.AddValue("UWA:AS", this.g);
		info.AddValue("UWA:MP", this.d);
		info.AddValue("UWA:D", this.h);
		info.AddValue("UWA:TB", this.i);
		info.AddValue("UWA:P", this.j);
		di7.WriteEvent<EventArgs>("UWA:WUS", this.k, info);
	}

	// Token: 0x0600747D RID: 29821 RVA: 0x00316B04 File Offset: 0x00314D04
	public CharacterState i()
	{
		return this.g;
	}

	// Token: 0x0600747E RID: 29822 RVA: 0x00316B0C File Offset: 0x00314D0C
	protected c1k h()
	{
		return this.a;
	}

	// Token: 0x0600747F RID: 29823 RVA: 0x00316B18 File Offset: 0x00314D18
	public virtual int? tm()
	{
		if (this.a == c1k.c)
		{
			return new int?(this.c);
		}
		if (this.a == c1k.e)
		{
			int? primitivePropertyValue = this.f().u().TypedDefinition.a7().GetPrimitivePropertyValue<int>("AfterAttackHoldPhase", null);
			if (primitivePropertyValue != null)
			{
				return new int?(primitivePropertyValue.Value);
			}
		}
		return new int?(0);
	}

	// Token: 0x06007480 RID: 29824 RVA: 0x00316B94 File Offset: 0x00314D94
	public CharacterState? q1()
	{
		return new CharacterState?(this.g);
	}

	// Token: 0x06007481 RID: 29825 RVA: 0x00316BA4 File Offset: 0x00314DA4
	public override m7 kh()
	{
		return m7.d;
	}

	// Token: 0x06007482 RID: 29826 RVA: 0x00316BAC File Offset: 0x00314DAC
	private dcu f()
	{
		return base.n().a8().h.b.aa().Offense;
	}

	// Token: 0x06007483 RID: 29827 RVA: 0x00316BD8 File Offset: 0x00314DD8
	public object fm()
	{
		if (base.m() != null)
		{
			return base.m().a8();
		}
		return null;
	}

	// Token: 0x06007484 RID: 29828 RVA: 0x00316BF4 File Offset: 0x00314DF4
	public virtual ci8? oi()
	{
		return new ci8?(ci8.c);
	}

	// Token: 0x06007485 RID: 29829 RVA: 0x00316BFC File Offset: 0x00314DFC
	public static int e()
	{
		return dz6.b(200);
	}

	// Token: 0x06007486 RID: 29830 RVA: 0x00316C0C File Offset: 0x00314E0C
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.k;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.k, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06007487 RID: 29831 RVA: 0x00316C44 File Offset: 0x00314E44
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.k;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.k, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06007488 RID: 29832 RVA: 0x00316C7C File Offset: 0x00314E7C
	public c2e(amc A_0, amc A_1) : base(A_0, A_1)
	{
		this.e = base.n().a8().h.b.e[CharacterState.Attack1].a;
		this.b();
	}

	// Token: 0x06007489 RID: 29833 RVA: 0x00316CC4 File Offset: 0x00314EC4
	protected override dc4 dt()
	{
		if (base.n() == null || base.n().a8() == null || base.m() == null || base.m().a8() == null)
		{
			return dc4.e;
		}
		this.a = c1k.a;
		bool flag = true;
		d02 service = bpo.GetService<d02>();
		if (!string.IsNullOrEmpty(base.n().aa().Offense.u().TypedDefinition.b()))
		{
			dkf dkf = ckf.a(base.n().aa().Offense.u().TypedDefinition.b()) as dkf;
			if (dkf != null && dkf.o9())
			{
				flag = false;
				if (service != null && service.ahg())
				{
					d4n d4n = service.ahu(base.n().aa());
					if (d4n != null)
					{
						int? num = dkf.pb(base.n());
						if (num != null && (double)num.Value > d4n.c)
						{
							return dc4.e;
						}
					}
				}
			}
		}
		this.j = base.n().a8().IsPlayer;
		if (service != null && service.ahg())
		{
			if (flag && !this.a())
			{
				if (base.n().aa() is e3q)
				{
					bmj.a(base.n().a8(), new cwl());
				}
				return dc4.e;
			}
			this.h = this.to();
			this.i = true;
		}
		else
		{
			int a_ = base.n().aa().Offense.av();
			dz6.a(base.n(), a_, false, 2000, false, false);
		}
		this.g = this.tp();
		return dc4.b;
	}

	// Token: 0x0600748A RID: 29834 RVA: 0x00316E8C File Offset: 0x0031508C
	protected virtual int to()
	{
		return 0;
	}

	// Token: 0x0600748B RID: 29835 RVA: 0x00316E94 File Offset: 0x00315094
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.n() == null || base.m() == null)
		{
			return dc4.e;
		}
		aw1.b(base.n().a8(), base.m().a8(), false);
		if (this.a == c1k.a)
		{
			if (this.h == 0 && this.f().ap())
			{
				if (this.c())
				{
					return dc4.e;
				}
			}
			else
			{
				this.d();
			}
		}
		else if (this.a == c1k.b)
		{
			if ((this.b -= A_1.TotalMilliseconds) <= 0.0)
			{
				if (!this.i && !this.j)
				{
					return dc4.c;
				}
				if (this.c())
				{
					return dc4.e;
				}
			}
		}
		else if (this.a == c1k.c)
		{
			if ((this.b -= A_1.TotalMilliseconds) <= 0.0)
			{
				int num = this.c + 1;
				this.c = num;
				if (num >= this.e)
				{
					if (this.g())
					{
						return dc4.e;
					}
					if (this.i && this.h > 0)
					{
						this.b = (double)this.h;
						this.a = c1k.e;
						return dc4.b;
					}
					return dc4.c;
				}
				else
				{
					if (this.c == this.d && this.ap4())
					{
						return dc4.e;
					}
					this.b = (double)this.f;
				}
			}
		}
		else if (this.a == c1k.e && (this.b -= A_1.TotalMilliseconds) <= 0.0)
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x0600748C RID: 29836 RVA: 0x00317058 File Offset: 0x00315258
	protected virtual bool tn()
	{
		a20.a(base.n(), base.m());
		this.f().az();
		return false;
	}

	// Token: 0x0600748D RID: 29837 RVA: 0x00317084 File Offset: 0x00315284
	protected virtual bool ap4()
	{
		return false;
	}

	// Token: 0x0600748E RID: 29838 RVA: 0x00317088 File Offset: 0x00315288
	protected virtual bool g()
	{
		return false;
	}

	// Token: 0x0600748F RID: 29839
	protected abstract CharacterState tp();

	// Token: 0x06007490 RID: 29840 RVA: 0x0031708C File Offset: 0x0031528C
	public bool l()
	{
		d02 service = bpo.GetService<d02>();
		if (service != null && service.ahg())
		{
			d4n d4n = service.ahu(base.n().aa());
			if (d4n != null && d4n.b != null)
			{
				int num = d4n.b.aa().Offense.av();
				return d4n.c >= (double)num;
			}
		}
		return true;
	}

	// Token: 0x06007491 RID: 29841 RVA: 0x003170FC File Offset: 0x003152FC
	private void d()
	{
		this.a = c1k.b;
		if (this.i)
		{
			this.b = (double)this.h;
			return;
		}
		this.b = Math.Min((double)c2e.e(), this.f().i());
	}

	// Token: 0x06007492 RID: 29842 RVA: 0x00317140 File Offset: 0x00315340
	private bool c()
	{
		if (base.m().aa().Dead)
		{
			return true;
		}
		this.e = base.n().a8().h.b.e[this.g].a;
		this.d = (int)Math.Ceiling((double)this.e / 2.0);
		this.b();
		this.a = c1k.c;
		this.c = 0;
		this.b = (double)this.f;
		if (this.k != null)
		{
			this.k(this, new EventArgs());
		}
		return this.tn() || (this.d == 0 && this.ap4());
	}

	// Token: 0x06007493 RID: 29843 RVA: 0x00317214 File Offset: 0x00315414
	private void b()
	{
		if (this.e > 0)
		{
			this.f = (int)Math.Min(this.f().u().TypedDefinition.an() * 1000f / (float)this.e, (float)dz6.b(cux.m));
			return;
		}
		this.f = dz6.b(cux.m);
	}

	// Token: 0x06007494 RID: 29844 RVA: 0x00317278 File Offset: 0x00315478
	private bool a()
	{
		d02 service = bpo.GetService<d02>();
		if (service != null && service.ahg())
		{
			d4n d4n = service.ahu(base.n().aa());
			if (d4n != null && d4n.b != null)
			{
				int num = base.n().aa().Offense.av();
				if (d4n.c < (double)num)
				{
					return false;
				}
				if (eub.a(base.n().aa().Offense.u()) || eub.b(base.n().aa(), base.n().aa().Offense.u()))
				{
					d4n.a(num, true);
				}
			}
		}
		return true;
	}

	// Token: 0x04002F98 RID: 12184
	private new c1k a;

	// Token: 0x04002F99 RID: 12185
	protected double b;

	// Token: 0x04002F9A RID: 12186
	private int c;

	// Token: 0x04002F9B RID: 12187
	private int d;

	// Token: 0x04002F9C RID: 12188
	private int e;

	// Token: 0x04002F9D RID: 12189
	private int f;

	// Token: 0x04002F9E RID: 12190
	private CharacterState g;

	// Token: 0x04002F9F RID: 12191
	private int h;

	// Token: 0x04002FA0 RID: 12192
	private bool i;

	// Token: 0x04002FA1 RID: 12193
	private new bool j;

	// Token: 0x04002FA2 RID: 12194
	[CompilerGenerated]
	private new EventHandler<EventArgs> k;
}
