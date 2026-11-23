using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020016AC RID: 5804
[eiz("WPIA")]
[Serializable]
public sealed class czv : a6k, ISerializable
{
	// Token: 0x06007EB3 RID: 32435 RVA: 0x00358A40 File Offset: 0x00356C40
	private czv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EB4 RID: 32436 RVA: 0x00358A4C File Offset: 0x00356C4C
	public czv()
	{
	}

	// Token: 0x06007EB5 RID: 32437 RVA: 0x00358A58 File Offset: 0x00356C58
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null && b.aa() != null)
			{
				coh coh = b.aa().Gear.l().Item;
				if (coh != null)
				{
					if (coh.Battery < (double)zw.j)
					{
						coh.Battery = 0.0;
						return dc4.e;
					}
					coh.a((double)zw.j, true);
				}
				PsiSchool a_ = (cuo.a.NextDouble() < 0.5) ? PsiSchool.Metathermics : PsiSchool.Psychokinesis;
				int a_2 = Convert.ToInt32(zw.e.a());
				float a_3 = Convert.ToSingle(zw.f.a());
				float a_4 = Convert.ToSingle(zw.g.a());
				float a_5 = Convert.ToSingle(zw.h.a());
				kc a_6 = new kc(a_, a_2, a_3, a_4, a_5);
				b.aa().StatusEffects.a(a_6, false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
