using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x020010B5 RID: 4277
[eiz("TCX3")]
[Serializable]
public sealed class b9f : cze
{
	// Token: 0x060059D9 RID: 23001 RVA: 0x0026CC40 File Offset: 0x0026AE40
	private b9f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TCX3:T", typeof(edx)) as edx);
		this.b = (A_0.GetValue("TCX3:O", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		if (ell.a() >= 293)
		{
			this.c = A_0.GetBoolean("TCX3:S");
			return;
		}
		this.c = true;
	}

	// Token: 0x060059DA RID: 23002 RVA: 0x0026CCC0 File Offset: 0x0026AEC0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TCX3:T", this.a);
		info.AddValue("TCX3:O", this.b);
		info.AddValue("TCX3:S", this.c);
	}

	// Token: 0x060059DB RID: 23003 RVA: 0x0026CD08 File Offset: 0x0026AF08
	public b9f(edx A_0, EntityAspectReference<amc, amc> A_1, bool A_2 = true)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x060059DC RID: 23004 RVA: 0x0026CD28 File Offset: 0x0026AF28
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a != null && this.a.ao() != null)
		{
			ak1 ak = this.a.ao();
			if (!ak.Formation.b(2L) || ak.Formation.b(128L))
			{
				this.a(ak).a(1.5);
				for (int i = -1; i <= 1; i++)
				{
					for (int j = -1; j <= 1; j++)
					{
						if (i != 0 || j != 0)
						{
							ak1 ak2 = ak.Area.b(ak.Location.X + i, ak.Location.Y + j);
							if (ak2 != null && !ak2.Formation.b(2L))
							{
								zb zb = this.a(ak2);
								if (Math.Abs(i + j) != 1)
								{
									zb.a(0.4000000059604645);
								}
								else
								{
									zb.a(0.699999988079071);
								}
								if (!aw1.a(null, ak2, false, null) && cuo.a.NextDouble() < 0.1)
								{
									vq.a("Object\\Natural\\TchortTumor", ak.Zone, new bt4(ak2.Area.y8(), ak2.Location.a()), false);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060059DD RID: 23005 RVA: 0x0026CE98 File Offset: 0x0026B098
	private zb a(ak1 A_0)
	{
		foreach (b0b b0b in A_0.c.Values)
		{
			c5x c5x = (c5x)b0b;
			if (!c5x.IsGround && !c5x.IsFloor)
			{
				break;
			}
			zb aspect = c5x.GetAspect<zb>();
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
			a = "Floor\\TchortlingPuddle",
			b = new Point(cuo.a.Next(3), 0)
		});
		zb zb = new zb(c5x2, (this.b != null && this.b.ao() != null) ? this.b.ao().aa().FactionId : null);
		c5x2.SetAspect<zb>(zb);
		dm dm = new dm(c5x2);
		dm.d().Add(new e1p());
		c5x2.SetAspect<dm>(dm);
		A_0.Area.a(c5x2);
		d47 d = new d47(zb);
		d.Location = A_0.Location;
		d.Size = new esj(1, 1);
		d.Layer = aju.x;
		A_0.Area.b(d);
		return zb;
	}

	// Token: 0x0400240E RID: 9230
	private new edx a;

	// Token: 0x0400240F RID: 9231
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002410 RID: 9232
	private bool c;
}
