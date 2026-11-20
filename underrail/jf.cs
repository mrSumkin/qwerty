using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013E7 RID: 5095
[eiz("KRMH")]
[Serializable]
public sealed class jf : aig, ISerializable
{
	// Token: 0x060072BD RID: 29373 RVA: 0x00303FE0 File Offset: 0x003021E0
	private jf(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (ar7)A_0.GetValue("KRMH:A", typeof(ar7));
		this.b = A_0.GetSingle("KRMH:D");
		this.c = (A_0.GetValue("KRMH:H", typeof(HashSet<Guid>)) as HashSet<Guid>);
		this.e = (a1q)A_0.GetValue("KRMH:X", typeof(a1q));
		this.f = A_0.GetSingle("KRMH:R");
		this.d = (Vector3)A_0.GetValue("KRMH:S", typeof(Vector3));
		this.g = (A_0.GetValue("KRMH:C", typeof(enp)) as enp);
		this.h = (Guid)A_0.GetValue("KRMH:I", typeof(Guid));
		this.i = (A_0.GetValue("KRMH:P", typeof(ekt)) as ekt);
	}

	// Token: 0x060072BE RID: 29374 RVA: 0x00304118 File Offset: 0x00302318
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("KRMH:A", this.a);
		info.AddValue("KRMH:D", this.b);
		info.AddValue("KRMH:H", this.c);
		info.AddValue("KRMH:X", this.e);
		info.AddValue("KRMH:R", this.f);
		info.AddValue("KRMH:S", this.d);
		info.AddValue("KRMH:C", this.g);
		info.AddValue("KRMH:I", this.h);
		info.AddValue("KRMH:P", this.i);
	}

	// Token: 0x060072BF RID: 29375 RVA: 0x003041D0 File Offset: 0x003023D0
	public jf(c5x A_0)
	{
		this.a = new ar7(A_0);
	}

	// Token: 0x060072C0 RID: 29376 RVA: 0x00304208 File Offset: 0x00302408
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		if (A_0 == null)
		{
			return true;
		}
		ar7 ar = this.a;
		amc amc;
		if (ar == null)
		{
			amc = null;
		}
		else
		{
			b0b b0b = ar.ao();
			amc = ((b0b != null) ? b0b.GetAspect<amc>() : null);
		}
		amc amc2 = amc;
		if (amc2 == null)
		{
			return true;
		}
		Vector3 value = this.d;
		value.Z = 0f;
		Vector3 vector = A_0.aj();
		vector.Z = 0f;
		this.b += A_3;
		float num = 1f - Math.Max(0f, 5f - this.b) * 0.1f;
		List<amc> list = new List<amc>();
		foreach (ak1 ak in A_0.l)
		{
			foreach (b0b b0b2 in ak.c.Values)
			{
				c5x c5x = (c5x)b0b2;
				if (c5x.h.b != null)
				{
					Vector3 value2 = c5x.aj();
					value2.Z = 0f;
					float num2 = (vector - value2).Length();
					BoundingBox boundingBox = new BoundingBox(c5x.Location * new Vector3(1f, 1f, 0f), (c5x.Location + c5x.Size) * new Vector3(1f, 1f, 0f));
					if ((num2 <= 0.35f || boundingBox.Contains(vector) != ContainmentType.Disjoint) && !this.c.Contains(c5x.qe()))
					{
						this.c.Add(c5x.qe());
						float num3 = (value - value2).Length();
						int i;
						for (i = 0; i < list.Count; i++)
						{
							Vector3 value3 = list[i].a8().aj();
							value3.Z = 0f;
							float num4 = (value - value3).Length();
							if (num3 < num4)
							{
								break;
							}
						}
						list.Insert(i, c5x.h.b);
					}
				}
			}
		}
		if (list.Count == 0)
		{
			return false;
		}
		bvd bvd = this.g as bvd;
		for (int j = 0; j < list.Count; j++)
		{
			amc amc3 = list[j];
			double a_ = 0.0;
			double num5 = 1.0;
			if (this.i != null)
			{
				xo xo = this.i.a(amc2, amc3);
				a_ = xo.a;
				num5 = xo.b;
				double num6 = xo.c;
				double num7 = xo.d;
				double num8 = xo.e;
			}
			bool flag = !amc3.aa().ImmuneToCriticalHits && euf.a(a_);
			double num9 = Convert.ToDouble(num * this.f);
			if (flag)
			{
				num9 *= 1.0 + num5;
			}
			this.f *= 0.9f;
			cwt cwt = new cwt();
			cwt.af = this.h;
			cwt.f.Add(euf.a(this.e, num9));
			cwt.b = true;
			cwt.e = flag;
			cwt.x = AmmoType.Rocket_84_Kin;
			cwt.i = new ap9(amc2.aa());
			cwt.h = ImpactSpeed.Low;
			cwt.ae = new WeaponSubtype?(WeaponSubtype.RocketLauncher_84);
			cru cru = amc3.aa().Defense.a(cwt);
			if (cru != null)
			{
				string a_2 = null;
				string a_3 = null;
				string a_4 = null;
				string a_5 = null;
				float a_6 = 0f;
				float a_7 = 0f;
				awq.a(amc3, new esu?(esu.f), out a_2, out a_3, out a_4, out a_5, out a_6, out a_7, null, false);
				new kg(null, a_2, a_3, a_4, a_5, a_6, a_7).af(amc2, amc3, cwt, cru);
			}
			if (bvd != null)
			{
				bps a_8 = new bps();
				bvd.mm(amc2, amc3, cwt, cru, a_8);
			}
			else if (this.g != null)
			{
				this.g.af(amc2, amc3, cwt, cru);
			}
			awq.a(amc2, amc3, true, true, null, true, true, false, false);
			int? num10;
			if (cru == null)
			{
				num10 = null;
			}
			else
			{
				List<csk> list2 = cru.a;
				if (list2 == null)
				{
					num10 = null;
				}
				else
				{
					num10 = new int?(Enumerable.Sum<csk>(list2, new Func<csk, int>(jf.a.a.a)));
				}
			}
			int? num11 = num10;
			if (num11.GetValueOrDefault() == 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04002EDC RID: 11996
	private ar7 a;

	// Token: 0x04002EDD RID: 11997
	private float b;

	// Token: 0x04002EDE RID: 11998
	private HashSet<Guid> c = new HashSet<Guid>();

	// Token: 0x04002EDF RID: 11999
	public Vector3 d;

	// Token: 0x04002EE0 RID: 12000
	public a1q e;

	// Token: 0x04002EE1 RID: 12001
	public float f = 1f;

	// Token: 0x04002EE2 RID: 12002
	public enp g;

	// Token: 0x04002EE3 RID: 12003
	public Guid h = Guid.NewGuid();

	// Token: 0x04002EE4 RID: 12004
	public ekt i;

	// Token: 0x020013E8 RID: 5096
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060072C3 RID: 29379 RVA: 0x00304750 File Offset: 0x00302950
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002EE5 RID: 12005
		public static readonly jf.a a = new jf.a();

		// Token: 0x04002EE6 RID: 12006
		public static Func<csk, int> b;
	}
}
