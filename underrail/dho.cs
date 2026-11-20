using System;
using System.Linq;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001FF7 RID: 8183
public sealed class dho : eb1
{
	// Token: 0x0600C0D8 RID: 49368 RVA: 0x0042D03C File Offset: 0x0042B23C
	public override av zc()
	{
		return this.c;
	}

	// Token: 0x0600C0D9 RID: 49369 RVA: 0x0042D044 File Offset: 0x0042B244
	public override bool zd()
	{
		return base.Enabled;
	}

	// Token: 0x0600C0DA RID: 49370 RVA: 0x0042D04C File Offset: 0x0042B24C
	public override void ze(bool A_0)
	{
		base.Enabled = A_0;
	}

	// Token: 0x0600C0DB RID: 49371 RVA: 0x0042D058 File Offset: 0x0042B258
	public override bool aj9()
	{
		return this.e == 6;
	}

	// Token: 0x0600C0DC RID: 49372 RVA: 0x0042D064 File Offset: 0x0042B264
	public dho(efk A_0, int A_1, esj A_2, esj A_3) : base(A_2, A_3)
	{
		czh.a(A_0, "character");
		this.d = A_0;
		this.e = A_1;
		this.b();
	}

	// Token: 0x0600C0DD RID: 49373 RVA: 0x0042D090 File Offset: 0x0042B290
	public dho(efk A_0, int A_1)
	{
		czh.a(A_0, "character");
		this.d = A_0;
		this.e = A_1;
		this.b();
	}

