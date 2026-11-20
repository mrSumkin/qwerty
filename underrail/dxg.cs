using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020013B2 RID: 5042
[eiz("LTGY")]
[bs6("HFX:leaveToxicGas")]
[Serializable]
public sealed class dxg : cpl, ISerializable
{
	// Token: 0x060071B3 RID: 29107 RVA: 0x002FBBAC File Offset: 0x002F9DAC
	private dxg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071B4 RID: 29108 RVA: 0x002FBBB8 File Offset: 0x002F9DB8
	public dxg()
	{
	}

	// Token: 0x060071B5 RID: 29109 RVA: 0x002FBBC4 File Offset: 0x002F9DC4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.b() == null || base.b().a8() == null || base.b().a8().Zone == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		if (!base.agw().b)
		{
			return dc4.c;
		}
		Vector3 a_ = base.b().a8().aj();
		ak1 ak = base.b().a8().Area.a(a_.a());
		if (ak != null)
		{
			awb awb = new awb(ak, new eip(), null, 1f, null);
			awb.r = true;
			awb.b((double)dz6.b(200));
			ak.Zone.ActionManager.g9(awb, atp.a);
			dz6.a(awb);
		}
		return dc4.e;
	}
}
