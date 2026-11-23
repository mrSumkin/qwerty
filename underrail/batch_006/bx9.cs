using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000A73 RID: 2675
[eiz("TSSTTJ")]
[Serializable]
public sealed class bx9 : cze, ISerializable
{
	// Token: 0x06003F0E RID: 16142 RVA: 0x0017DAB8 File Offset: 0x0017BCB8
	private bx9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F0F RID: 16143 RVA: 0x0017DAC4 File Offset: 0x0017BCC4
	public bx9()
	{
	}

	// Token: 0x06003F10 RID: 16144 RVA: 0x0017DAD0 File Offset: 0x0017BCD0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("dc_mushroomHeartDestroyed", new bool?(false)).Value && A_1 is c5x)
		{
			Vector3 a_ = A_1.Location;
			aud aud = A_1.Area;
			HorizontalDirection a_2 = A_1.VisualDirection;
			c5x c5x = vq.a("object\\natural\\SporeTurretTumor", aud.Zone, new bt4(aud.y8(), a_), false);
			if (c5x != null)
			{
				c5x.VisualDirection = a_2;
				c5x.ae = new float?(0f);
				dm aspect = c5x.GetAspect<dm>();
				if (aspect != null)
				{
					List<cze> list = aspect.d();
					ch3 ch = new ch3();
					ch.a(null);
					list.Add(ch);
					aspect.d().Add(new co0());
				}
			}
		}
	}
}