	// Token: 0x0600C0DE RID: 49374 RVA: 0x0042D0BC File Offset: 0x0042B2BC
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if ((this.f -= A_0.a().ElapsedGameTime.TotalMilliseconds) <= 0.0)
		{
			this.f = (double)(100 + dho.a.Next(100));
			this.a();
		}
	}

	// Token: 0x0600C0DF RID: 49375 RVA: 0x0042D120 File Offset: 0x0042B320
	public override bool aka()
	{
		if (this.zc() == null)
		{
			return false;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null || serviceOrThrow.aqu().v() == null || serviceOrThrow.aqu().v().b() == null)
		{
			return true;
		}
		eoj a_ = new eoj(serviceOrThrow.aqu().v(), this.zc().b9(), serviceOrThrow.aqu().v().b() as c5x);
		return this.zc().yw() && this.zc().p().hm(a_);
	}

	// Token: 0x0600C0E0 RID: 49376 RVA: 0x0042D1C8 File Offset: 0x0042B3C8
	private new void b()
	{
		this.a();
	}

	// Token: 0x0600C0E1 RID: 49377 RVA: 0x0042D1D4 File Offset: 0x0042B3D4
	private new void a()
	{
		if (this.e < 6)
		{
			string text;
			string a_;
			this.a(out text, out a_);
			if (text == null)
			{
				this.c = null;
				base.d(true);
				return;
			}
			base.d(false);
			coh coh = Enumerable.FirstOrDefault<coh>(this.d.Bag.b(text));
			if (coh == null)
			{
				base.a(new Color?(Color.Black));
				base.b(true);
				coh = this.a(a_);
			}
			else
			{
				base.b(false);
				base.a(null);
			}
			if (coh != null && coh.Definition.a2().Count > 0 && coh.Definition.a2()[0].Value != null)
			{
				this.c = ecf.a(coh.Definition.a2()[1].Value, new dsx(), coh);
				return;
			}
			this.c = null;
			return;
		}
		else
		{
			if ((eub.c(this.d.Offense.u()) || eub.d(this.d.Offense.u().TypedDefinition.ak())) && this.d.Offense.u().TypedDefinition.a2().Count > 0)
			{
				this.c = ecf.a(this.d.Offense.u().TypedDefinition.a2()[0].Value, new dsx(), this.d.Offense.u());
				base.b(false);
				base.a(null);
				base.d(false);
				return;
			}
			this.c = null;
			base.d(true);
			return;
		}
	}

	// Token: 0x0600C0E2 RID: 49378 RVA: 0x0042D3A8 File Offset: 0x0042B5A8
	private new coh a(string A_0)
	{
		if (this.g == null || this.h != A_0)
		{
			this.h = A_0;
			bit bit = ez2.CreateDefinitonProvider<dj3>(A_0);
			if (bit != null)
			{
				this.g = coh.a(bit);
			}
			else
			{
				this.g = null;
			}
		}
		return this.g;
	}

	// Token: 0x0600C0E3 RID: 49379 RVA: 0x0042D404 File Offset: 0x0042B604
	private new void a(out string A_0, out string A_1)
	{
		A_1 = null;
		A_0 = null;
		if (this.d.Offense.u().MaxBattery <= 0)
		{
			if (eub.c(this.d.Offense.u()))
			{
				int num = (int)(this.d.Offense.u().TypedDefinition.ak() + this.e);
				AmmoType a_;
				if (Enum.IsDefined(typeof(AmmoType), num) && Enum.TryParse<AmmoType>(num.ToString(), out a_))
				{
					if (eub.b(a_) || eub.a(a_))
					{
						A_1 = "Ammo\\Xphw\\" + a_.ToString();
					}
					else if (eub.c(a_))
					{
						A_1 = "Ammo\\Xpbl\\" + a_.ToString();
					}
					else
					{
						A_1 = "Ammo\\" + a_.ToString();
					}
					A_0 = "Ammo." + a_.ToString();
					return;
				}
			}
			else if (eub.d(this.d.Offense.u().TypedDefinition.ak()))
			{
				int num2 = (int)(this.d.Offense.u().TypedDefinition.ak() + this.e);
				if (this.e == 1 && !Enum.IsDefined(typeof(AmmoType), num2))
				{
					num2 = (int)this.d.Offense.u().TypedDefinition.ak();
				}
				AmmoType ammoType;
				if (Enum.IsDefined(typeof(AmmoType), num2) && Enum.TryParse<AmmoType>(num2.ToString(), out ammoType))
				{
					if (num2 == 1003)
					{
						if (!dk2.f())
						{
							return;
						}
						A_1 = "Ammo\\Xpbl\\" + ammoType.ToString();
					}
					else
					{
						A_1 = "Ammo\\" + ammoType.ToString();
					}
					A_0 = "Ammo." + ammoType.ToString();
				}
			}
			return;
		}
		if (this.e < 5)
		{
			string str = dho.b[this.e - 1];
			A_0 = "Battery." + str;
			A_1 = "Expendables\\EnergySources\\" + str;
			return;
		}
		A_1 = null;
		A_0 = null;
	}

	// Token: 0x0600C0E4 RID: 49380 RVA: 0x0042D688 File Offset: 0x0042B888
	protected override void zh(av A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600C0E5 RID: 49381 RVA: 0x0042D694 File Offset: 0x0042B894
	protected override void i0()
	{
		base.i0();
		this.d.Offense.b(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x0600C0E6 RID: 49382 RVA: 0x0042D6B8 File Offset: 0x0042B8B8
	protected override void i1()
	{
		base.i1();
		this.d.Offense.a(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x0600C0E7 RID: 49383 RVA: 0x0042D6DC File Offset: 0x0042B8DC
	private new void a(object A_0, EventArgs A_1)
	{
		this.a();
	}

	// Token: 0x040045B5 RID: 17845
	private new static Random a = new Random();

	// Token: 0x040045B6 RID: 17846
	private new static readonly string[] b = new string[]
	{
		"ScLiCell",
		"FusionCell",
		"PlasmaCell",
		"GreaterFusionCell"
	};

	// Token: 0x040045B7 RID: 17847
	private new av c;

	// Token: 0x040045B8 RID: 17848
	private new efk d;

	// Token: 0x040045B9 RID: 17849
	private new int e;

	// Token: 0x040045BA RID: 17850
	private new double f;

	// Token: 0x040045BB RID: 17851
	private new coh g;

	// Token: 0x040045BC RID: 17852
	private new string h;
}
