using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200024B RID: 587
[eiz("W")]
[Serializable]
public class csd : dcm, a9q, bvq, ISerializable
{
	// Token: 0x060010A9 RID: 4265 RVA: 0x00044C38 File Offset: 0x00042E38
	protected csd(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("W:N");
			this.b = A_0.GetString("W:AN");
			this.c = (Vector3)A_0.GetValue("W:L", typeof(Vector3));
			this.d = (HorizontalDirection)A_0.GetValue("W:D", typeof(HorizontalDirection));
			this.h = (c1a)A_0.GetValue("W:Z", typeof(c1a));
			this.i = A_0.GetInt32("W:L1");
			return;
		}
		if (base.GetType() == typeof(csd))
		{
			this.a = A_0.GetString("_Name");
			this.b = A_0.GetString("_AreaName");
			this.c = (Vector3)A_0.GetValue("_Location", typeof(Vector3));
			this.d = (HorizontalDirection)A_0.GetValue("_Direction", typeof(HorizontalDirection));
			this.h = (c1a)A_0.GetValue("_Zone", typeof(c1a));
			this.i = A_0.GetInt32("_Layer");
			return;
		}
		this.a = A_0.GetString("Waypoint+_Name");
		this.b = A_0.GetString("Waypoint+_AreaName");
		this.c = (Vector3)A_0.GetValue("Waypoint+_Location", typeof(Vector3));
		this.d = (HorizontalDirection)A_0.GetValue("Waypoint+_Direction", typeof(HorizontalDirection));
		this.h = (c1a)A_0.GetValue("Waypoint+_Zone", typeof(c1a));
		this.i = A_0.GetInt32("Waypoint+_Layer");
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00044E2C File Offset: 0x0004302C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("W:N", this.a);
		info.AddValue("W:AN", this.b);
		info.AddValue("W:L", this.c);
		info.AddValue("W:D", this.d);
		info.AddValue("W:Z", this.h);
		info.AddValue("W:L1", this.i);
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x060010AB RID: 4267 RVA: 0x00044EAC File Offset: 0x000430AC
	// (set) Token: 0x060010AC RID: 4268 RVA: 0x00044EB4 File Offset: 0x000430B4
	[Category("System")]
	public string Name
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060010AD RID: 4269 RVA: 0x00044EC0 File Offset: 0x000430C0
	// (set) Token: 0x060010AE RID: 4270 RVA: 0x00044EC8 File Offset: 0x000430C8
	[Category("Spatial")]
	public string AreaName
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
			this.e();
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060010AF RID: 4271 RVA: 0x00044ED8 File Offset: 0x000430D8
	// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00044EE0 File Offset: 0x000430E0
	[Category("Spatial")]
	public Vector3 Location
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
			this.e();
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00044EF0 File Offset: 0x000430F0
	// (set) Token: 0x060010B2 RID: 4274 RVA: 0x00044EF8 File Offset: 0x000430F8
	[Category("Spatial")]
	public HorizontalDirection Direction
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00044F04 File Offset: 0x00043104
	[Browsable(false)]
	public bool Initialized
	{
		get
		{
			return this.e;
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00044F0C File Offset: 0x0004310C
	[Browsable(false)]
	public aud Area
	{
		get
		{
			return this.f;
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00044F14 File Offset: 0x00043114
	[Browsable(false)]
	public ak1 Tile
	{
		get
		{
			return this.g;
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00044F1C File Offset: 0x0004311C
	// (set) Token: 0x060010B7 RID: 4279 RVA: 0x00044F24 File Offset: 0x00043124
	[Browsable(false)]
	public c1a Zone
	{
		get
		{
			return this.h;
		}
		internal set
		{
			this.h = value;
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060010B8 RID: 4280 RVA: 0x00044F30 File Offset: 0x00043130
	// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00044F38 File Offset: 0x00043138
	[Category("Meta")]
	public int Layer
	{
		get
		{
			return this.i;
		}
		set
		{
			this.i = value;
		}
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x00044F44 File Offset: 0x00043144
	public csd(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x00044F54 File Offset: 0x00043154
	public bool bc(bool A_0)
	{
		this.e();
		this.e = true;
		return true;
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x00044F64 File Offset: 0x00043164
	public bool bd(bool A_0)
	{
		this.f = null;
		this.g = null;
		this.e = false;
		return true;
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x00044F80 File Offset: 0x00043180
	public void e()
	{
		if (this.h != null && !string.IsNullOrEmpty(this.b))
		{
			this.f = this.h.n(this.b);
			if (this.f != null)
			{
				this.g = this.f.b((int)this.c.X, (int)this.c.Y);
			}
		}
	}

	// Token: 0x04000999 RID: 2457
	private string a;

	// Token: 0x0400099A RID: 2458
	private string b;

	// Token: 0x0400099B RID: 2459
	private Vector3 c;

	// Token: 0x0400099C RID: 2460
	private HorizontalDirection d;

	// Token: 0x0400099D RID: 2461
	[NonSerialized]
	private bool e;

	// Token: 0x0400099E RID: 2462
	[NonSerialized]
	private aud f;

	// Token: 0x0400099F RID: 2463
	[NonSerialized]
	private ak1 g;

	// Token: 0x040009A0 RID: 2464
	private c1a h;

	// Token: 0x040009A1 RID: 2465
	private int i;
}
