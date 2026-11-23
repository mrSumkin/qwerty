using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B7C RID: 2940
[eiz("CCAHHOJ")]
[Serializable]
public sealed class bv4 : cze, ISerializable
{
	// Token: 0x0600432A RID: 17194 RVA: 0x001A4178 File Offset: 0x001A2378
	private bv4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600432B RID: 17195 RVA: 0x001A4184 File Offset: 0x001A2384
	public bv4()
	{
	}

	// Token: 0x0600432C RID: 17196 RVA: 0x001A418C File Offset: 0x001A238C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.Area != null)
		{
			c5x c5x = new ar7(new Guid("5c53950f-aeda-4813-b124-63291d4daacd"), A_0.Area).ao() as c5x;
			if (c5x != null && c5x.i.b != null && c5x.j.b != null)
			{
				c5x.TileFormationModifiers.c();
				c5x.z();
				c5x.c().a("WarehouseGate");
				awx awx = new awx();
				awx.a(false);
				awx.ad().Add(new bpr(c5x.j.b, new Vector3(17f, 5f, 1.8f)));
				c5x.i.b.b(awx, atp.a);
			}
		}
	}
}
