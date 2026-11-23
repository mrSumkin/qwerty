using System;
using System.Runtime.Serialization;

// Token: 0x0200142B RID: 5163
[bs6("applyBleed")]
[eiz("AV9")]
[Serializable]
public sealed class eiq : bhv, ISerializable
{
	// Token: 0x060073C2 RID: 29634 RVA: 0x0030E63C File Offset: 0x0030C83C
	private eiq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060073C3 RID: 29635 RVA: 0x0030E648 File Offset: 0x0030C848
	public eiq()
	{
	}

	// Token: 0x060073C4 RID: 29636 RVA: 0x0030E654 File Offset: 0x0030C854
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null && base.x2().a8() != null)
		{
			string text;
			if (base.x2().ak == ai5.c)
			{
				text = "SlimeImpact";
			}
			else
			{
				text = "BloodImpact";
			}
			c5x a_ = base.x2().a8();
			string a_2 = text;
			int a_3 = 1;
			double maxValue = double.MaxValue;
			bool a_4 = true;
			bool a_5 = true;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			base.x2().a8().c().a(Guid.NewGuid().ToString(), "FleshStab2", 1f, c9z.a, false, false);
		}
		return dc4.c;
	}
}
