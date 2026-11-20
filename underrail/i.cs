using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000F89 RID: 3977
[eiz("DPEA")]
[Serializable]
public sealed class i : Aspect<c5x>, c98, chb
{
	// Token: 0x060050FE RID: 20734 RVA: 0x0024752C File Offset: 0x0024572C
	private i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("DPEA:T");
		this.a = A_0.GetDouble("DPEA:C");
		this.c = (A_0.GetValue("DPEA:D", typeof(ar7)) as ar7);
		this.d = A_0.GetString("DPEA:W");
		this.e = A_0.GetBoolean("DPEA:R");
		this.f = A_0.GetString("DPEA:M");
		this.g = (A_0.GetValue("DPEA:P", typeof(Guid?)) as Guid?);
		if (ell.a() >= 307)
		{
			this.h = A_0.GetString("DPEA:N");
		}
	}

	// Token: 0x060050FF RID: 20735 RVA: 0x00247604 File Offset: 0x00245804
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DPEA:T", this.b);
		info.AddValue("DPEA:C", this.a);
		info.AddValue("DPEA:D", this.c);
		info.AddValue("DPEA:W", this.d);
		info.AddValue("DPEA:R", this.e);
		info.AddValue("DPEA:M", this.f);
		info.AddValue("DPEA:P", this.g);
		info.AddValue("DPEA:N", this.h);
	}

	// Token: 0x06005100 RID: 20736 RVA: 0x002476A8 File Offset: 0x002458A8
	public string b()
	{
		return this.d;
	}

	// Token: 0x06005101 RID: 20737 RVA: 0x002476B0 File Offset: 0x002458B0
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005102 RID: 20738 RVA: 0x002476BC File Offset: 0x002458BC
	public bool g()
	{
		return this.e;
	}

	// Token: 0x06005103 RID: 20739 RVA: 0x002476C4 File Offset: 0x002458C4
	public void b(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005104 RID: 20740 RVA: 0x002476D0 File Offset: 0x002458D0
	public string f()
	{
		return this.f;
	}

	// Token: 0x06005105 RID: 20741 RVA: 0x002476D8 File Offset: 0x002458D8
	public void a(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005106 RID: 20742 RVA: 0x002476E4 File Offset: 0x002458E4
	public Guid? d()
	{
		return this.g;
	}

	// Token: 0x06005107 RID: 20743 RVA: 0x002476EC File Offset: 0x002458EC
	public void a(Guid? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005108 RID: 20744 RVA: 0x002476F8 File Offset: 0x002458F8
	public string e()
	{
		return this.h;
	}

	// Token: 0x06005109 RID: 20745 RVA: 0x00247700 File Offset: 0x00245900
	public void c(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600510A RID: 20746 RVA: 0x0024770C File Offset: 0x0024590C
	public i(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600510B RID: 20747 RVA: 0x00247720 File Offset: 0x00245920
	public void r7(eds A_0)
	{
		if (!this.a() && this.c != null)
		{
			c5x c5x = this.c.ao() as c5x;
			if (c5x != null && c5x.j == cgy.b && c5x.h.b != null && !c5x.h.b.aa().Dead)
			{
				c5x.w();
				c5x.an();
			}
			this.c = null;
		}
		if (!dz6.e())
		{
			if ((this.a -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.a += 500.0;
				this.a(false);
				return;
			}
		}
		else
		{
			this.a = (double)d0u.b;
		}
	}

	// Token: 0x0600510C RID: 20748 RVA: 0x00247804 File Offset: 0x00245A04
	public void c()
	{
		this.a(true);
	}

	// Token: 0x0600510D RID: 20749 RVA: 0x00247810 File Offset: 0x00245A10
	private bool a()
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc-tl_doppelgangersActive", new bool?(false)).Value;
			flag &= base.a8().a();
		}
		return flag;
	}

	// Token: 0x0600510E RID: 20750 RVA: 0x00247864 File Offset: 0x00245A64
	private void a(bool A_0 = false)
	{
		if (this.a())
		{
			c5x c5x = null;
			if (this.c != null)
			{
				c5x = (this.c.ao() as c5x);
			}
			if (c5x == null || c5x.j != cgy.b || (c5x.h.b != null && c5x.h.b.aa().Dead))
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x2 != null && c5x2.t.b != null)
					{
						c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\creature\\psionicDoppelganger");
						if (c5k != null)
						{
							bt4 bt = new bt4(this.d);
							aud aud;
							Vector3 a_;
							HorizontalDirection a_2;
							bt.a(base.a8().Zone, out aud, out a_, out a_2);
							if (aud != null)
							{
								ak1 ak = aud.a(a_.a());
								if (ak != null && !c5x2.t.b.a(ak))
								{
									c5x = (c5k.a(null, false) as c5x);
									if (c5x != null)
									{
										c5x.q("Psionic Projection");
										c5x.Location = a_;
										c5x.Layer = aju.x;
										c5x.VisualDirection = a_2;
										if (c5x.h.b != null)
										{
											c5x.h.b.aa().FactionId = asp.d;
											c5x.h.b.a(this.f);
											c5x.h.b.aa().Gender = Gender.Genderless;
											c5x.h.b.aa().BaseSightRange = 2f;
											c5x.h.b.aa().BaseMovementSpeed = 0.6f;
											c5x.h.b.aa().Offense.h(-5);
											if (c5x.h.b.aa().Gear.j()[WeaponKey.Primary].Item != null)
											{
												c5x.h.b.aa().Gear.j()[WeaponKey.Primary].Item.TypedDefinition.l().Clear();
												c5x.h.b.aa().Gear.j()[WeaponKey.Primary].Item.TypedDefinition.l().Add(new a1q(DamageType.Electricity, 20, 40));
												c5x.h.b.aa().bl();
											}
											c5x.h.b.aa().StatusEffects.a(new dlo(0), false, false, false);
											if (!string.IsNullOrEmpty(this.h))
											{
												c5x.q(this.h);
												c5x.h.b.aa().Name = this.h;
											}
										}
										if (c5x.t.b != null)
										{
											c5x.t.b.b("soldierPatrol");
											c5x.t.b.c("tithonusDoppelganger");
											if (this.e)
											{
												c5x.t.b.y6()[ddq.bm] = true;
												c5x.t.b.y6()[ddq.bn] = 10;
												c5x.t.b.y6()[ddq.bo] = 3;
											}
											else
											{
												c5x.t.b.y6()[ddq.ay] = bt;
											}
											if (this.g != null)
											{
												c5x.t.b.y6()[ddq.bj] = aud.y8();
												c5x.t.b.y6()[ddq.bi] = this.g.Value;
												c5x.t.b.y6()[ddq.bk] = true;
											}
										}
										c5x.SetAspect<e3l>(new e3l(c5x)
										{
											a = 
											{
												"projectedDoppelganger"
											}
										});
										aud.a(c5x);
										this.c = new ar7(c5x);
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04002130 RID: 8496
	private double a;

	// Token: 0x04002131 RID: 8497
	private int b;

	// Token: 0x04002132 RID: 8498
	private ar7 c;

	// Token: 0x04002133 RID: 8499
	private string d;

	// Token: 0x04002134 RID: 8500
	private bool e = true;

	// Token: 0x04002135 RID: 8501
	private string f;

	// Token: 0x04002136 RID: 8502
	private Guid? g;

	// Token: 0x04002137 RID: 8503
	private string h;
}
