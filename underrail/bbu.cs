using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules;

// Token: 0x02000A74 RID: 2676
[eiz("STBTJ")]
[Serializable]
public sealed class bbu : cze, ISerializable
{
	// Token: 0x06003F11 RID: 16145 RVA: 0x0017DBBC File Offset: 0x0017BDBC
	private bbu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F12 RID: 16146 RVA: 0x0017DBC8 File Offset: 0x0017BDC8
	public bbu()
	{
	}

	// Token: 0x06003F13 RID: 16147 RVA: 0x0017DBD4 File Offset: 0x0017BDD4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 is c5x)
		{
			object obj = null;
			if (A_2 != null)
			{
				A_2.TryGetValue("tickCount", out obj);
			}
			if (((obj is int) ? ((int)obj) : 0) >= this.a())
			{
				Vector3 a_ = A_1.Location;
				aud aud = A_1.Area;
				HorizontalDirection a_2 = A_1.VisualDirection;
				A_1.w();
				A_1.an();
				c5x c5x = vq.a("creature\\critters\\SporeTurret", aud.Zone, new bt4(aud.y8(), a_), false);
				if (c5x != null)
				{
					boj.a(aud, a_, null, "SporeTurretTumorBurst", 1, double.MaxValue, null, null, null, null);
					c5x.c().a("SporeTurretTumorBurst");
					c5x.VisualDirection = a_2;
				}
			}
		}
	}

	// Token: 0x06003F14 RID: 16148 RVA: 0x0017DCD0 File Offset: 0x0017BED0
	private int a()
	{
		switch (bpo.GetServiceOrThrow<bu6>().aq2())
		{
		case GameDifficulty.Easy:
			return 15;
		case GameDifficulty.Hard:
			return 4;
		case GameDifficulty.Dominating:
			return 2;
		}
		return 5;
	}
}
