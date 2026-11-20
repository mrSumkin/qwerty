using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200151A RID: 5402
[eiz("SACA")]
[Serializable]
public abstract class d64 : a6k, bgn, ISerializable
{
	// Token: 0x060078D3 RID: 30931 RVA: 0x003291F0 File Offset: 0x003273F0
	protected d64(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("SACA:SPC");
			this.b = A_0.GetInt32("SACA:CSP");
			this.c = A_0.GetDouble("SACA:TL");
			this.d = (EntityAspectReference<amc, amc>)A_0.GetValue("SACA:AR", typeof(EntityAspectReference<amc, amc>));
			this.e = (EntityAspectReference<amc, amc>)A_0.GetValue("SACA:TR", typeof(EntityAspectReference<amc, amc>));
			this.g = A_0.GetBoolean("SACA:S");
			if (ell.a() >= 389)
			{
				this.f = (A_0.GetValue("SACA:TT", typeof(edx)) as edx);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(d64))
			{
				this.a = A_0.GetInt32("_ShootingPhaseCount");
				this.b = A_0.GetInt32("_CurrentShootingPhase");
				this.c = A_0.GetDouble("_TimeLeft");
				this.d = (EntityAspectReference<amc, amc>)A_0.GetValue("_AttackerRef", typeof(EntityAspectReference<amc, amc>));
				this.e = (EntityAspectReference<amc, amc>)A_0.GetValue("_TargetRef", typeof(EntityAspectReference<amc, amc>));
				this.g = A_0.GetBoolean("_Started");
				return;
			}
			this.a = A_0.GetInt32("SpecialAttackCastAction+_ShootingPhaseCount");
			this.b = A_0.GetInt32("SpecialAttackCastAction+_CurrentShootingPhase");
			this.c = A_0.GetDouble("SpecialAttackCastAction+_TimeLeft");
			this.d = (EntityAspectReference<amc, amc>)A_0.GetValue("SpecialAttackCastAction+_AttackerRef", typeof(EntityAspectReference<amc, amc>));
			this.e = (EntityAspectReference<amc, amc>)A_0.GetValue("SpecialAttackCastAction+_TargetRef", typeof(EntityAspectReference<amc, amc>));
			this.g = A_0.GetBoolean("SpecialAttackCastAction+_Started");
		}
	}

	// Token: 0x060078D4 RID: 30932 RVA: 0x003293E8 File Offset: 0x003275E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SACA:SPC", this.a);
		info.AddValue("SACA:CSP", this.b);
		info.AddValue("SACA:TL", this.c);
		info.AddValue("SACA:AR", this.d);
		info.AddValue("SACA:TR", this.e);
		info.AddValue("SACA:S", this.g);
		info.AddValue("SACA:TT", this.f);
	}

	// Token: 0x060078D5 RID: 30933 RVA: 0x00329474 File Offset: 0x00327674
	public int? tm()
	{
		return new int?(this.b);
	}

	// Token: 0x060078D6 RID: 30934 RVA: 0x00329484 File Offset: 0x00327684
	public virtual CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack1);
	}

	// Token: 0x060078D7 RID: 30935 RVA: 0x0032948C File Offset: 0x0032768C
	public amc c()
	{
		return this.d.ao();
	}

	// Token: 0x060078D8 RID: 30936 RVA: 0x0032949C File Offset: 0x0032769C
	public amc b()
	{
		if (this.e != null)
		{
			return this.e.ao();
		}
		return null;
	}

	// Token: 0x060078D9 RID: 30937 RVA: 0x003294B8 File Offset: 0x003276B8
	public ak1 d()
	{
		if (this.f != null)
		{
			return this.f.ao();
		}
		return null;
	}

	// Token: 0x060078DA RID: 30938 RVA: 0x003294D4 File Offset: 0x003276D4
	protected override dc4 dt()
	{
		this.d = new EntityAspectReference<amc, amc>(base.vg().q().h.b);
		if (this.c() != null)
		{
			this.a = this.c().e[CharacterState.Attack1].a;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			this.e = new EntityAspectReference<amc, amc>(c5x.h.b);
		}
		ak1 ak = base.vg().h() as ak1;
		if (ak != null)
		{
			this.f = new edx(ak);
		}
		if ((this.b() == null && this.d() == null) || this.c() == null)
		{
			return dc4.e;
		}
		this.b = 0;
		this.c = (double)dz6.b(cux.m);
		return dc4.b;
	}

	// Token: 0x060078DB RID: 30939 RVA: 0x003295B4 File Offset: 0x003277B4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (!this.g)
		{
			this.g = true;
			if (this.gq())
			{
				bool flag = true;
				if (base.vg().e() != null)
				{
					bon bon = base.vg().e().p() as bon;
					if (bon != null)
					{
						flag = bon.l8();
					}
				}
				if (flag)
				{
					awq.a(this.c(), this.c().aa().Offense.u());
				}
			}
		}
		if ((this.c -= A_1.TotalMilliseconds) <= 0.0)
		{
			this.b++;
			if (this.b >= this.a)
			{
				this.a();
				return dc4.c;
			}
			if (this.b == this.a / 2)
			{
				this.bf();
			}
			this.c = (double)dz6.b(cux.m);
		}
		return dc4.b;
	}

	// Token: 0x060078DC RID: 30940 RVA: 0x003296B4 File Offset: 0x003278B4
	protected virtual bool gq()
	{
		if (this.c() == null || (this.d() == null && (this.b() == null || this.b().aa().Dead)))
		{
			return false;
		}
		if (this.c() != null)
		{
			this.c().aa().Offense.az();
		}
		string text = this.c().aa().Offense.u().TypedDefinition.b();
		if (!string.IsNullOrEmpty(text))
		{
			ay7 ay = ckf.a(text);
			if (ay != null)
			{
				ay.ae(this.c(), this.b(), this.c().aa().Offense.u(), this.c().aa().Offense.u().CurrentBullet);
			}
		}
		return true;
	}

	// Token: 0x060078DD RID: 30941 RVA: 0x00329798 File Offset: 0x00327998
	protected virtual void a()
	{
	}

	// Token: 0x060078DE RID: 30942 RVA: 0x0032979C File Offset: 0x0032799C
	protected virtual void bf()
	{
	}

	// Token: 0x060078DF RID: 30943 RVA: 0x003297A0 File Offset: 0x003279A0
	protected d64()
	{
	}

	// Token: 0x0400306F RID: 12399
	private new int a;

	// Token: 0x04003070 RID: 12400
	private int b;

	// Token: 0x04003071 RID: 12401
	private double c;

	// Token: 0x04003072 RID: 12402
	private EntityAspectReference<amc, amc> d;

	// Token: 0x04003073 RID: 12403
	private EntityAspectReference<amc, amc> e;

	// Token: 0x04003074 RID: 12404
	private edx f;

	// Token: 0x04003075 RID: 12405
	private bool g;
}
