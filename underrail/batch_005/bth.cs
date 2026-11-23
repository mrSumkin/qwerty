using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02001280 RID: 4736
[eiz("PXR")]
[Serializable]
public sealed class bth : Aspect<c5x>, ISerializable
{
	// Token: 0x060066E1 RID: 26337 RVA: 0x002BB2B8 File Offset: 0x002B94B8
	private bth(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("PXR:E", typeof(b0b)) as b0b);
		this.b = (A_0.GetValue("PXR:C", typeof(dth)) as dth);
	}

	// Token: 0x060066E2 RID: 26338 RVA: 0x002BB310 File Offset: 0x002B9510
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PXR:E", this.a);
		info.AddValue("PXR:C", this.b);
	}

	// Token: 0x060066E3 RID: 26339 RVA: 0x002BB33C File Offset: 0x002B953C
	public bth(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060066E4 RID: 26340 RVA: 0x002BB348 File Offset: 0x002B9548
	public void a(c1a A_0 = null, Guid? A_1 = null)
	{
		c1a c1a;
		if (A_0 != null)
		{
			c1a = A_0;
		}
		else
		{
			c1a = base.a8().Zone;
		}
		ak1 ak = null;
		bm6 aspect = this.a.GetAspect<bm6>();
		if (aspect != null)
		{
			bt4 classPropertyValue = aspect.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue != null)
			{
				aud aud;
				Vector3 vector;
				classPropertyValue.a(c1a, out aud, out vector);
				if (aud != null)
				{
					ak = aud.b((int)vector.X, (int)vector.Y);
				}
			}
			List<string> classPropertyValue2 = aspect.y6().GetClassPropertyValue<List<string>>(ddq.k);
			if (classPropertyValue2 != null && classPropertyValue2.Count > 0)
			{
				csd csd = c1a.g(classPropertyValue2[0]);
				if (csd != null)
				{
					ak = csd.Tile;
				}
			}
		}
		if (ak == null)
		{
			aud aud2;
			if (A_1 != null)
			{
				aud2 = c1a.d(A_1.Value);
			}
			else
			{
				aud2 = base.a8().Area;
			}
			if (aud2 != null)
			{
				ak = aud2.b((int)base.a8().Location.X, (int)base.a8().Location.Y);
			}
		}
		if (ak != null)
		{
			aud aud3;
			if (A_1 != null)
			{
				aud3 = c1a.d(A_1.Value);
			}
			else
			{
				aud3 = base.a8().Area;
			}
			if (aud3 != null)
			{
				aud3.l();
				if (aud3 != base.a8().Area)
				{
					base.a8().Area.l();
				}
				b0b b0b = vq.a(this.a);
				b0b.Location = base.a8().Location;
				b0b.Layer = aju.x;
				base.a8().Area.a(b0b);
				base.a8().w();
				base.a8().an();
				cix cix = b0b.Zone.ActionManager;
				aby aby = new aby();
				aby.a(new e6z(b0b.Area));
				aby.a(b0b.Location);
				aby.a(true);
				cix.g9(new a4s(aby, new ar7(b0b), null, null), atp.a);
			}
		}
	}

	// Token: 0x04002AA6 RID: 10918
	public b0b a;

	// Token: 0x04002AA7 RID: 10919
	public dth b;
}
