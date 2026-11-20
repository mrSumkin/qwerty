using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x020010F1 RID: 4337
[eiz("ACX5")]
[Serializable]
public sealed class dku : cze
{
	// Token: 0x06005BD7 RID: 23511 RVA: 0x002762B8 File Offset: 0x002744B8
	private dku(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("ACX5:T", typeof(edx)) as edx);
		if (ell.a() >= 141)
		{
			this.b = (A_0.GetValue("ACX5:O", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		}
		if (ell.a() >= 355)
		{
			this.c = A_0.GetBoolean("ACX5:A");
		}
		if (ell.a() >= 457)
		{
			this.d = A_0.GetBoolean("ACX5:S");
		}
		else
		{
			this.d = true;
		}
		if (ell.a() >= 465)
		{
			this.e = A_0.GetBoolean("ACX5:P");
		}
	}

	// Token: 0x06005BD8 RID: 23512 RVA: 0x00276390 File Offset: 0x00274590
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ACX5:T", this.a);
		info.AddValue("ACX5:O", this.b);
		info.AddValue("ACX5:A", this.c);
		info.AddValue("ACX5:S", this.d);
		info.AddValue("ACX5:P", this.e);
	}

	// Token: 0x06005BD9 RID: 23513 RVA: 0x002763FC File Offset: 0x002745FC
	public dku(edx A_0, EntityAspectReference<amc, amc> A_1, bool A_2 = false, bool A_3 = true, bool A_4 = false)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
	}

	// Token: 0x06005BDA RID: 23514 RVA: 0x00276434 File Offset: 0x00274634
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a != null && this.a.ao() != null)
		{
			ak1 ak = this.a.ao();
			if (!aw1.a(ak, true, null, l9.a))
			{
				this.a(ak).b(1.5);
			}
			if (this.d)
			{
				for (int i = -1; i <= 1; i++)
				{
					for (int j = -1; j <= 1; j++)
					{
						if (i != 0 || j != 0)
						{
							ak1 ak2 = ak.Area.b(ak.Location.X + i, ak.Location.Y + j);
							if (ak2 != null && !aw1.a(ak2, true, null, l9.a))
							{
								e11 e = this.a(ak2);
								if (Math.Abs(i + j) != 1)
								{
									e.b(0.4000000059604645);
								}
								else
								{
									e.b(0.699999988079071);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005BDB RID: 23515 RVA: 0x0027653C File Offset: 0x0027473C
	private e11 a(ak1 A_0)
	{
		foreach (b0b b0b in A_0.c.Values)
		{
			c5x c5x = (c5x)b0b;
			if (!c5x.IsGround && !c5x.IsFloor)
			{
				break;
			}
			e11 aspect = c5x.GetAspect<e11>();
			if (aspect != null)
			{
				aspect.a(this.e);
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
			a = "Floor\\AcidPuddle",
			b = new Point(cuo.a.Next(3), 0)
		});
		e11 e = new e11(c5x2, (this.b != null && this.b.ao() != null) ? this.b.ao().aa().FactionId : null);
		e.a(this.e);
		c5x2.SetAspect<e11>(e);
		dm dm = new dm(c5x2);
		dm.d().Add(new e6f());
		c5x2.SetAspect<dm>(dm);
		A_0.Area.a(c5x2);
		ed0 ed = new ed0(e);
		ed.Location = A_0.Location;
		ed.Size = new esj(1, 1);
		ed.Layer = aju.x;
		A_0.Area.b(ed);
		return e;
	}

	// Token: 0x040024B1 RID: 9393
	private new edx a;

	// Token: 0x040024B2 RID: 9394
	private EntityAspectReference<amc, amc> b;

	// Token: 0x040024B3 RID: 9395
	private bool c;

	// Token: 0x040024B4 RID: 9396
	private bool d = true;

	// Token: 0x040024B5 RID: 9397
	private bool e;
}
