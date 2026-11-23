using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020017B9 RID: 6073
[eiz("VSEA1")]
[bs6("VitalitySurgeExpiresAction")]
[Serializable]
public sealed class dbd : bhv, ISerializable
{
	// Token: 0x060081B7 RID: 33207 RVA: 0x003694D8 File Offset: 0x003676D8
	private dbd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081B8 RID: 33208 RVA: 0x003694E4 File Offset: 0x003676E4
	public dbd()
	{
	}

	// Token: 0x060081B9 RID: 33209 RVA: 0x003694F0 File Offset: 0x003676F0
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
			if (base.x2().aa() is e3q)
			{
				ely ely = base.xy() as ely;
				ab2 ab = new ab2(ely.c() / 2f, (int)((double)ely.a() * 0.75), ely.d(), ely.Duration + d0u.b + ely.b());
				amd a_9 = new amd(base.x2(), new els[]
				{
					ab
				});
				base.x2().a8().Zone.ActionManager.g9(a_9, atp.a);
				dz6.a(a_9);
				cpb cpb = new cpb(cpb.c);
				amd a_10 = new amd(base.x2(), new els[]
				{
					cpb
				});
				base.x2().a8().Zone.ActionManager.g9(a_10, atp.a);
				dz6.a(a_9);
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
