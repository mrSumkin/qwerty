using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.Space;

// Token: 0x0200104D RID: 4173
[eiz("SPF8")]
[Serializable]
public sealed class b20 : ezd, ISerializable
{
	// Token: 0x06005679 RID: 22137 RVA: 0x0025F27C File Offset: 0x0025D47C
	private b20(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600567A RID: 22138 RVA: 0x0025F288 File Offset: 0x0025D488
	public b20(string A_0, bt4 A_1, HorizontalDirection? A_2 = null) : base(A_0, A_1, A_2, null, null, null, null)
	{
	}

	// Token: 0x0600567B RID: 22139 RVA: 0x0025F2BC File Offset: 0x0025D4BC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		base.ym(A_0, A_1, A_2);
		if (base.f() != null)
		{
			c5x c5x = base.f().ao() as c5x;
			if (c5x != null)
			{
				ah7 ah = this.a(c5x);
				if (c5x.i.b == null)
				{
					ny aspect = new ny(c5x);
					c5x.SetAspect<ny>(aspect);
				}
				dxo aspect2 = new dxo(c5x, ah.Name, 0.42f, 0.5f, 0.0005);
				c5x.SetAspect<dxo>(aspect2);
				c5x.Layer = aju.x;
				dm dm = new dm(c5x);
				dm.d().Add(new ez());
				c5x.SetAspect<dm>(dm);
				c5x.c().a("flare", "FlareBurning", 1f, c9z.a, true, false);
			}
		}
	}

	// Token: 0x0600567C RID: 22140 RVA: 0x0025F38C File Offset: 0x0025D58C
	private ah7 a(c5x A_0)
	{
		ah7 ah = new ah7("flareLantern" + Guid.NewGuid().ToString(), null);
		ah.Layer = aju.x;
		ah.Light = new ae8(new Color(80, 255, 255), 0.5f, LightType.Increment);
		ah.Range = 4f;
		ah.LightFadeRate = 0.1f;
		ah.g().be(A_0);
		return ah;
	}
}
