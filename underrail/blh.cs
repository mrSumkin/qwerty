using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020017D5 RID: 6101
[eiz("CMDA")]
[Serializable]
public sealed class blh : a6k, ISerializable
{
	// Token: 0x06008208 RID: 33288 RVA: 0x0036BCB4 File Offset: 0x00369EB4
	private blh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008209 RID: 33289 RVA: 0x0036BCC0 File Offset: 0x00369EC0
	public blh()
	{
	}

	// Token: 0x0600820A RID: 33290 RVA: 0x0036BCCC File Offset: 0x00369ECC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a7j a_ = new a7j(c5x, "PurplePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z)), new float?(0.7f), new int?(30), dz6.b(), false, null);
		c5x.Zone.ActionManager.g9(a_, atp.a);
		a7j a_2 = new a7j(c5x, "PurplePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z)), new float?(0.5f), new int?(45), dz6.b(), false, null);
		c5x.Zone.ActionManager.g9(a_2, atp.a);
		a7j a_3 = new a7j(c5x, "PurplePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, c5x.Size.Z)), new float?(0.3f), new int?(60), dz6.b(), false, null);
		c5x.Zone.ActionManager.g9(a_3, atp.a);
		int num = 0;
		dot dot = Enumerable.FirstOrDefault<dot>(c5x.h.b.aa().StatusEffects.Get<dot>());
		if (dot != null)
		{
			num += dot.WithdrawalStacks;
		}
		ag0 ag = Enumerable.FirstOrDefault<ag0>(c5x.h.b.aa().StatusEffects.Get<ag0>());
		if (ag != null)
		{
			c5x.h.b.aa().StatusEffects.d(ag);
			num += ag.Stacks;
		}
		c5x.h.b.aa().Offense.d(alm.c, true);
		dot dot2 = new dot(alm.b, alm.e, alm.d, num);
		amd a_4 = new amd(c5x.h.b, new els[]
		{
			dot2
		});
		c5x.Zone.ActionManager.g9(a_4, atp.a);
		dz6.a(a_4);
		return dc4.c;
	}
}
