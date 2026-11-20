using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001758 RID: 5976
[eiz("PTNTA")]
[Serializable]
public sealed class ebi : a6k
{
	// Token: 0x060080A7 RID: 32935 RVA: 0x00365EF4 File Offset: 0x003640F4
	private ebi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060080A8 RID: 32936 RVA: 0x00365F00 File Offset: 0x00364100
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak != null)
		{
			c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("Locale\\Objects\\Explosives\\TNT-active");
			if (c5k != null)
			{
				c5x c5x = c5k.a(null, false) as c5x;
				if (c5x != null)
				{
					c5x.Location = new Vector3((float)ak.Location.X, (float)ak.Location.Y, 0f);
					c5x.IsGround = true;
					c5x.VisualPriority = 2;
					c5x.TileFormationModifiers.s3(12);
					c5x.Layer = aju.x;
					cij cij = new cij(c5x);
					cij.a(new c00());
					cij.j().a = new blv();
					cij.j().a.a = new ah7("tntExplosionLanern", null);
					cij.j().a.a.LightFadeRate = 0.2f;
					cij.j().a.a.Range = 4f;
					cij.j().a.a.Light = new ae8(Color.White, 1f, LightType.Increment);
					cij.j().a.b = 0.2f;
					cij.j().a.c = 0.15f;
					cij.j().a.d = ae3.b + 3f;
					cij.j().e = "TntExplode";
					cij.j().c = 40.0;
					cij.j().d = ae3.b;
					cij.j().b = new ebi.a(base.vg().q().h.b, ak.Location);
					cij.b((double)ae3.a);
					if (base.vg().q() != null)
					{
						cij.i = new EntityAspectReference<amc, amc>(base.vg().q().h.b);
					}
					c5x.SetAspect<cij>(cij);
					ak.Area.a(c5x);
					cij.a(null);
					c5x.c().a("armingExplosive", "ArmTntCharge", 1f, c9z.a, false, false);
					return dc4.c;
				}
			}
		}
		return dc4.e;
	}

	// Token: 0x060080A9 RID: 32937 RVA: 0x00366178 File Offset: 0x00364378
	public ebi()
	{
	}

	// Token: 0x02001759 RID: 5977
	[eiz("TNTA")]
	[Serializable]
	private new class a : cci, atw, ISerializable
	{
		// Token: 0x060080AA RID: 32938 RVA: 0x00366184 File Offset: 0x00364384
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("TNTA:AE", typeof(List<Guid>)) as List<Guid>);
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("TNTA:IR", typeof(EntityAspectReference<amc, amc>));
			if (ell.a() >= 607)
			{
				this.c = (Point)A_0.GetValue("TNTA:S", typeof(Point));
			}
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x00366214 File Offset: 0x00364414
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("TNTA:AE", this.a);
			info.AddValue("TNTA:IR", this.b);
			info.AddValue("TNTA:S", this.c);
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x00366250 File Offset: 0x00364450
		public Point ap2()
		{
			return this.c;
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x00366258 File Offset: 0x00364458
		public void ap3(Point A_0)
		{
			this.c = A_0;
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x00366264 File Offset: 0x00364464
		public a(amc A_0, Point A_1)
		{
			if (A_0 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_0);
			}
			this.c = A_1;
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x00366290 File Offset: 0x00364490
		public void cq(aud A_0, Point A_1, float A_2)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				boj.a(A_0, this.c, A_1, A_2);
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null)
					{
						if (c5x.h.b != null && !this.a.Contains(b0b.qe()))
						{
							this.a(c5x.h.b, A_2);
							this.a.Add(c5x.qe());
						}
						if (c5x.y.b != null)
						{
							c5x.y.b.a(null);
							this.a.Add(c5x.qe());
						}
					}
				}
			}
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x0036639C File Offset: 0x0036459C
		private void a(amc A_0, float A_1)
		{
			if (this.b != null && this.b.ao() != null)
			{
				ZoneControlLevel zoneControlLevel;
				if (!A_0.aa().Passive)
				{
					zoneControlLevel = eir.a(A_0.a8().Zone, A_0.aa().FactionId);
				}
				else
				{
					zoneControlLevel = ZoneControlLevel.Uncontrolled;
				}
				if (zoneControlLevel != ZoneControlLevel.Uncontrolled)
				{
					awq.a(this.b.ao(), A_0, false, true, null, true, false, false, false);
				}
			}
			A_0.u();
			cwt cwt = new cwt();
			cwt.b = true;
			if (this.b != null && this.b.ao() != null)
			{
				cwt.i = new ap9(this.b.ao().aa());
			}
			cwt.j = new ap9(A_0.aa());
			cwt.h = ImpactSpeed.High;
			if (A_0.aa().Passive && !A_0.aa().b(d8o.r))
			{
				cwt.f.AddRange(ae3.a());
				cwt.p = true;
			}
			else
			{
				double num;
				if (A_1 > 1f)
				{
					num = Math.Min(c18.az, (double)(A_1 - 1f) * c18.a0);
				}
				else
				{
					num = 0.0;
				}
				cwt.f.Add(euf.a(c18.r(2), 1.0 - num));
				cwt.f.Add(euf.a(c18.q(2), 1.0 - num));
				cwt.q = true;
			}
			A_0.aa().Defense.a(cwt);
		}

		// Token: 0x04003255 RID: 12885
		private List<Guid> a = new List<Guid>();

		// Token: 0x04003256 RID: 12886
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003257 RID: 12887
		private Point c;
	}
}
