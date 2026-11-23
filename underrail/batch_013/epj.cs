using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020017D1 RID: 6097
[bs6("BlueExpirationAction")]
[eiz("XBEA")]
[Serializable]
public sealed class epj : bhv, ISerializable
{
	// Token: 0x060081FC RID: 33276 RVA: 0x0036B840 File Offset: 0x00369A40
	private epj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081FD RID: 33277 RVA: 0x0036B84C File Offset: 0x00369A4C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null && base.x2().a8() != null && base.x2().a8().j == cgy.b && base.x2().a8().Zone != null)
		{
			c5x a_ = base.x2().a8();
			string a_2 = "BlueSparkExpiration";
			int a_3 = 2;
			double maxValue = double.MaxValue;
			bool a_4 = false;
			bool a_5 = true;
			Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, base.x2().a8().Size.Z));
			float? a_7 = dz6.b();
			a7j a_8 = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null);
			base.x2().a8().Zone.ActionManager.g9(a_8, atp.a);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x060081FE RID: 33278 RVA: 0x0036B92C File Offset: 0x00369B2C
	public epj()
	{
	}
}
