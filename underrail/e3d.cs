using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02001095 RID: 4245
[eiz("BLO2")]
[Serializable]
public sealed class e3d : cze
{
	// Token: 0x060058E4 RID: 22756 RVA: 0x00268328 File Offset: 0x00266528
	private e3d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("BLO2:T", typeof(edx)) as edx);
		this.b = (A_0.GetValue("BLO2:O", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
		this.c = A_0.GetBoolean("BLO2:A");
		if (ell.a() >= 460)
		{
			this.d = A_0.GetBoolean("BLO2:S");
			return;
		}
		this.d = true;
	}

	// Token: 0x060058E5 RID: 22757 RVA: 0x002683C0 File Offset: 0x002665C0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BLO2:T", this.a);
		info.AddValue("BLO2:O", this.b);
		info.AddValue("BLO2:A", this.c);
		info.AddValue("BLO2:S", this.d);
	}

	// Token: 0x060058E6 RID: 22758 RVA: 0x0026841C File Offset: 0x0026661C
	public e3d(edx A_0, EntityAspectReference<amc, amc> A_1, bool A_2 = false, bool A_3 = true)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x060058E7 RID: 22759 RVA: 0x0026844C File Offset: 0x0026664C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a != null && this.a.ao() != null)
		{
			ak1 ak = this.a.ao();
			if ((this.c || !aw1.a(ak, true, null, l9.a)) && aw1.a(ak, true, null, l9.b))
			{
				this.a(ak).a(1.5);
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
								e1d e1d = this.a(ak2);
								if (Math.Abs(i + j) != 1)
								{
									e1d.a(0.4000000059604645);
								}
								else
								{
									e1d.a(0.699999988079071);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060058E8 RID: 22760 RVA: 0x00268570 File Offset: 0x00266770
	private e1d a(ak1 A_0)
	{
		foreach (b0b b0b in A_0.c.Values)
		{
			c5x c5x = (c5x)b0b;
			if (!c5x.IsGround && !c5x.IsFloor)
			{
				break;
			}
			e1d aspect = c5x.GetAspect<e1d>();
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
			a = "Floor\\BlackOilPuddle",
			b = new Point(cuo.a.Next(3), 0)
		});
		e1d e1d = new e1d(c5x2, (this.b != null && this.b.ao() != null) ? this.b.ao().aa().FactionId : null);
		c5x2.SetAspect<e1d>(e1d);
		dm dm = new dm(c5x2);
		dm.d().Add(new ch4());
		c5x2.SetAspect<dm>(dm);
		anc anc = new anc(c5x2);
		anc.a().Add(new bmu());
		c5x2.SetAspect<anc>(anc);
		A_0.Area.a(c5x2);
		avy avy = new avy(e1d);
		avy.Location = A_0.Location;
		avy.Size = new esj(1, 1);
		avy.Layer = aju.x;
		A_0.Area.b(avy);
		return e1d;
	}

	// Token: 0x040023C7 RID: 9159
	private new edx a;

	// Token: 0x040023C8 RID: 9160
	private EntityAspectReference<amc, amc> b;

	// Token: 0x040023C9 RID: 9161
	private bool c;

	// Token: 0x040023CA RID: 9162
	private bool d = true;
}
