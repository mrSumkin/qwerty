using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013D2 RID: 5074
[eiz("FEXA")]
[Serializable]
public sealed class ct1 : cci, ISerializable
{
	// Token: 0x06007235 RID: 29237 RVA: 0x0030009C File Offset: 0x002FE29C
	private ct1(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<Guid>("FEXA:AE", ref this.a, A_0);
		this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("FEXA:AR", typeof(EntityAspectReference<amc, amc>));
		this.c = (A_0.GetValue("FEXA:W", typeof(cd1)) as cd1);
	}

	// Token: 0x06007236 RID: 29238 RVA: 0x0030010C File Offset: 0x002FE30C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<Guid>("FEXA:AE", this.a, info);
		info.AddValue("FEXA:AR", this.b);
		info.AddValue("FEXA:W", this.c);
	}

	// Token: 0x06007237 RID: 29239 RVA: 0x00300144 File Offset: 0x002FE344
	public ct1(amc A_0, cd1 A_1)
	{
		this.b = new EntityAspectReference<amc, amc>(A_0);
		this.c = A_1;
	}

	// Token: 0x06007238 RID: 29240 RVA: 0x0030016C File Offset: 0x002FE36C
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

	// Token: 0x06007239 RID: 29241 RVA: 0x003003E8 File Offset: 0x002FE5E8
	private void a(amc A_0, float A_1)
	{
		if (A_0 == null || A_0.a8() == null || this.b == null || this.b.ao() == null || this.c == null)
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
		cmn a_ = awq.a(this.b.ao(), A_0, this.c, new bool?(true));
		cwt cwt = euf.a(this.b.ao().aa(), A_0.aa(), 0.0, a_, 0.0, A_0.a8().l(), this.b.ao().aa().Darkvision, AmmoType.Energy, awq.f(this.b.ao()), 1.0, true, this.c, null, false, null);
		cwt.q = true;
		for (int i = 0; i < cwt.f.Count; i++)
		{
			csk csk = cwt.f[i];
			csk value = new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * (1.0 - num)));
			cwt.f[i] = value;
		}
		cwt.ad["IsExplosion"] = true;
		akg a_2 = new akg(this.b.ao(), A_0, cwt, new vu(null), false);
		A_0.a8().Zone.ActionManager.g9(a_2, atp.a);
		dz6.a(a_2);
	}

	// Token: 0x04002E98 RID: 11928
	private List<Guid> a = new List<Guid>();

	// Token: 0x04002E99 RID: 11929
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002E9A RID: 11930
	private cd1 c;
}
