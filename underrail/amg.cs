using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02001088 RID: 4232
[eiz("RCX5")]
[Serializable]
public sealed class amg : cze
{
	// Token: 0x06005844 RID: 22596 RVA: 0x00265344 File Offset: 0x00263544
	private amg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("RCX5:T", typeof(edx)) as edx);
		this.b = (A_0.GetValue("RCX5:O", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
	}

	// Token: 0x06005845 RID: 22597 RVA: 0x0026539C File Offset: 0x0026359C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RCX5:T", this.a);
		info.AddValue("RCX5:O", this.b);
	}

	// Token: 0x06005846 RID: 22598 RVA: 0x002653C8 File Offset: 0x002635C8
	public amg(edx A_0, EntityAspectReference<amc, amc> A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06005847 RID: 22599 RVA: 0x002653E0 File Offset: 0x002635E0
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
							d16 d = this.a(ak2);
							if (Math.Abs(i + j) != 1)
							{
								d.b(0.4000000059604645);
							}
							else
							{
								d.b(0.699999988079071);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005848 RID: 22600 RVA: 0x002654E0 File Offset: 0x002636E0
	private d16 a(ak1 A_0)
	{
		foreach (b0b b0b in A_0.c.Values)
		{
			c5x c5x = (c5x)b0b;
			if (!c5x.IsGround && !c5x.IsFloor)
			{
				break;
			}
			d16 aspect = c5x.GetAspect<d16>();
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
			a = "Floor\\RustingAcidPuddle",
			b = new Point(cuo.a.Next(3), 0)
		});
		d16 d = new d16(c5x2, (this.b != null && this.b.ao() != null) ? this.b.ao().aa().FactionId : null);
		c5x2.SetAspect<d16>(d);
		dm dm = new dm(c5x2);
		dm.d().Add(new a5u());
		c5x2.SetAspect<dm>(dm);
		A_0.Area.a(c5x2);
		s8 s = new s8(d);
		s.Location = A_0.Location;
		s.Size = new esj(1, 1);
		s.Layer = aju.x;
		A_0.Area.b(s);
		return d;
	}

	// Token: 0x04002398 RID: 9112
	private new edx a;

	// Token: 0x04002399 RID: 9113
	private EntityAspectReference<amc, amc> b;
}
