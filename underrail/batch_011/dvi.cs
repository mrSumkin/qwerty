using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000F75 RID: 3957
[eiz("OWRDGCEA")]
[Serializable]
public sealed class dvi : Aspect<c5x>, bp1, cmm, chb
{
	// Token: 0x06005076 RID: 20598 RVA: 0x002429B4 File Offset: 0x00240BB4
	private dvi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = A_0.GetDouble("OWRDGCEA:C");
	}

	// Token: 0x06005077 RID: 20599 RVA: 0x002429D0 File Offset: 0x00240BD0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OWRDGCEA:C", this.d);
	}

	// Token: 0x06005078 RID: 20600 RVA: 0x002429EC File Offset: 0x00240BEC
	public dvi(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06005079 RID: 20601 RVA: 0x002429F8 File Offset: 0x00240BF8
	public void c9(TimeSpan A_0)
	{
	}

	// Token: 0x0600507A RID: 20602 RVA: 0x002429FC File Offset: 0x00240BFC
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x0600507B RID: 20603 RVA: 0x00242A04 File Offset: 0x00240C04
	public void r7(eds A_0)
	{
		double num = (double)d0u.b * 2.5;
		if (!dz6.e())
		{
			if ((this.d += A_0.b.TotalMilliseconds) >= num)
			{
				this.d -= num;
				this.a();
				return;
			}
		}
		else
		{
			this.d = 0.0;
		}
	}

	// Token: 0x0600507C RID: 20604 RVA: 0x00242A74 File Offset: 0x00240C74
	public void c()
	{
		this.a();
		this.d = 0.0;
	}

	// Token: 0x0600507D RID: 20605 RVA: 0x00242A8C File Offset: 0x00240C8C
	public void mx()
	{
	}

	// Token: 0x0600507E RID: 20606 RVA: 0x00242A90 File Offset: 0x00240C90
	public void my()
	{
	}

	// Token: 0x0600507F RID: 20607 RVA: 0x00242A94 File Offset: 0x00240C94
	private void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d60 addon = base.a8().Zone.GetAddon<d60>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			c5x c5x = addon.ab5("tch_mu2_gasSource") as c5x;
			c5x c5x2 = addon.ab5("tch_mu2_ventSource") as c5x;
			c5x c5x3 = addon.ab5("tch_mu2_upperSource") as c5x;
			if (c5x != null && c5x.h.b.aa().IsInControl)
			{
				this.a(c5x, dvi.a);
			}
			else if (c5x == null)
			{
				this.a(dvi.a);
			}
			if (c5x2 != null && c5x2.h.b.aa().IsInControl)
			{
				this.a(c5x2, dvi.b);
			}
			else if (c5x2 == null)
			{
				this.a(dvi.b);
			}
			if (c5x3 != null && c5x3.h.b.aa().IsInControl)
			{
				this.a(c5x3, dvi.c);
			}
			else if (c5x3 == null)
			{
				this.a(dvi.c);
			}
			if (c5x == null && c5x2 == null && c5x3 == null)
			{
				base.a8().an();
			}
		}
	}

	// Token: 0x06005080 RID: 20608 RVA: 0x00242BEC File Offset: 0x00240DEC
	private void a(c5x A_0, string A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		d60 addon = base.a8().Zone.GetAddon<d60>();
		if (addon != null && !(addon.ab5(A_1) is c5x))
		{
			d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
			string a_ = "";
			if (!(A_1 == "GasDoppelganger"))
			{
				if (!(A_1 == "VentDoppelganger"))
				{
					if (A_1 == "UpperDoppelganger")
					{
						a_ = "Locale\\Creature\\Characters\\tch_mu2_upperPsionicProxy";
					}
				}
				else
				{
					a_ = "Locale\\Creature\\Characters\\tch_mu2_ventPsionicProxy";
				}
			}
			else
			{
				a_ = "Locale\\Creature\\Characters\\tch_mu2_gasPsionicProxy";
			}
			bt4 bt = this.c(A_1);
			if (bt != null)
			{
				ezd ezd = new ezd(null, bt, null, null, new CharacterState?(CharacterState.Idle), null, a_);
				ezd.ym(A_0, null, null);
				c5x c5x = ezd.f().ao() as c5x;
				if (c5x != null)
				{
					c5x.b(A_1);
					if (c5x.h.b != null && c5x.h.b.aa().Gear != null)
					{
						c5x.h.b.a(this.b(A_1));
						c5x c5x2 = serviceOrThrow.dv().a("locale\\creature\\psionicDoppelganger").a(null, false) as c5x;
						c5x.h.b.aa().Gear.l().a(c5x2.h.b.aa().Gear.l().Item.fy() as c8d, true);
						c5x.h.b.aa().Gear.j()[WeaponKey.Primary].a(c5x2.h.b.aa().Gear.j()[WeaponKey.Primary].Item.fy() as cd1, true);
						c5x.h.b.aa().Immunities = c5x2.h.b.aa().Immunities;
						c5x.h.b.aa().Attributes = c5x2.h.b.aa().Attributes;
						c5x.h.b.aa().Offense.d(200);
						c5x.h.b.aa().Skills.Get<jk>().a(200);
						c5x.h.b.aa().Skills.Get<e74>().a(200);
						c5x.h.b.aa().Skills.Get<erc>().a(200);
						c5x.h.b.aa().Offense.i(100);
						c5x.h.b.aa().StatusEffects.a(new dlo(0), false, false, false);
						c5x.h.b.aa().BaseSightRange = 5f;
						c5x.h.b.g(false);
						c5x.h.b.c(true);
						c5x.h.b.aa().BaseDetectionModifier = 0.45f;
						c5x.h.b.aa().BaseMovementSpeed = 0.75f;
						c5x.h.b.aa().bl();
						c5x2.an();
						if (c5x.t.b != null)
						{
							c5x.t.b.y6().RemoveProperty(ddq.a3);
							c5x.t.b.y6().RemoveProperty(ddq.bs);
							c5x.t.b.c("OverwatcherDoppelganger");
							c5x.t.b.y6()["IsDoppelganger"] = true;
						}
						c5x.c().a("PsionicProxyLoop", "PsionicProxyLoop", 0.35f, c9z.b, true, false);
					}
				}
			}
		}
	}

	// Token: 0x06005081 RID: 20609 RVA: 0x0024303C File Offset: 0x0024123C
	private bt4 c(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		List<ak1> list = new List<ak1>();
		aud aud = serviceOrThrow.aqw().Areas[0];
		int i = 0;
		int j = 0;
		int num = 0;
		int num2 = 0;
		if (!(A_0 == "GasDoppelganger"))
		{
			if (!(A_0 == "VentDoppelganger"))
			{
				if (A_0 == "UpperDoppelganger")
				{
					aud = serviceOrThrow.aqw().Areas[0];
					i = 15;
					j = 7;
					num = 27;
					num2 = 39;
				}
			}
			else
			{
				aud = serviceOrThrow.aqw().Areas[3];
				if (!aud.b(1, 5).b(dm9.b))
				{
					return new bt4(aud.y8(), new Vector3(1f, 5f, 0f));
				}
				aud = serviceOrThrow.aqw().Areas[4];
				return new bt4(aud.y8(), new Vector3(8f, 6f, 0f));
			}
		}
		else
		{
			aud = serviceOrThrow.aqw().Areas[1];
			i = 10;
			j = 7;
			num = 25;
			num2 = 29;
		}
		while (i < num)
		{
			while (j < num2)
			{
				ak1 ak = aud.b(i, j);
				if (Enumerable.Count<b0b>(ak.c.Values, new Func<b0b, bool>(dvi.a.a.a)) > 0 && !aw1.a(ak, false, null, l9.a) && !ak.b(dm9.b))
				{
					list.Add(ak);
				}
				j++;
			}
			i++;
		}
		if (list.Count > 0)
		{
			ak1 ak2 = list[cuo.a.Next(list.Count)];
			return new bt4(aud.y8(), ak2.Location.a());
		}
		return new bt4(aud.y8(), new Vector3(0f, 0f, 0f));
	}

	// Token: 0x06005082 RID: 20610 RVA: 0x00243248 File Offset: 0x00241448
	private string b(string A_0)
	{
		if (A_0 == "GasDoppelganger")
		{
			return "biotech_f1";
		}
		if (A_0 == "VentDoppelganger")
		{
			return "ag1";
		}
		if (!(A_0 == "UpperDoppelganger"))
		{
			return null;
		}
		return "ag2";
	}

	// Token: 0x06005083 RID: 20611 RVA: 0x002432A0 File Offset: 0x002414A0
	private void a(string A_0)
	{
		bpo.GetServiceOrThrow<cnk>();
		d60 addon = base.a8().Zone.GetAddon<d60>();
		if (addon != null)
		{
			c5x c5x = addon.ab5(A_0) as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}

	// Token: 0x040020EA RID: 8426
	private static readonly string a = "GasDoppelganger";

	// Token: 0x040020EB RID: 8427
	private static readonly string b = "VentDoppelganger";

	// Token: 0x040020EC RID: 8428
	private static readonly string c = "UpperDoppelganger";

	// Token: 0x040020ED RID: 8429
	private double d;

	// Token: 0x02000F77 RID: 3959
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005089 RID: 20617 RVA: 0x00243320 File Offset: 0x00241520
		internal bool a(b0b A_0)
		{
			return !A_0.aa;
		}

		// Token: 0x040020EE RID: 8430
		public static readonly dvi.a a = new dvi.a();

		// Token: 0x040020EF RID: 8431
		public static Func<b0b, bool> b;
	}
}
