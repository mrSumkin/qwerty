using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000F8A RID: 3978
[eiz("SSEA2")]
[Serializable]
public sealed class aoq : Aspect<c5x>, ISerializable, c98, chb
{
	// Token: 0x0600510F RID: 20751 RVA: 0x00247D1C File Offset: 0x00245F1C
	private aoq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("SSEA2:T");
	}

	// Token: 0x06005110 RID: 20752 RVA: 0x00247D38 File Offset: 0x00245F38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSEA2:T", this.a);
	}

	// Token: 0x06005111 RID: 20753 RVA: 0x00247D54 File Offset: 0x00245F54
	public aoq(c5x A_0) : base(A_0)
	{
		this.a = (double)d0u.b;
	}

	// Token: 0x06005112 RID: 20754 RVA: 0x00247D6C File Offset: 0x00245F6C
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			if ((this.a += A_0.b.TotalMilliseconds) >= (double)d0u.b)
			{
				this.a -= (double)d0u.b;
				this.a(false);
				return;
			}
		}
		else
		{
			this.a = (double)d0u.b;
		}
	}

	// Token: 0x06005113 RID: 20755 RVA: 0x00247DD0 File Offset: 0x00245FD0
	public void c()
	{
		this.a(true);
		this.a = 0.0;
	}

	// Token: 0x06005114 RID: 20756 RVA: 0x00247DE8 File Offset: 0x00245FE8
	private void a(bool A_0)
	{
		if (this.b() && this.a())
		{
			List<aoq> list = new List<aoq>();
			foreach (b0b b0b in base.a8().Area.Entities)
			{
				c5x c5x = (c5x)b0b;
				aoq aspect = c5x.GetAspect<aoq>();
				if (c5x != base.a8() && aspect != null && aw1.b(c5x, base.a8()) <= 5.0)
				{
					list.Add(aspect);
				}
			}
			if (this.a(base.a8()))
			{
				foreach (aoq aoq in list)
				{
					this.a(aoq.a8());
				}
			}
		}
	}

	// Token: 0x06005115 RID: 20757 RVA: 0x00247EFC File Offset: 0x002460FC
	private bool b()
	{
		return base.a8() != null && base.a8().Zone != null && !base.a8().Zone.CustomProperties.GetPrimitivePropertyValue<bool>(a46.a, new bool?(false)).Value;
	}

	// Token: 0x06005116 RID: 20758 RVA: 0x00247F54 File Offset: 0x00246154
	private bool a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area == base.a8().Area && aw1.b(c5x, base.a8()) <= 6.0)
			{
				ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
				if (ak != null && ak.b(dm9.b))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06005117 RID: 20759 RVA: 0x00247FF8 File Offset: 0x002461F8
	private bool a(c5x A_0)
	{
		c1a a_ = A_0.Zone;
		aud aud = A_0.Area;
		Vector3 a_2 = A_0.Location;
		HorizontalDirection a_3 = A_0.VisualDirection;
		int num = 1;
		string text = null;
		if (A_0.o.b != null)
		{
			int.TryParse(A_0.o.b.a.Substring(A_0.o.b.a.Length - 1, 1), NumberStyles.Number, CultureInfo.InvariantCulture, out num);
			if (num <= 0)
			{
				num = 1;
			}
			if (A_0.o.b.a == "Creatures\\shs\\c1")
			{
				text = "creatures\\ShroomlingSpitter";
			}
			else
			{
				text = "creatures\\ShroomlingChomper";
			}
		}
		if (text != null)
		{
			c5x c5x = vq.a(text, a_, new bt4(aud.y8(), a_2), false);
			if (c5x != null)
			{
				c5x.Layer = A_0.Layer;
				A_0.w();
				A_0.an();
				c5x.VisualDirection = a_3;
				if (c5x.h.b != null && c5x.i.b != null && c5x.t.b != null)
				{
					c5x.t.b.a(false);
					c5x.t.b.y6()["SleepLoc"] = new bt4(aud.y8(), a_2);
					c5x.h.b.ap = new CharacterState?(CharacterState.Custom2);
					c5x.h.b.aq = new int?(0);
					awx awx = new awx();
					awx.b(false);
					awx.c(false);
					awx.a(false);
					awx.ad().Add(new e4t(c5x.h.b, CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
					awx.ad().Add(new a4s(new epw(null), null, new ar7(c5x), null));
					awx.ad().Add(new a4s(new b16(null), null, new ar7(c5x), null));
					awx.ad().Add(new a4s(new clv(true), null, new ar7(c5x), null));
					c5x.i.b.b(awx, atp.a);
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x04002138 RID: 8504
	private double a;
}
