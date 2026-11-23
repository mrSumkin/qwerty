using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013D1 RID: 5073
[eiz("FEXA2")]
[Serializable]
public sealed class d40 : cci, ISerializable
{
	// Token: 0x06007230 RID: 29232 RVA: 0x002FFA18 File Offset: 0x002FDC18
	private d40(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<Guid>("FEXA2:AE", ref this.a, A_0);
		this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("FEXA2:AR", typeof(EntityAspectReference<amc, amc>));
		this.c = (a1q)A_0.GetValue("FEXA2:D", typeof(a1q));
		this.d = (a1q)A_0.GetValue("FEXA2:X", typeof(a1q));
		this.e = (Guid)A_0.GetValue("FEXA2:I", typeof(Guid));
		this.f = (A_0.GetValue("FEXA2:CB", typeof(enp)) as enp);
		this.g = (A_0.GetValue("FEXA2:AP", typeof(ekt)) as ekt);
	}

	// Token: 0x06007231 RID: 29233 RVA: 0x002FFB08 File Offset: 0x002FDD08
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<Guid>("FEXA2:AE", this.a, info);
		info.AddValue("FEXA2:AR", this.b);
		info.AddValue("FEXA2:D", this.c);
		info.AddValue("FEXA2:X", this.d);
		info.AddValue("FEXA2:I", this.e);
		info.AddValue("FEXA2:CB", this.f);
		info.AddValue("FEXA2:AP", this.g);
	}

	// Token: 0x06007232 RID: 29234 RVA: 0x002FFB9C File Offset: 0x002FDD9C
	public d40(amc A_0)
	{
		this.b = new EntityAspectReference<amc, amc>(A_0);
		this.e = Guid.NewGuid();
	}

	// Token: 0x06007233 RID: 29235 RVA: 0x002FFBCC File Offset: 0x002FDDCC
	public void cq(aud A_0, Point A_1, float A_2)
	{
		Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
		HorizontalDirection? a_2 = null;
		string a_3 = "Fusion_CloudDust";
		int a_4 = 1;
		double maxValue = double.MaxValue;
		float? a_5 = dz6.b();
		boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, null);
		Vector3 a_6 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
		HorizontalDirection? a_7 = null;
		string a_8 = "Fusion_Lightning";
		int a_9 = 1;
		double maxValue2 = double.MaxValue;
		a_5 = dz6.b();
		boj.a(A_0, a_6, a_7, a_8, a_9, maxValue2, null, null, a_5, null);
		Vector3 a_10 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
		HorizontalDirection? a_11 = null;
		string a_12 = "Fusion_ImpactLightning";
		int a_13 = 1;
		double maxValue3 = double.MaxValue;
		a_5 = dz6.b();
		boj.a(A_0, a_10, a_11, a_12, a_13, maxValue3, null, null, a_5, null);
		if (A_2 == 0f)
		{
			Vector3 a_14 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_15 = null;
			string a_16 = "Fusion_ExplosionCenter";
			int a_17 = 1;
			double maxValue4 = double.MaxValue;
			a_5 = dz6.b();
			boj.a(A_0, a_14, a_15, a_16, a_17, maxValue4, null, null, a_5, null);
		}
		ak1 ak = A_0.b(A_1.X, A_1.Y);
		if (ak != null)
		{
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

	// Token: 0x06007234 RID: 29236 RVA: 0x002FFE48 File Offset: 0x002FE048
	private void a(amc A_0, float A_1)
	{
		if (A_0 == null || A_0.a8() == null || this.b == null || this.b.ao() == null)
		{
			return;
		}
		if (!A_0.a8().IsPlayer)
		{
			awq.a(this.b.ao(), A_0, true, true, null, true, true, false, false);
		}
		double num;
		if (A_1 > 0f)
		{
			num = Math.Min(c18.az, (double)A_1 * c18.a3);
		}
		else
		{
			num = 0.0;
		}
		double a_ = 0.0;
		double num2 = 1.0;
		double ak = 0.0;
		double num3 = 0.0;
		double num4 = 1.0;
		if (this.g != null)
		{
			xo xo = this.g.a(this.b.ao(), A_0);
			a_ = xo.a;
			num2 = xo.b;
			num3 = xo.c;
			ak = xo.d;
			num4 = xo.e;
		}
		bool flag = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
		double num5 = (1.0 - num) * (1.0 + num3) * num4;
		if (flag)
		{
			num5 *= 1.0 + num2;
		}
		cwt cwt = new cwt();
		cwt.af = this.e;
		cwt.f.Add(euf.a(this.c, num5));
		cwt.f.Add(euf.a(this.d, num5));
		cwt.b = true;
		cwt.e = flag;
		cwt.x = AmmoType.HighExplosives;
		cwt.q = true;
		cwt.ak = ak;
		cwt.i = new ap9(this.b.ao().aa());
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.ad["IsExplosion"] = true;
		cwt.ae = new WeaponSubtype?(WeaponSubtype.FusionCannon);
		cru a_2 = A_0.aa().Defense.a(cwt);
		if (this.f != null)
		{
			this.f.af(this.b.ao(), A_0, cwt, a_2);
		}
	}

	// Token: 0x04002E91 RID: 11921
	private List<Guid> a = new List<Guid>();

	// Token: 0x04002E92 RID: 11922
	public EntityAspectReference<amc, amc> b;

	// Token: 0x04002E93 RID: 11923
	public a1q c;

	// Token: 0x04002E94 RID: 11924
	public a1q d;

	// Token: 0x04002E95 RID: 11925
	private Guid e;

	// Token: 0x04002E96 RID: 11926
	public enp f;

	// Token: 0x04002E97 RID: 11927
	public ekt g;
}
