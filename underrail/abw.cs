using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020017D6 RID: 6102
[bs6("MindDartsExpireAction")]
[eiz("MDEA")]
[Serializable]
public sealed class abw : bhv, ISerializable
{
	// Token: 0x0600820B RID: 33291 RVA: 0x0036BF60 File Offset: 0x0036A160
	private abw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600820C RID: 33292 RVA: 0x0036BF6C File Offset: 0x0036A16C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null && base.x2().a8() != null && base.x2().a8().j == cgy.b && base.x2().a8().Zone != null)
		{
			c5x a_ = base.x2().a8();
			string a_2 = "PurpleSparkExpiration";
			int a_3 = 2;
			double maxValue = double.MaxValue;
			bool a_4 = false;
			bool a_5 = true;
			Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, base.x2().a8().Size.Z));
			float? a_7 = dz6.b();
			a7j a_8 = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null);
			base.x2().a8().Zone.ActionManager.g9(a_8, atp.a);
			if (base.x2().a8().h.b != null)
			{
				dot dot = base.xy() as dot;
				ag0 ag = new ag0((dot.Stacks + dot.WithdrawalStacks) * ag0.b);
				ag.Stacks = Math.Min(ag.MaxStacks, dot.Stacks + dot.WithdrawalStacks);
				amd a_9 = new amd(base.x2(), new els[]
				{
					ag
				});
				base.x2().a8().Zone.ActionManager.g9(a_9, atp.a);
				dz6.a(a_9);
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x0600820D RID: 33293 RVA: 0x0036C0F0 File Offset: 0x0036A2F0
	public abw()
	{
	}
}
