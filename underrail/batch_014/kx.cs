using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001681 RID: 5761
[eiz("CHZA")]
[Serializable]
public sealed class kx : h3, ISerializable, cuu
{
	// Token: 0x06007D99 RID: 32153 RVA: 0x0034FB38 File Offset: 0x0034DD38
	private kx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("CHZA:A", ref this.a, A_0);
		this.b = (Point)A_0.GetValue("NBMA:S", typeof(Point));
	}

	// Token: 0x06007D9A RID: 32154 RVA: 0x0034FB8C File Offset: 0x0034DD8C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("CHZA:A", this.a, info);
		info.AddValue("CHZA:S", this.b);
	}

	// Token: 0x06007D9B RID: 32155 RVA: 0x0034FBC0 File Offset: 0x0034DDC0
	public kx()
	{
	}

	// Token: 0x06007D9C RID: 32156 RVA: 0x0034FBD8 File Offset: 0x0034DDD8
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		if (A_2 == 0f)
		{
			this.b = A_1;
			dv1.a(new List<string>
			{
				"Projectiles\\ChemhazeGlitter"
			}, A_0, A_1.a() + new Vector3(0.5f, 0.5f, 0f), 0.2f, 60, 200, 2f, 12f, true, true, false, null, false);
		}
		if (base.d() != null)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				double num = (double)(3f - A_2);
				num *= 0.75 + 0.5 * cuo.a.NextDouble();
				num = d05.b(1.0, num, 4.0);
				bpv.a("chemhazeGas", num, ak, null, false, false, new double?((double)dz6.b(Convert.ToInt32(250f + A_2 * 100f))));
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null && c5x.h.b != null && !this.a.Contains(b0b.qe()))
					{
						this.a(c5x.h.b, A_2);
						this.a.Add(c5x.qe());
					}
				}
			}
		}
	}

	// Token: 0x06007D9D RID: 32157 RVA: 0x0034FD80 File Offset: 0x0034DF80
	private void a(amc A_0, float A_1)
	{
		if (base.d() != null)
		{
			if (!A_0.aa().Passive && !A_0.aa().b(d8o.e))
			{
				int a_ = 1 + cuo.a.Next(2);
				A_0.aa().StatusEffects.a(new dyv(dyv.e * d0u.b)
				{
					Stacks = a_
				}, false, false, false);
			}
			A_0.u();
		}
	}

	// Token: 0x040031A7 RID: 12711
	private new List<Guid> a = new List<Guid>();

	// Token: 0x040031A8 RID: 12712
	private Point b;
}
