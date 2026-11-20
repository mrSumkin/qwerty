using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000A95 RID: 2709
[eiz("T10")]
[Serializable]
public sealed class dvy : cze, ISerializable
{
	// Token: 0x06003F85 RID: 16261 RVA: 0x00181B0C File Offset: 0x0017FD0C
	private dvy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("T10:P");
	}

	// Token: 0x06003F86 RID: 16262 RVA: 0x00181B28 File Offset: 0x0017FD28
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("T10:P", this.a);
	}

	// Token: 0x06003F87 RID: 16263 RVA: 0x00181B44 File Offset: 0x0017FD44
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003F88 RID: 16264 RVA: 0x00181B4C File Offset: 0x0017FD4C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003F89 RID: 16265 RVA: 0x00181B58 File Offset: 0x0017FD58
	public dvy()
	{
	}

	// Token: 0x06003F8A RID: 16266 RVA: 0x00181B60 File Offset: 0x0017FD60
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Zone != null && c5x.i.b != null && c5x.h.b != null)
		{
			bool flag = true;
			a3f a3f = c5x.GetAspect<a3f>();
			if (a3f != null)
			{
				flag = !a3f.a().GetPrimitivePropertyValue<bool>(bah.b, new bool?(false)).Value;
				a3f.a().RemoveProperty(bah.b);
			}
			else
			{
				a3f = new a3f(c5x);
				c5x.SetAspect<a3f>(a3f);
			}
			a3f.a()[bah.b] = true;
			awx awx = new awx("turretStateChange");
			awx awx2 = awx;
			awx2.a(awx2.kh() | (m7.b | m7.k));
			awx.a(false);
			if (!flag)
			{
				c5x.c().a("stateChange", c5x.h.b.am() + (this.a ? "Activate" : "Deactivate"), 1f, c9z.a, false, false);
			}
			if (!flag)
			{
				e4t item = new e4t(c5x.h.b, this.a ? CharacterState.Custom2 : CharacterState.Custom3, dz6.b(cux.a), 0, null, 1);
				awx.ad().Add(item);
			}
			c5x.i.b.b(awx, atp.a);
			if (this.a)
			{
				if (c5x.t.b != null)
				{
					string classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<string>(ddq.at);
					if (classPropertyValue != null)
					{
						c5x.h.b.aa().FactionId = classPropertyValue;
					}
				}
				c5x.h.b.aq = null;
				c5x.h.b.ap = null;
				c5x.h.b.aa().Passive = false;
				return;
			}
			c5x.h.b.aq = new int?(0);
			c5x.h.b.ap = new CharacterState?(CharacterState.Custom1);
			if (c5x.t.b != null)
			{
				new bzv(c5x.t.b.y6()).e();
				string classPropertyValue2 = c5x.t.b.y6().GetClassPropertyValue<string>(ddq.au);
				if (classPropertyValue2 != null)
				{
					c5x.h.b.aa().FactionId = classPropertyValue2;
				}
			}
			c5x.h.b.aa().Passive = true;
		}
	}

	// Token: 0x04001BDB RID: 7131
	private new bool a;
}
