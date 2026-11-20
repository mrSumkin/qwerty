using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020017C7 RID: 6087
[eiz("XM1")]
[bs6("MorphineExpiresAction")]
[Serializable]
public sealed class tj : bhv, ISerializable
{
	// Token: 0x060081E2 RID: 33250 RVA: 0x0036AB98 File Offset: 0x00368D98
	private tj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081E3 RID: 33251 RVA: 0x0036ABA8 File Offset: 0x00368DA8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null && base.x2().a8() != null && base.x2().a8().j == cgy.b && base.x2().a8().Zone != null)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			List<auv> list = qy.ad();
			c5x a_ = base.x2().a8();
			string a_2 = "BlueSparkExpiration";
			int a_3 = 2;
			double maxValue = double.MaxValue;
			bool a_4 = false;
			bool a_5 = true;
			Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, base.x2().a8().Size.Z));
			float? a_7 = dz6.b();
			list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null));
			if ((int)base.x2().aa().Defense.q().zo() != (int)base.x2().aa().Defense.q().zm())
			{
				int a_8 = (int)Math.Max(1.0, (double)(base.x2().aa().Defense.q().zm() - base.x2().aa().Defense.q().zo()) * ja.c);
				cwt cwt = new cwt();
				cwt.i = null;
				cwt.j = new ap9(base.x2().aa());
				cwt.p = true;
				cwt.l = true;
				cwt.f.Add(new csk(DamageType.Mechanical, a_8));
				cwt.b = true;
				cwt.v = "истощение";
				cwt.w = true;
				qy.ad().Add(new akg(base.x2(), base.x2(), cwt, null, false));
			}
			base.x2().a8().Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x060081E4 RID: 33252 RVA: 0x0036ADBC File Offset: 0x00368FBC
	public tj()
	{
	}
}
