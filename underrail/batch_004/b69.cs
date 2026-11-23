using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x020010B1 RID: 4273
[eiz("CCX5")]
[Serializable]
public sealed class b69 : cze
{
	// Token: 0x060059CB RID: 22987 RVA: 0x0026C434 File Offset: 0x0026A634
	private b69(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("CCX5:T", typeof(edx)) as edx);
		this.b = (A_0.GetValue("CCX5:O", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
	}

	// Token: 0x060059CC RID: 22988 RVA: 0x0026C48C File Offset: 0x0026A68C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCX5:T", this.a);
		info.AddValue("CCX5:O", this.b);
	}

	// Token: 0x060059CD RID: 22989 RVA: 0x0026C4B8 File Offset: 0x0026A6B8
	public b69(edx A_0, EntityAspectReference<amc, amc> A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x060059CE RID: 22990 RVA: 0x0026C4D0 File Offset: 0x0026A6D0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a != null && this.a.ao() != null)
		{
			ak1 ak = this.a.ao();
			if (!aw1.a(ak, true, null, l9.a))
			{
				this.a(ak).b(1.5);
			}
			for (int i = -1; i <= 1; i++)
			{
				for (int j = -1; j <= 1; j++)
				{
					if (i != 0 || j != 0)
					{
						ak1 ak2 = ak.Area.b(ak.Location.X + i, ak.Location.Y + j);
						if (ak2 != null && !aw1.a(ak2, true, null, l9.a))
						{
							ey7 ey = this.a(ak2);
							if (Math.Abs(i + j) != 1)
							{
								ey.b(0.4000000059604645);
							}
							else
							{
								ey.b(0.699999988079071);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060059CF RID: 22991 RVA: 0x0026C5D0 File Offset: 0x0026A7D0
	private ey7 a(ak1 A_0)
	{
		foreach (b0b b0b in A_0.c.Values)
		{
			c5x c5x = (c5x)b0b;
			if (!c5x.IsGround && !c5x.IsFloor)
			{
				break;
			}
			ey7 aspect = c5x.GetAspect<ey7>();
			if (aspect != null)
			{
				return aspect;
			}
		}
		c5x c5x2 = new c5x();
		c5x2.Location = A_0.Location.a();
		c5x2.Size = new Vector3(1f, 1f, 0.1f);
		c5x2.IsGround = true;
		c5x2.h = 10;
		c5x2.Layer = aju.x;
		c5x2.SetAspect<cd0>(new cd0(c5x2)
		{
			a = "Floor\\CorrosiveAcidPuddle",
			b = new Point(cuo.a.Next(3), 0)
		});
		ey7 ey = new ey7(c5x2, (this.b != null && this.b.ao() != null) ? this.b.ao().aa().FactionId : null);
		c5x2.SetAspect<ey7>(ey);
		dm dm = new dm(c5x2);
		dm.d().Add(new d9f());
		c5x2.SetAspect<dm>(dm);
		A_0.Area.a(c5x2);
		sl sl = new sl(ey);
		sl.Location = A_0.Location;
		sl.Size = new esj(1, 1);
		sl.Layer = aju.x;
		A_0.Area.b(sl);
		return ey;
	}

	// Token: 0x0400240C RID: 9228
	private new edx a;

	// Token: 0x0400240D RID: 9229
	private EntityAspectReference<amc, amc> b;
}
