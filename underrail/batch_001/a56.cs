using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001621 RID: 5665
[eiz("P01")]
[Serializable]
public sealed class a56 : a6k, ISerializable
{
	// Token: 0x06007C85 RID: 31877 RVA: 0x00347878 File Offset: 0x00345A78
	private a56(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C86 RID: 31878 RVA: 0x00347884 File Offset: 0x00345A84
	public a56()
	{
	}

	// Token: 0x06007C87 RID: 31879 RVA: 0x00347890 File Offset: 0x00345A90
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null || ak.Zone == null)
		{
			return dc4.e;
		}
		base.vg().i();
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		awb item = new awb(ak, new a56.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, false);
		qy.ad().Add(item);
		ak.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}

	// Token: 0x02001622 RID: 5666
	[eiz("P01a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007C88 RID: 31880 RVA: 0x00347964 File Offset: 0x00345B64
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("P01a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("P01a:I", typeof(EntityAspectReference<amc, amc>));
			if (ell.a() >= 563)
			{
				this.d = A_0.GetString("P01a:R");
				return;
			}
			this.d = "forcefield_" + Guid.NewGuid().ToString();
		}

		// Token: 0x06007C89 RID: 31881 RVA: 0x003479FC File Offset: 0x00345BFC
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("P01a:P", this.a);
			info.AddValue("P01a:I", this.b);
			info.AddValue("P01a:R", this.d);
		}

		// Token: 0x06007C8A RID: 31882 RVA: 0x00347A34 File Offset: 0x00345C34
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
			this.d = "forcefield_" + Guid.NewGuid().ToString();
		}

		// Token: 0x06007C8B RID: 31883 RVA: 0x00347A84 File Offset: 0x00345C84
		public void cq(aud A_0, Point A_1, float A_2)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null && (!ak.Formation.b(2L) || ak.Formation.b(128L)) && ak.f(null) == 0L)
			{
				c5x c5x = vq.a("object\\obstacles\\forcefield2", false);
				if (c5x != null)
				{
					amc aspect = c5x.GetAspect<amc>();
					if (aspect != null)
					{
						string a_ = this.a.b8().FactionId;
						if (a_ == asp.a)
						{
							aspect.aa().FactionId = asp.c;
						}
						else
						{
							aspect.aa().FactionId = a_;
						}
						aspect.aa().Defense.p = new int?(cp5.a(this.a));
						aspect.ay().Add(new dtz(this.d));
						c8d c8d = aspect.aa().Gear.l().Item;
						if (c8d != null)
						{
							foreach (DamageType damageType in new DamageType[]
							{
								DamageType.Mechanical,
								DamageType.Heat,
								DamageType.Electricity,
								DamageType.Energy,
								DamageType.Acid
							})
							{
								double a_2;
								int a_3;
								cp5.a(this.a, damageType, out a_2, out a_3);
								c8d.fu().i().Add(new du2(damageType, a_3, a_2));
							}
						}
					}
					c5x.b(this.d);
					c5x.Location = ak.Location.a();
					c5x.ae = new float?(0f);
					c5x.Layer = aju.x;
					dm dm = new dm(c5x);
					dm.d().Add(new cbb(l4.a((double)cp5.b(this.a))));
					c5x.SetAspect<dm>(dm);
					ak.Area.a(c5x);
					c5x.c().a("forceField", "ForceField", 1f, c9z.b, true, false);
					this.a(c5x);
					ad6 ad = new ad6(c5x);
					ad.b(0.0);
					ad.c(1.0);
					ad.a(dz6.a(0.00075));
					ak.Zone.ActionManager.g9(ad, atp.a);
					dz6.a(ad);
				}
			}
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x00347CE8 File Offset: 0x00345EE8
		private void a(c5x A_0)
		{
			if (this.c == null)
			{
				this.c = new ah7("forcefieldLantern", null);
				this.c.Layer = aju.x;
				this.c.Light = new ae8(Color.Purple, 0.3f, LightType.Increment);
				this.c.Range = 3f;
				this.c.LightFadeRate = 0.075f;
			}
			this.c.g().be(A_0);
		}

		// Token: 0x04003179 RID: 12665
		private eu7 a;

		// Token: 0x0400317A RID: 12666
		private EntityAspectReference<amc, amc> b;

		// Token: 0x0400317B RID: 12667
		private ah7 c;

		// Token: 0x0400317C RID: 12668
		private string d;
	}
}
