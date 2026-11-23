using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020017D4 RID: 6100
[bs6("AdrenalineExpiresAction")]
[eiz("AEA2")]
[Serializable]
public sealed class gp : bhv, ISerializable
{
	// Token: 0x06008205 RID: 33285 RVA: 0x0036BB2C File Offset: 0x00369D2C
	private gp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008206 RID: 33286 RVA: 0x0036BB3C File Offset: 0x00369D3C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null && base.x2().a8() != null && base.x2().a8().j == cgy.b && base.x2().a8().Zone != null)
		{
			c5x a_ = base.x2().a8();
			string a_2 = "RedSparkExpiration";
			int a_3 = 2;
			double maxValue = double.MaxValue;
			bool a_4 = false;
			bool a_5 = true;
			Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, base.x2().a8().Size.Z));
			float? a_7 = dz6.b();
			a7j a_8 = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null);
			base.x2().a8().Zone.ActionManager.g9(a_8, atp.a);
			uj uj = base.xy() as uj;
			ab2 ab = new ab2(uj.c() / 2f, (int)((double)uj.a() * 0.75), uj.d(), uj.Duration + d0u.b + uj.b());
			amd a_9 = new amd(base.x2(), new els[]
			{
				ab
			});
			base.x2().a8().Zone.ActionManager.g9(a_9, atp.a);
			dz6.a(a_9);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06008207 RID: 33287 RVA: 0x0036BCAC File Offset: 0x00369EAC
	public gp()
	{
	}
}
