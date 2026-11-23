using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001223 RID: 4643
[eiz("XRTOA")]
[Serializable]
public sealed class asi : cci, ISerializable
{
	// Token: 0x06006405 RID: 25605 RVA: 0x002B06B4 File Offset: 0x002AE8B4
	private asi(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("XRTOA:A", typeof(HashSet<Guid>)) as HashSet<Guid>);
	}

	// Token: 0x06006406 RID: 25606 RVA: 0x002B06E8 File Offset: 0x002AE8E8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("XRTOA:A", this.a);
	}

	// Token: 0x06006407 RID: 25607 RVA: 0x002B06FC File Offset: 0x002AE8FC
	public asi()
	{
	}

	// Token: 0x06006408 RID: 25608 RVA: 0x002B0714 File Offset: 0x002AE914
	public void cq(aud A_0, Point A_1, float A_2)
	{
		ak1 ak = A_0.b(A_1.X, A_1.Y);
		if (ak != null)
		{
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

	// Token: 0x06006409 RID: 25609 RVA: 0x002B07DC File Offset: 0x002AE9DC
	private void a(amc A_0, float A_1)
	{
		A_0.u();
		double a_ = 0.05;
		bool flag = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
		a1q a_2;
		if (A_1 == 0f)
		{
			a_2 = new a1q(DamageType.Mechanical, 100, 200);
		}
		else
		{
			a_2 = new a1q(DamageType.Mechanical, 65, 125);
		}
		cwt cwt = new cwt();
		cwt.f.Add(euf.a(a_2, (double)(flag ? 2 : 1)));
		cwt.b = true;
		cwt.e = flag;
		cwt.x = AmmoType.Sledgehammer;
		cwt.q = true;
		cwt.h = ImpactSpeed.Low;
		cwt.k = "rock";
		A_0.aa().Defense.a(cwt);
	}

	// Token: 0x04002A04 RID: 10756
	private HashSet<Guid> a = new HashSet<Guid>();
}
