using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200024A RID: 586
[eiz("SP")]
[TypeConverter(typeof(ExpandableObjectConverter))]
[Serializable]
public sealed class bt4 : ISerializable
{
	// Token: 0x06001099 RID: 4249 RVA: 0x00044938 File Offset: 0x00042B38
	private bt4(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Vector3)A_0.GetValue("SP:L", typeof(Vector3));
			this.b = A_0.GetString("SP:A");
			this.c = A_0.GetString("SP:WN");
			return;
		}
		if (base.GetType() == typeof(bt4))
		{
			this.a = (Vector3)A_0.GetValue("_Location", typeof(Vector3));
			this.b = A_0.GetString("_Area");
			this.c = A_0.GetString("_WaypointName");
			return;
		}
		this.a = (Vector3)A_0.GetValue("SpatialPointer+_Location", typeof(Vector3));
		this.b = A_0.GetString("SpatialPointer+_Area");
		this.c = A_0.GetString("SpatialPointer+_WaypointName");
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x00044A38 File Offset: 0x00042C38
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SP:L", this.a);
		info.AddValue("SP:A", this.b);
		info.AddValue("SP:WN", this.c);
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00044A74 File Offset: 0x00042C74
	public Vector3 a()
	{
		return this.a;
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x00044A7C File Offset: 0x00042C7C
	public void a(Vector3 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x00044A88 File Offset: 0x00042C88
	public string e()
	{
		return this.b;
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x00044A90 File Offset: 0x00042C90
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x00044A9C File Offset: 0x00042C9C
	public string b()
	{
		return this.c;
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00044AA4 File Offset: 0x00042CA4
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x00044AB0 File Offset: 0x00042CB0
	public bool d()
	{
		return !string.IsNullOrWhiteSpace(this.c);
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x00044AC0 File Offset: 0x00042CC0
	public bool c()
	{
		return this.d() || !string.IsNullOrWhiteSpace(this.b);
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x00044AE0 File Offset: 0x00042CE0
	public bt4()
	{
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x00044AE8 File Offset: 0x00042CE8
	public bt4(string A_0, Vector3 A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x00044B00 File Offset: 0x00042D00
	public bt4(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x00044B14 File Offset: 0x00042D14
	public void a(c1a A_0, out aud A_1, out Vector3 A_2)
	{
		HorizontalDirection horizontalDirection;
		this.a(A_0, out A_1, out A_2, out horizontalDirection);
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00044B2C File Offset: 0x00042D2C
	public void a(c1a A_0, out aud A_1, out Vector3 A_2, out HorizontalDirection A_3)
	{
		A_1 = null;
		A_2 = Vector3.Zero;
		A_3 = HorizontalDirection.North;
		if (A_0 != null)
		{
			if (this.d())
			{
				csd csd = A_0.g(this.c);
				if (csd != null)
				{
					A_1 = csd.Area;
					if (A_1 == null && csd.Zone != null && csd.AreaName != null)
					{
						A_1 = csd.Zone.n(csd.AreaName);
					}
					if (A_1 != null)
					{
						A_2 = csd.Location;
					}
					A_3 = csd.Direction;
					return;
				}
			}
			else if (!string.IsNullOrWhiteSpace(this.b))
			{
				A_1 = A_0.n(this.b);
				if (A_1 != null)
				{
					A_2 = this.a;
				}
			}
		}
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x00044BF8 File Offset: 0x00042DF8
	public override string ToString()
	{
		if (!string.IsNullOrEmpty(this.c))
		{
			return string.Format("'{0}'", this.c);
		}
		return string.Format("{0}::[{1}]", this.b, this.a);
	}

	// Token: 0x04000996 RID: 2454
	private Vector3 a;

	// Token: 0x04000997 RID: 2455
	private string b;

	// Token: 0x04000998 RID: 2456
	private string c;
}
