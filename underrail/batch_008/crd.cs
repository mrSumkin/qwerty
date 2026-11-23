using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001420 RID: 5152
[eiz("Y3")]
[bs6("LastStandExpiresAction")]
[Serializable]
public sealed class crd : bhv, ISerializable
{
	// Token: 0x06007390 RID: 29584 RVA: 0x0030BC64 File Offset: 0x00309E64
	private crd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007391 RID: 29585 RVA: 0x0030BC70 File Offset: 0x00309E70
	public crd()
	{
	}

	// Token: 0x06007392 RID: 29586 RVA: 0x0030BC78 File Offset: 0x00309E78
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null && !base.x2().aa().Dead)
		{
			if (base.x2().a8() != null)
			{
				c5x a_ = base.x2().a8();
				string a_2 = "RedSparkExpiration";
				int a_3 = 2;
				double maxValue = double.MaxValue;
				bool a_4 = false;
				bool a_5 = true;
				Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, base.x2().a8().Size.Z));
				float? a_7 = dz6.b();
				boj.a(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false);
			}
			base.x2().aa().Defense.q().zp(1f);
			base.x2().aa().bl();
		}
		return dc4.c;
	}
}
