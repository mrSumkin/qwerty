using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020017D7 RID: 6103
[eiz("PBEA")]
[bs6("PsiBoosterExpiresAction")]
[Serializable]
public sealed class b5 : bhv, ISerializable
{
	// Token: 0x0600820E RID: 33294 RVA: 0x0036C0F8 File Offset: 0x0036A2F8
	private b5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(b5);
		}
	}

	// Token: 0x0600820F RID: 33295 RVA: 0x0036C124 File Offset: 0x0036A324
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06008210 RID: 33296 RVA: 0x0036C130 File Offset: 0x0036A330
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

	// Token: 0x06008211 RID: 33297 RVA: 0x0036C210 File Offset: 0x0036A410
	public b5()
	{
	}
}
