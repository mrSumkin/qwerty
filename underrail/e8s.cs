using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001147 RID: 4423
[eiz("RAJUA")]
[Serializable]
public sealed class e8s : b1z, bgn, ISerializable
{
	// Token: 0x06005EC5 RID: 24261 RVA: 0x00281EA0 File Offset: 0x002800A0
	private e8s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (A_0.GetValue("RAJUA:J", typeof(ar7)) as ar7);
		this.d = A_0.GetSingle("RAJUA:S");
		this.e = (HorizontalDirection)A_0.GetValue("RAJUA:D", typeof(HorizontalDirection));
		this.f = A_0.GetSingle("RAJUA:V");
		this.g = A_0.GetSingle("RAJUA:G");
		this.h = A_0.GetInt32("RAJUA:B");
	}

	// Token: 0x06005EC6 RID: 24262 RVA: 0x00281F3C File Offset: 0x0028013C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RAJUA:J", this.c);
		info.AddValue("RAJUA:S", this.d);
		info.AddValue("RAJUA:D", this.e);
		info.AddValue("RAJUA:V", this.f);
		info.AddValue("RAJUA:G", this.g);
		info.AddValue("RAJUA:B", this.h);
	}

	// Token: 0x06005EC7 RID: 24263 RVA: 0x00281FBC File Offset: 0x002801BC
	public int? tm()
	{
		return new int?(0);
	}

	// Token: 0x06005EC8 RID: 24264 RVA: 0x00281FC4 File Offset: 0x002801C4
	public CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Custom6);
	}

	// Token: 0x06005EC9 RID: 24265 RVA: 0x00281FD0 File Offset: 0x002801D0
	public object fm()
	{
		return null;
	}

	// Token: 0x06005ECA RID: 24266 RVA: 0x00281FD4 File Offset: 0x002801D4
	public ci8? oi()
	{
		return new ci8?(ci8.a);
	}

	// Token: 0x06005ECB RID: 24267 RVA: 0x00281FDC File Offset: 0x002801DC
	public e8s(c5x A_0, float A_1, HorizontalDirection A_2)
	{
		this.c = new ar7(A_0);
		this.d = A_1;
		this.e = A_2;
	}

	// Token: 0x06005ECC RID: 24268 RVA: 0x00282000 File Offset: 0x00280200
	protected override dc4 dt()
	{
		if (!this.b())
		{
			return dc4.e;
		}
		c5x c5x = this.c.ao() as c5x;
		yh.a(c5x.Area, c5x.Location, null, "xpbl_JetSkiMetalRampJump", 1f, c9z.a);
		this.f = this.d;
		return dc4.b;
	}

	// Token: 0x06005ECD RID: 24269 RVA: 0x00282058 File Offset: 0x00280258
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (!this.b())
		{
			return dc4.e;
		}
		c5x c5x = this.c.ao() as c5x;
		float num = Convert.ToSingle(A_1.TotalMilliseconds / 1000.0) / dz6.a().GetValueOrDefault(1f);
		this.g += e8s.a * num;
		this.f *= 1f - e8s.b * num;
		Vector3 value = (this.a() * this.f + new Vector3(0f, 0f, -1f) * this.g) * num;
		c5x.Location += value;
		if (c5x.Location.Z <= 0f)
		{
			if (this.c())
			{
				return dc4.c;
			}
			float a_ = Convert.ToSingle(Math.Pow(0.699999988079071, (double)this.h));
			this.h++;
			yh.a(c5x.Area, c5x.Location, null, "xpbl_JetSkiWaterLanding", a_, c9z.a);
			this.f = this.d * Convert.ToSingle(Math.Pow(0.4000000059604645, (double)this.h));
			if (this.f < 1f)
			{
				c5x.VisualPriority = 0;
				c5x.Location = new Vector3(c5x.Location.X, c5x.Location.Y, 0f);
				c5x.ah();
				c5x.h.b.ay.a(c5x.h.b, 10);
				return dc4.c;
			}
			c5x.Location = new Vector3(c5x.Location.X, c5x.Location.Y, 0f);
			c5x.ah();
			this.g = 0f;
			c5x.h.b.ay.a(c5x.h.b, 5);
		}
		else
		{
			c5x.VisualPriority = 90;
			c5x.ah();
		}
		return dc4.b;
	}

	// Token: 0x06005ECE RID: 24270 RVA: 0x0028228C File Offset: 0x0028048C
	private bool c()
	{
		c5x c5x = this.c.ao() as c5x;
		HashSet<c5x> hashSet = new HashSet<c5x>();
		HashSet<amc> hashSet2 = new HashSet<amc>();
		foreach (ak1 ak in c5x.l)
		{
			foreach (b0b b0b in ak.c.Values)
			{
				c5x c5x2 = (c5x)b0b;
				if (c5x2 != c5x && !hashSet.Contains(c5x2) && c5x2.h.b != null && c5x2.z != null)
				{
					hashSet2.Add(c5x2.h.b);
				}
				hashSet.Add(c5x2);
			}
		}
		if (hashSet2.Count > 0)
		{
			foreach (amc amc in hashSet2)
			{
				if (amc.aa().Vehicle != null)
				{
					amc.aa().Vehicle.b(int.MaxValue);
				}
				amc.aa().a(null, null, false);
			}
			if (c5x.h.b.aa().Vehicle != null)
			{
				c5x.h.b.aa().Vehicle.b(int.MaxValue);
			}
			c5x.h.b.aa().a(null, null, false);
			return true;
		}
		return false;
	}

	// Token: 0x06005ECF RID: 24271 RVA: 0x00282474 File Offset: 0x00280674
	private bool b()
	{
		if (this.c != null)
		{
			c5x c5x = this.c.ao() as c5x;
			if (c5x != null)
			{
				return c5x.Area != null && c5x.h != null && c5x.h.b != null;
			}
		}
		return false;
	}

	// Token: 0x06005ED0 RID: 24272 RVA: 0x002824CC File Offset: 0x002806CC
	private Vector3 a()
	{
		float num = 1.5f;
		float z = 1f;
		Vector3 result;
		switch (this.e)
		{
		case HorizontalDirection.North:
			result = new Vector3(0f, -num, z);
			goto IL_83;
		case HorizontalDirection.East:
			result = new Vector3(num, 0f, z);
			goto IL_83;
		case HorizontalDirection.South:
			result = new Vector3(0f, num, z);
			goto IL_83;
		}
		result = new Vector3(-num, 0f, z);
		IL_83:
		result.Normalize();
		return result;
	}

	// Token: 0x040025A2 RID: 9634
	private new static readonly float a = 9.8f;

	// Token: 0x040025A3 RID: 9635
	private static readonly float b = 0.15f;

	// Token: 0x040025A4 RID: 9636
	private ar7 c;

	// Token: 0x040025A5 RID: 9637
	private float d;

	// Token: 0x040025A6 RID: 9638
	private HorizontalDirection e;

	// Token: 0x040025A7 RID: 9639
	private float f;

	// Token: 0x040025A8 RID: 9640
	private float g;

	// Token: 0x040025A9 RID: 9641
	private int h;
}
