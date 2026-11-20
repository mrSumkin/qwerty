using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.Space;

// Token: 0x02001103 RID: 4355
[eiz("SF8")]
[Serializable]
public sealed class blt : ezd, ISerializable
{
	// Token: 0x06005C65 RID: 23653 RVA: 0x00277F38 File Offset: 0x00276138
	private blt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005C66 RID: 23654 RVA: 0x00277F44 File Offset: 0x00276144
	public blt(string A_0, bt4 A_1, HorizontalDirection? A_2 = null) : base(A_0, A_1, A_2, null, null, null, null)
	{
	}

	// Token: 0x06005C67 RID: 23655 RVA: 0x00277F78 File Offset: 0x00276178
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
				dxo aspect2 = new dxo(c5x, ah.Name, 0.68f, 0.8f, 0.0007);
				c5x.SetAspect<dxo>(aspect2);
				c5x.Layer = aju.x;
				dm dm = new dm(c5x);
				dm.d().Add(new ez());
				c5x.SetAspect<dm>(dm);
				c5x.c().a("flare", "FlareBurning", 1f, c9z.a, true, false);
			}
		}
	}

	// Token: 0x06005C68 RID: 23656 RVA: 0x00278048 File Offset: 0x00276248
	private ah7 a(c5x A_0)
	{
		ah7 ah = new ah7("flareLantern" + Guid.NewGuid().ToString(), null);
		ah.Layer = aju.x;
		ah.Light = new ae8(new Color(255, 100, 20), 0.8f, LightType.Increment);
		ah.Range = 5f;
		ah.LightFadeRate = 0.13f;
		ah.g().be(A_0);
		return ah;
	}
}
